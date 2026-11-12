using ControlFinanzas.Entity.Entidades;

namespace ControlFinanzas.Entity.Sesion
{
    /// <summary>
    /// Gestiona el contexto de la sesión activa del usuario autenticado.
    /// Patrón Singleton controlado: un único punto de acceso, sin estado global residual.
    /// </summary>
    public static class SesionUsuario
    {
        // El único objeto de usuario en memoria durante la sesión activa.
        private static UsuarioEntity? _usuarioActivo = null;

        /// <summary>
        /// Indica si existe una sesión activa.
        /// </summary>
        public static bool HaySesionActiva => _usuarioActivo != null;

        /// <summary>
        /// Id del usuario autenticado. Lanza excepción si no hay sesión activa.
        /// </summary>
        public static int UsuarioId
        {
            get
            {
                ValidarSesionActiva();
                return _usuarioActivo.Id;
            }
        }

        /// <summary>
        /// Nombre del usuario autenticado. Lanza excepción si no hay sesión activa.
        /// </summary>
        public static string Nombre
        {
            get
            {
                ValidarSesionActiva();
                return _usuarioActivo.Nombre;
            }
        }

        /// <summary>
        /// Email del usuario autenticado. Lanza excepción si no hay sesión activa.
        /// </summary>
        public static string Email
        {
            get
            {
                ValidarSesionActiva();
                return _usuarioActivo.Email;
            }
        }

        /// <summary>
        /// Inicia la sesión con el usuario autenticado.
        /// Debe llamarse inmediatamente después de una autenticación exitosa.
        /// </summary>
        /// <param name="usuario">Objeto UsuarioEntity obtenido de la BLL tras autenticación.</param>
        /// <exception cref="ArgumentNullException">Si el usuario es null.</exception>
        public static void IniciarSesion(UsuarioEntity usuario)
        {
            if (usuario == null)
                throw new ArgumentNullException(nameof(usuario), "No se puede iniciar sesión con un usuario nulo.");

            _usuarioActivo = usuario;
        }

        /// <summary>
        /// Cierra la sesión activa y purga completamente el estado en memoria.
        /// Debe llamarse al cerrar sesión o al cerrar la aplicación.
        /// </summary>
        public static void CerrarSesion()
        {
            _usuarioActivo = null;
        }

        /// <summary>
        /// Valida que haya una sesión activa antes de acceder a datos sensibles.
        /// </summary>
        private static void ValidarSesionActiva()
        {
            if (_usuarioActivo == null)
                throw new InvalidOperationException("No hay una sesión de usuario activa. Por favor, inicie sesión.");
        }
    }
}
