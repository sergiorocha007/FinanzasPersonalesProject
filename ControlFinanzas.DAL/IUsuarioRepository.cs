using ControlFinanzas.Entity.Entidades;
namespace ControlFinanzas.DAL
{
    public interface IUsuarioRepository
    {
            bool Insertar(UsuarioEntity usuario);

            UsuarioEntity ObtenerPorEmail(string email);     
    }
}
