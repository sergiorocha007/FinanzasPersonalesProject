namespace ControlFinanzas.Entity.Entidades
{
    public class UsuarioEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public DateTime FechaRegistro { get; set; }
        public bool Estado { get; set; }
    }
}
