USE [SistemaFinanzasPersonales]
GO
-- ============================================================
-- 1. KPI RESUMEN DE TARJETAS SUPERIORES
-- ============================================================
CREATE OR ALTER PROCEDURE sp_Dashboard_ObtenerResumen
    @UsuarioId INT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @MesActual INT = MONTH(GETDATE());
    DECLARE @AnioActual INT = YEAR(GETDATE());
    -- 1. Balance Neto / Patrimonio: Dinero disponible en cuentas de débito y efectivo
    DECLARE @TotalPatrimonio DECIMAL(18,2) = ISNULL((
        SELECT SUM(SaldoActual) 
        FROM Cuentas 
        WHERE UsuarioId = @UsuarioId AND Estado = 1 AND TipoCuenta IN ('Debito', 'Efectivo')
    ), 0.00);
    -- 2. Total Ingresos del Mes Actual
    DECLARE @TotalIngresosMes DECIMAL(18,2) = ISNULL((
        SELECT SUM(t.Monto)
        FROM Transacciones t
        INNER JOIN Cuentas c ON t.CuentaId = c.Id
        WHERE c.UsuarioId = @UsuarioId 
          AND t.TipoTransaccion = 'Ingreso'
          AND MONTH(t.Fecha) = @MesActual 
          AND YEAR(t.Fecha) = @AnioActual
    ), 0.00);
    -- 3. Total Gastos del Mes Actual
    DECLARE @TotalGastosMes DECIMAL(18,2) = ISNULL((
        SELECT SUM(t.Monto)
        FROM Transacciones t
        INNER JOIN Cuentas c ON t.CuentaId = c.Id
        WHERE c.UsuarioId = @UsuarioId 
          AND t.TipoTransaccion = 'Gasto'
          AND MONTH(t.Fecha) = @MesActual 
          AND YEAR(t.Fecha) = @AnioActual
    ), 0.00);
    -- 4. Total Dinero Ahorrado en Metas de Ahorro
    DECLARE @TotalAhorrado DECIMAL(18,2) = ISNULL((
        SELECT SUM(MontoActual)
        FROM MetasAhorro
        WHERE UsuarioId = @UsuarioId AND Estado IN ('Activa', 'Completada')
    ), 0.00);
    SELECT 
        @TotalPatrimonio AS TotalPatrimonio,
        @TotalIngresosMes AS TotalIngresosMes,
        @TotalGastosMes AS TotalGastosMes,
        @TotalAhorrado AS TotalAhorrado;
END
GO
-- ============================================================
-- 2. GASTOS POR CATEGORÍA (PARA LA GRÁFICA DE DONA / PASTEL)
-- ============================================================
CREATE OR ALTER PROCEDURE sp_Dashboard_GastosPorCategoria
    @UsuarioId INT,
    @Mes INT = NULL,
    @Anio INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    IF @Mes IS NULL SET @Mes = MONTH(GETDATE());
    IF @Anio IS NULL SET @Anio = YEAR(GETDATE());
    -- Total general de gastos del mes para calcular porcentajes
    DECLARE @TotalMes DECIMAL(18,2) = ISNULL((
        SELECT SUM(t.Monto)
        FROM Transacciones t
        INNER JOIN Cuentas cu ON t.CuentaId = cu.Id
        WHERE cu.UsuarioId = @UsuarioId 
          AND t.TipoTransaccion = 'Gasto'
          AND MONTH(t.Fecha) = @Mes 
          AND YEAR(t.Fecha) = @Anio
    ), 0.00);
    SELECT 
        c.Nombre AS Categoria,
        ISNULL(c.ColorHex, '#808080') AS ColorHex,
        SUM(t.Monto) AS TotalGasto,
        CASE 
            WHEN @TotalMes > 0 THEN ROUND((SUM(t.Monto) / @TotalMes) * 100, 1)
            ELSE 0 
        END AS Porcentaje
    FROM Transacciones t
    INNER JOIN Cuentas cu ON t.CuentaId = cu.Id
    INNER JOIN Categorias c ON t.CategoriaId = c.Id
    WHERE cu.UsuarioId = @UsuarioId 
      AND t.TipoTransaccion = 'Gasto'
      AND MONTH(t.Fecha) = @Mes 
      AND YEAR(t.Fecha) = @Anio
    GROUP BY c.Nombre, c.ColorHex
    ORDER BY TotalGasto DESC;
END
GO
-- ============================================================
-- 3. COMPARATIVA INGRESOS VS GASTOS (ÚLTIMOS 6 MESES)
-- ============================================================
CREATE OR ALTER PROCEDURE sp_Dashboard_IngresosVsGastos6Meses
    @UsuarioId INT
AS
BEGIN
    SET NOCOUNT ON;
    -- Tabla temporal para almacenar los últimos 6 meses
    DECLARE @Meses TABLE (
        Orden INT IDENTITY(1,1),
        Anio INT,
        Mes INT,
        NombreMes VARCHAR(10)
    );
    -- Generar los últimos 6 meses desde el más antiguo al actual
    DECLARE @i INT = 5;
    WHILE @i >= 0
    BEGIN
        DECLARE @FechaIterada DATE = DATEADD(MONTH, -@i, GETDATE());
        DECLARE @NumMes INT = MONTH(@FechaIterada);
        DECLARE @NomMes VARCHAR(10) = CASE @NumMes
            WHEN 1 THEN 'Ene' WHEN 2 THEN 'Feb' WHEN 3 THEN 'Mar'
            WHEN 4 THEN 'Abr' WHEN 5 THEN 'May' WHEN 6 THEN 'Jun'
            WHEN 7 THEN 'Jul' WHEN 8 THEN 'Ago' WHEN 9 THEN 'Sep'
            WHEN 10 THEN 'Oct' WHEN 11 THEN 'Nov' WHEN 12 THEN 'Dic'
        END;
        INSERT INTO @Meses (Anio, Mes, NombreMes)
        VALUES (YEAR(@FechaIterada), @NumMes, @NomMes);
        SET @i = @i - 1;
    END
    -- Consultar y totalizar ingresos y gastos por cada uno de los 6 meses
    SELECT 
        m.NombreMes,
        m.Mes,
        m.Anio,
        ISNULL((
            SELECT SUM(t.Monto)
            FROM Transacciones t
            INNER JOIN Cuentas c ON t.CuentaId = c.Id
            WHERE c.UsuarioId = @UsuarioId 
              AND t.TipoTransaccion = 'Ingreso'
              AND MONTH(t.Fecha) = m.Mes 
              AND YEAR(t.Fecha) = m.Anio
        ), 0.00) AS TotalIngresos,
        ISNULL((
            SELECT SUM(t.Monto)
            FROM Transacciones t
            INNER JOIN Cuentas c ON t.CuentaId = c.Id
            WHERE c.UsuarioId = @UsuarioId 
              AND t.TipoTransaccion = 'Gasto'
              AND MONTH(t.Fecha) = m.Mes 
              AND YEAR(t.Fecha) = m.Anio
        ), 0.00) AS TotalGastos
    FROM @Meses m
    ORDER BY m.Orden ASC;
END
GO
-- ============================================================
-- 4. ÚLTIMAS TRANSFERENCIAS ENTRE CUENTAS
-- ============================================================
CREATE OR ALTER PROCEDURE sp_Dashboard_UltimasTransferencias
    @UsuarioId INT,
    @Top INT = 5
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP (@Top)
        tSalida.Id,
        cOrigen.Nombre AS CuentaOrigen,
        ISNULL(cDestino.Nombre, '—') AS CuentaDestino,
        tSalida.Monto,
        tSalida.Fecha
    FROM Transacciones tSalida
    INNER JOIN Cuentas cOrigen ON tSalida.CuentaId = cOrigen.Id
    LEFT JOIN Transacciones tEntrada 
        ON tSalida.TransferenciaRefId = tEntrada.TransferenciaRefId 
        AND tEntrada.TipoTransaccion = 'Transferencia Entrada'
    LEFT JOIN Cuentas cDestino ON tEntrada.CuentaId = cDestino.Id
    WHERE cOrigen.UsuarioId = @UsuarioId 
      AND tSalida.TipoTransaccion = 'Transferencia Salida'
    ORDER BY tSalida.Fecha DESC, tSalida.Id DESC;
END
GO