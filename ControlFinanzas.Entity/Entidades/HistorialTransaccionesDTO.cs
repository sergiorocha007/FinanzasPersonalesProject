namespace ControlFinanzas.Entity.Entidades
{
    public class HistorialTransaccionesDTO
    {
        public int Id { get; set; }
        public int? CuentaId { get; set; }
        public string Cuenta { get; set; } = string.Empty; 
        public int? CategoriaId { get; set; }
        public string Categoria { get; set; } = string.Empty;
        public string TipoTransaccion { get; set; } = string.Empty;
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public Guid? TransferenciaRefId { get; set; }
    }
}
