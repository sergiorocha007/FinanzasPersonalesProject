namespace ControlFinanzas.Entity.ObjetosTransferenciaDatos
{
    // DTO para representar los ingresos y gastos de un mes en la gráfica comparativa de barras
    public class ComparativaMesDTO
    {

        public string NombreMes { get; set; } = string.Empty;

        public int Mes { get; set; }

        public int Anio { get; set; }

        public decimal TotalIngresos { get; set; }

        public decimal TotalGastos { get; set; }
    }
}
