namespace ControlFinanzas.Entity.Entidades
{
    public class TransaccionesEntity
    {
        #region Propiedades
        public int IdTransacciones { get; private set; }

        public int CuentaId { get; private set; }

        public int? CategoriaId { get; private set; }

        public string TipoTransaccion { get; private set; } = string.Empty;

        public decimal Monto { get; private set; }

        public DateTime Fecha { get; private set; }

        public string Descripcion { get; private set; } = string.Empty;

        public Guid? TransferenciaRefId { get; private set; }

        #endregion


        #region Constructores

        public TransaccionesEntity() { }

        public TransaccionesEntity(int cuentaId, int? categoriaId, string tipoTransaccion,
            decimal monto, DateTime fecha, string descripcion, Guid? transferenciaRefId = null)
        {

            AsignarCuentaId(cuentaId);
            AsignarCategoriaId(categoriaId);
            CambiarTipoTransaccion(tipoTransaccion);
            AsignarMonto(monto);
            AsignarFecha(fecha);
            CambiarDescripcion(descripcion);
            AsignarTransferenciaRefId(transferenciaRefId);

        }

        #endregion


        #region Metodos

        public void AsignarId(int id)
        {
            if (id <= 0)
                throw new Exception("El Id de la transacción debe ser mayor a cero.");
            IdTransacciones = id;
        }

        public void AsignarCuentaId(int cuentaId)
        {
            if (cuentaId <= 0)
                throw new Exception("El Id de la transacción debe ser mayor a cero.");
            CuentaId = cuentaId;
        }

        public void AsignarCategoriaId(int? categoriaId)
        {
            if (categoriaId.HasValue && categoriaId.Value <= 0)
                throw new ArgumentException("El Id de la categoría debe ser mayor a cero.");

            CategoriaId = categoriaId;
        }

        public void CambiarTipoTransaccion(string tipo)
        {
            if (string.IsNullOrWhiteSpace(tipo))
                throw new Exception("Debe especificar el tipo de transacción.");

            if (tipo != "Ingreso" && tipo != "Gasto" && tipo != "Transferencia Salida" && tipo != "Transferencia Entrada")
                throw new ArgumentException("El tipo de transacción no es válido.");

            TipoTransaccion = tipo;
        }

        public void AsignarMonto(decimal monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto de la transacción debe ser mayor a cero.");

            Monto = monto;
        }

        public void AsignarFecha(DateTime fecha)
        {
            if (fecha == DateTime.MinValue)
                throw new ArgumentException("Debe ingresar una fecha válida.");

            Fecha = fecha;
        }

        public void CambiarDescripcion(string descripcion)
        {
            if (!string.IsNullOrWhiteSpace(descripcion) && descripcion.Length > 200)
                throw new ArgumentException("La descripción no puede exceder los 200 caracteres.");

            Descripcion = descripcion?.Trim() ?? string.Empty;
        }

        public void AsignarTransferenciaRefId(Guid? refId)
        {
            TransferenciaRefId = refId;
        }

        #endregion

    }
}
