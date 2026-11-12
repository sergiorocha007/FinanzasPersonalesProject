namespace ControlFinanzas.Entity.Entidades
{
    public class PresupuestoEntity
    {

        public int IdPresupuesto {  get; private set; }

        public int UsuarioId {  get; private set; }

        public int CategoriaId {  get; private set; }

        public byte Mes { get; private set; }

        public short Anio { get; private set; }

        public decimal LimiteMensual { get; private set; }

        public bool Estado { get; private set; }

        public DateTime FechaCreacion { get; private set; }

        public DateTime? FechaModificacion { get; private set; }

        public PresupuestoEntity() { }

        public PresupuestoEntity(int usuarioId, int categoriaId, byte mes, short anio,
            decimal limiteMensual)
        {
            AsignarUsuarioId(usuarioId);
            AsignarCategoriaId(categoriaId);
            AsignarPeriodo(mes, anio);
            AsignarLimiteMensual(limiteMensual);

            Estado = true;
            FechaCreacion = DateTime.Now;
        }

        #region Metodos

        public void AsignarId(int id)
        {
            if (id <= 0)
                throw new Exception("El Id del presupuesto debe ser mayor a cero.");
            IdPresupuesto = id;
        }

        public void AsignarUsuarioId(int usuarioId)
        {
            if (usuarioId <= 0)
                throw new Exception("El Id del Usuario debe ser mayor a cero.");
            UsuarioId = usuarioId;
        }

        public void AsignarCategoriaId(int categoriaId)
        {
            if (categoriaId <= 0)
                throw new Exception("Debe seleccionar una categoría válida.");
            CategoriaId = categoriaId;
        }

        public void AsignarPeriodo(byte mes, short anio)
        {
            if (mes < 1 || mes > 12)
                throw new ArgumentException("El mes debe estar entre 1 y 12.");

            if (anio < 2000)
                throw new ArgumentException("El año no es válido.");

            Mes = mes;
            Anio = anio;
        }

        public void AsignarLimiteMensual(decimal limiteMensual)
        {
            if (limiteMensual < 0)
                throw new ArgumentException("El límite mensual no puede ser negativo.");

            LimiteMensual = limiteMensual;
        }

        public void CambiarEstado(bool nuevoEstado)
        {
            Estado = nuevoEstado;
        }

        public void AsignarFechaCreacion(DateTime fecha)
        {
            if (fecha == DateTime.MinValue)
                throw new ArgumentException("Debe ingresar una fecha de creación válida.");

            FechaCreacion = fecha;
        }

        public void MarcarModificado()
        {
            FechaModificacion = DateTime.Now;
        }

        #endregion
    }
}
