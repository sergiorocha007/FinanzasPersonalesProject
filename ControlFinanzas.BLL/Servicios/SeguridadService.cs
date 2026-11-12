using ControlFinanzas.DAL;
using System;
using System.Security.Cryptography;
using System.Text;
using ControlFinanzas.Entity.Entidades;

namespace ControlFinanzas.BLL.Servicios
{
    public class SeguridadService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public SeguridadService()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        /// <summary>
        /// Autentica al usuario y retorna el objeto UsuarioEntity completo si las credenciales son válidas.
        /// Retorna null si el email no existe o la contraseña no coincide.
        /// La capa UI es responsable de llamar a SesionUsuario.IniciarSesion() con el resultado.
        /// </summary>
        public UsuarioEntity Autenticar(string email, string contrasenaPlana)
        {
            UsuarioEntity usuario = _usuarioRepository.ObtenerPorEmail(email);

            if (usuario == null) return null;

            string hashIngresado = EncriptarSHA256(contrasenaPlana);

            // Si el hash no coincide, no retornar el objeto usuario
            if (usuario.PasswordHash != hashIngresado)
                return null;

            return usuario;
        }

        /// <summary>
        /// Registra un nuevo usuario. Retorna "OK" si fue exitoso, o un mensaje de error.
        /// No inicia sesión automáticamente tras el registro para evitar sesiones cruzadas.
        /// </summary>
        public string RegistrarUsuario(string nombre, string email, string contrasenaPlana)
        {
            // Regla de negocio: Verificar si el email ya existe
            if (_usuarioRepository.ObtenerPorEmail(email) != null)
            {
                return "El correo electrónico ya está registrado.";
            }

            UsuarioEntity nuevoUsuario = new UsuarioEntity
            {
                Nombre = nombre,
                Email = email,
                PasswordHash = EncriptarSHA256(contrasenaPlana)
            };

            bool exito = _usuarioRepository.Insertar(nuevoUsuario);
            return exito ? "OK" : "Error al guardar en la base de datos.";
        }

        // Método privado para encriptar la contraseña (Encapsulamiento)
        private string EncriptarSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(texto));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
