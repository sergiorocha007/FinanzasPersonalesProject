namespace ControlFinanzas.Entity
{
    public class ResumenCuentasDTO
    {
        public decimal TotalLiquidez { get; set; }
        public decimal TotalDeudaCredito { get; set; }
        public decimal TotalCreditoDisponible { get; set; }
        public decimal TotalLimiteCredito { get; set; }

        public decimal PorcentajeCreditoDisponible => TotalLimiteCredito > 0
            ? System.Math.Round((TotalCreditoDisponible / TotalLimiteCredito) * 100, 2)
            : 0;
    }
}
