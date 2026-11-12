namespace ControlFinanzas.Entity.Entidades
{
    public class CuentaDebito : Cuenta
    {
        
        public decimal SaldoActual { get; set; }
        public override decimal ObtenerSaldoMostrar()
        {
            return SaldoActual;
        }
    }
}
