namespace ControlFinanzas.Entity.Entidades
{
    public class TarjetaCredito : Cuenta
    {
        public decimal LimiteCredito { get; set; }
        public decimal DeudaActual { get; set; }
        public int DiaCorte { get; set; }
        public int DiaPago { get; set; }

        public override decimal ObtenerSaldoMostrar()
        {
            return DeudaActual;
        }
    }
}
