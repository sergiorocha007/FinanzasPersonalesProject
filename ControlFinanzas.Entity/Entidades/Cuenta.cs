namespace ControlFinanzas.Entity.Entidades
{
    public abstract class Cuenta
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string TipoCuenta { get; set; } = string.Empty; 
        public string Moneda { get; set; } = string.Empty;    
        public bool Estado { get; set; }
        public abstract decimal ObtenerSaldoMostrar();
    }
}
