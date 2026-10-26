using ControlFinanzas.DAL;
using System;
using System.Collections.Generic;
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

        // Método para el Login
        public bool Autenticar(string email, string contrasenaPlana)
        {
            UsuarioEntity usuario = _usuarioRepository.ObtenerPorEmail(email);

            if (usuario == null) return false;

            string hashIngresado = EncriptarSHA256(contrasenaPlana);
            return usuario.PasswordHash == hashIngresado;
        }

        // Método para el Registro
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
