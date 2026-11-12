namespace ControlFinanzas.Entity.Entidades
{
    public class PresupuestoDTO
    {
        public int IdPresupuesto { get; set; }
        public int CategoriaId { get; set; }
        public string CategoriaNombre { get; set; } = string.Empty;
        public string ColorHex { get; set; } = "#808080";
        public byte Mes { get; set; }
        public short Anio { get; set; }
        public decimal LimiteMensual { get; set; }
        public decimal GastoActual { get; set; }
        public decimal Restante { get; set; }
        public decimal PorcentajeConsumido { get; set; }
    }
}
