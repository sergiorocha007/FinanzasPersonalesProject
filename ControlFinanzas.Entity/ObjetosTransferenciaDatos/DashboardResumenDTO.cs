namespace ControlFinanzas.Entity.ObjetosTransferenciaDatos
{
    // DTO para transportar los valores consolidados de las 4 tarjetas de resumen del Dashboard
    public class DashboardResumenDTO
    {
        
        public decimal TotalPatrimonio { get; set; }

       
        public decimal TotalIngresosMes { get; set; }

       
        public decimal TotalGastosMes { get; set; }

        
        public decimal TotalAhorrado { get; set; }
    }
}
