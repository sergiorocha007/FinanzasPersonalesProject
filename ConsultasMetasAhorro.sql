USE [SistemaFinanzasPersonales]
GO

-- ============================================================
-- PASO 1: ELIMINAR TABLA MetasAhorro (limpia índices y restricciones)
-- ============================================================

-- Eliminar FK si existe alguna que apunte a MetasAhorro desde otra tabla
-- (ajusta el nombre si tienes FKs personalizadas en otras tablas)
IF OBJECT_ID('dbo.MetasAhorro', 'U') IS NOT NULL
BEGIN
    -- Eliminar todas las restricciones (FK, PK, DEFAULT, CHECK) antes de borrar
    DECLARE @sql NVARCHAR(MAX) = '';

    SELECT @sql += 'ALTER TABLE [dbo].[MetasAhorro] DROP CONSTRAINT [' + name + '];' + CHAR(13)
    FROM sys.objects
    WHERE parent_object_id = OBJECT_ID('dbo.MetasAhorro')
      AND type IN ('C', 'D', 'F', 'PK', 'UQ');

    EXEC sp_executesql @sql;

    DROP TABLE dbo.MetasAhorro;
END
GO

-- ============================================================
-- PASO 2: CREAR TABLA MetasAhorro LIMPIA
-- ============================================================
CREATE TABLE dbo.MetasAhorro
(
    Id             INT           NOT NULL IDENTITY(1,1),
    UsuarioId      INT           NOT NULL,
    Nombre         VARCHAR(100)  NOT NULL,
    MontoObjetivo  DECIMAL(18,2) NOT NULL,
    MontoActual    DECIMAL(18,2) NOT NULL CONSTRAINT DF_MetasAhorro_MontoActual    DEFAULT 0.00,
    FechaLimite    DATE          NOT NULL,
    Estado         VARCHAR(20)   NOT NULL CONSTRAINT DF_MetasAhorro_Estado         DEFAULT 'Activa',

    -- Llave primaria
    CONSTRAINT PK_MetasAhorro PRIMARY KEY CLUSTERED (Id ASC),

    -- Llave foránea hacia Usuarios
    CONSTRAINT FK_MetasAhorro_Usuarios FOREIGN KEY (UsuarioId)
        REFERENCES dbo.Usuarios(Id),

    -- Restricciones de negocio en BD
    CONSTRAINT CK_MetasAhorro_MontoObjetivo CHECK (MontoObjetivo > 0),
    CONSTRAINT CK_MetasAhorro_MontoActual   CHECK (MontoActual   >= 0),
    CONSTRAINT CK_MetasAhorro_Estado        CHECK (Estado IN ('Activa', 'Completada', 'Cancelada'))
);
GO

-- ============================================================
-- 1. INSERTAR META DE AHORRO
-- ============================================================
CREATE OR ALTER PROCEDURE sp_MetasAhorro_Insertar
    @UsuarioId     INT,
    @Nombre        VARCHAR(100),
    @MontoObjetivo DECIMAL(18,2),
    @FechaLimite   DATE
AS
BEGIN
    SET NOCOUNT ON;

    IF @MontoObjetivo <= 0
        THROW 50010, 'El monto objetivo debe ser mayor a cero.', 1;

    INSERT INTO MetasAhorro (UsuarioId, Nombre, MontoObjetivo, MontoActual, FechaLimite, Estado)
    VALUES (@UsuarioId, @Nombre, @MontoObjetivo, 0.00, @FechaLimite, 'Activa');

    SELECT CAST(SCOPE_IDENTITY() AS INT) AS IdNuevo;
END
GO

-- ============================================================
-- 2. OBTENER METAS POR USUARIO
-- ============================================================
CREATE OR ALTER PROCEDURE sp_MetasAhorro_ObtenerPorUsuario
    @UsuarioId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Id, UsuarioId, Nombre, MontoObjetivo, MontoActual, FechaLimite, Estado
    FROM MetasAhorro
    WHERE UsuarioId = @UsuarioId
    ORDER BY 
        CASE Estado 
            WHEN 'Activa'     THEN 1 
            WHEN 'Completada' THEN 2 
            ELSE                   3
        END,
        FechaLimite ASC;
END
GO

-- ============================================================
-- 3. ACTUALIZAR META DE AHORRO
-- ============================================================
CREATE OR ALTER PROCEDURE sp_MetasAhorro_Actualizar
    @Id            INT,
    @UsuarioId     INT,
    @Nombre        VARCHAR(100),
    @MontoObjetivo DECIMAL(18,2),
    @FechaLimite   DATE
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM MetasAhorro WHERE Id = @Id AND UsuarioId = @UsuarioId)
        THROW 50011, 'La meta de ahorro no existe o no pertenece al usuario.', 1;

    IF EXISTS (SELECT 1 FROM MetasAhorro WHERE Id = @Id AND Estado <> 'Activa')
        THROW 50012, 'Solo se pueden editar metas en estado Activa.', 1;

    -- Validación: el nuevo objetivo no puede ser menor al monto ya ahorrado
    IF @MontoObjetivo < (SELECT MontoActual FROM MetasAhorro WHERE Id = @Id)
        THROW 50022, 'El nuevo monto objetivo no puede ser menor al monto que ya tienes ahorrado.', 1;

    UPDATE MetasAhorro
    SET Nombre        = @Nombre,
        MontoObjetivo = @MontoObjetivo,
        FechaLimite   = @FechaLimite
    WHERE Id = @Id AND UsuarioId = @UsuarioId;
END
GO

-- ============================================================
-- 4. CAMBIAR ESTADO
-- ============================================================
CREATE OR ALTER PROCEDURE sp_MetasAhorro_CambiarEstado
    @Id        INT,
    @UsuarioId INT,
    @Estado    VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    IF @Estado NOT IN ('Activa', 'Completada', 'Cancelada')
        THROW 50013, 'Estado no válido.', 1;

    UPDATE MetasAhorro
    SET Estado = @Estado
    WHERE Id = @Id AND UsuarioId = @UsuarioId;

    IF @@ROWCOUNT = 0
        THROW 50011, 'La meta de ahorro no existe o no pertenece al usuario.', 1;
END
GO

-- ============================================================
-- 5. ELIMINAR META FÍSICAMENTE
-- ============================================================
CREATE OR ALTER PROCEDURE sp_MetasAhorro_Eliminar
    @Id        INT,
    @UsuarioId INT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM MetasAhorro WHERE Id = @Id AND UsuarioId = @UsuarioId AND MontoActual > 0)
        THROW 50014, 'No se puede eliminar una meta que tiene fondos acumulados. Cancélala para devolver el saldo primero.', 1;

    DELETE FROM MetasAhorro
    WHERE Id = @Id AND UsuarioId = @UsuarioId;

    IF @@ROWCOUNT = 0
        THROW 50011, 'La meta de ahorro no existe o no pertenece al usuario.', 1;
END
GO

-- ============================================================
-- 6. ABONAR A META DE AHORRO (TRANSACCIÓN ATÓMICA)
-- ============================================================
CREATE OR ALTER PROCEDURE sp_MetasAhorro_Abonar
    @UsuarioId INT,
    @MetaId    INT,
    @CuentaId  INT,
    @Monto     DECIMAL(18,2)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    IF @Monto <= 0
        THROW 50015, 'El monto a abonar debe ser mayor a cero.', 1;

    -- Validar cuenta (debe pertenecer al usuario, estar activa y NO ser tarjeta de crédito)
    IF NOT EXISTS (
        SELECT 1 FROM Cuentas 
        WHERE Id = @CuentaId AND UsuarioId = @UsuarioId AND Estado = 1 AND TipoCuenta IN ('Debito', 'Efectivo')
    )
        THROW 50016, 'Cuenta de origen no válida o es una tarjeta de crédito.', 1;

    -- Validar meta
    DECLARE @MontoActual   DECIMAL(18,2),
            @MontoObjetivo DECIMAL(18,2),
            @Estado        VARCHAR(20);

    SELECT @MontoActual   = MontoActual,
           @MontoObjetivo = MontoObjetivo,
           @Estado        = Estado
    FROM MetasAhorro
    WHERE Id = @MetaId AND UsuarioId = @UsuarioId;

    IF @Estado IS NULL
        THROW 50011, 'La meta de ahorro no existe o no pertenece al usuario.', 1;

    IF @Estado <> 'Activa'
        THROW 50017, 'Solo se puede abonar a metas activas.', 1;

    IF (@MontoActual + @Monto) > @MontoObjetivo
        THROW 50018, 'El abono supera el monto objetivo de la meta.', 1;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- 1. Descontar de la cuenta origen (validando saldo atómicamente)
        UPDATE Cuentas
        SET SaldoActual = SaldoActual - @Monto
        WHERE Id = @CuentaId AND SaldoActual >= @Monto;

        IF @@ROWCOUNT = 0
            THROW 50019, 'Saldo insuficiente en la cuenta seleccionada.', 1;

        -- 2. Sumar a la meta y actualizar estado si se completó
        DECLARE @NuevoMonto  DECIMAL(18,2) = @MontoActual + @Monto;
        DECLARE @NuevoEstado VARCHAR(20)   = CASE WHEN @NuevoMonto >= @MontoObjetivo THEN 'Completada' ELSE 'Activa' END;

        UPDATE MetasAhorro
        SET MontoActual = @NuevoMonto,
            Estado      = @NuevoEstado
        WHERE Id = @MetaId;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

-- ============================================================
-- 7. CANCELAR META Y DEVOLVER FONDOS (OPERACIÓN INVERSA)
-- ============================================================
CREATE OR ALTER PROCEDURE sp_MetasAhorro_CancelarYDevolver
    @UsuarioId       INT,
    @MetaId          INT,
    @CuentaDestinoId INT
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    -- Validar cuenta destino
    IF NOT EXISTS (
        SELECT 1 FROM Cuentas 
        WHERE Id = @CuentaDestinoId AND UsuarioId = @UsuarioId AND Estado = 1 AND TipoCuenta IN ('Debito', 'Efectivo')
    )
        THROW 50020, 'Cuenta destino no válida para recibir el reembolso.', 1;

    DECLARE @MontoAcumulado DECIMAL(18,2),
            @Estado         VARCHAR(20);

    SELECT @MontoAcumulado = MontoActual,
           @Estado         = Estado
    FROM MetasAhorro
    WHERE Id = @MetaId AND UsuarioId = @UsuarioId;

    -- Validación: verificar que la meta exista antes de revisar el estado
    IF @Estado IS NULL
        THROW 50011, 'La meta de ahorro no existe o no pertenece al usuario.', 1;

    IF @Estado <> 'Activa'
        THROW 50021, 'Solo se pueden cancelar metas que estén activas.', 1;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- 1. Devolver el dinero acumulado a la cuenta destino (solo si hay saldo > 0)
        IF @MontoAcumulado > 0
        BEGIN
            UPDATE Cuentas
            SET SaldoActual = SaldoActual + @MontoAcumulado
            WHERE Id = @CuentaDestinoId;
        END

        -- 2. Reiniciar MontoActual y marcar como Cancelada
        UPDATE MetasAhorro
        SET MontoActual = 0.00,
            Estado      = 'Cancelada'
        WHERE Id = @MetaId;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO
