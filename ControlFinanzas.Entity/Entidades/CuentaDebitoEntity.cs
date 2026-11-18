namespace ControlFinanzas.Entity.Entidades
{
    public class CuentaDebitoEntity : CuentaEntity
    {
        
        public decimal SaldoActual { get; set; }
        public override decimal ObtenerSaldoMostrar()
        {
            return SaldoActual;
        }
    }
}
