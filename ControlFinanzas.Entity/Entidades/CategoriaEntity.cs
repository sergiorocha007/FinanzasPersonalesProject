using System;
using System.Text.RegularExpressions;

namespace ControlFinanzas.Entity.Entidades
{
    public class CategoriaEntity
    {
        #region Propiedades

        public int Id { get; private set; }

        public int UsuarioId { get; private set; }

        public string Nombre { get; private set; } = string.Empty;

        public string Tipo { get; private set; } = string.Empty;

        public string ColorHex { get; private set; } = "#808080";

        public bool Estado { get; private set; }

        #endregion

        #region Constructores

        public CategoriaEntity() { }

        public CategoriaEntity(int usuarioId, string nombre, string tipo, string colorHex)
        {
            AsignarUsuarioId(usuarioId);
            CambiarNombre(nombre);
            CambiarTipo(tipo);
            CambiarColorHex(colorHex);

            Estado = true; // Por defecto activo al crear un nuevo registro
        }

        #endregion

        #region Metodos

        public void AsignarId(int id)
        {
            if (id <= 0)
                throw new Exception("El Id de la categoría debe ser mayor a cero.");

            Id = id;
        }

        public void AsignarUsuarioId(int usuarioId)
        {
            if (usuarioId <= 0)
                throw new Exception("El Id del Usuario debe ser mayor a cero.");

            UsuarioId = usuarioId;
        }

        public void CambiarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("El campo 'Nombre' es obligatorio.");

            if (nombre.Trim().Length > 50)
                throw new Exception("El 'Nombre' no puede superar los 50 caracteres.");

            Regex regexNombre = new Regex(@"[^a-zA-ZáéíóúÁÉÍÓÚñÑüÜ0-9 \-_]");
            if (regexNombre.IsMatch(nombre))
                throw new Exception("El 'Nombre' contiene caracteres no permitidos. Use solo letras, números, espacios, guión (-) y guión bajo (_).");

            Nombre = nombre.Trim();
        }

        public void CambiarTipo(string tipo)
        {
            if (string.IsNullOrWhiteSpace(tipo))
                throw new Exception("Debe seleccionar el tipo de Categoría.");

            if (tipo != "Ingreso" && tipo != "Gasto")
                throw new Exception("El 'Tipo' de categoría debe ser estrictamente 'Ingreso' o 'Gasto'.");

            Tipo = tipo;
        }

        public void CambiarColorHex(string colorHex)
        {
            if (string.IsNullOrWhiteSpace(colorHex))
            {
                ColorHex = "#808080";
                return;
            }

            string normalizado = colorHex.Trim().ToUpper();
            normalizado = normalizado.StartsWith("#") ? normalizado : "#" + normalizado;

            Regex regexHex = new Regex(@"^#[0-9A-Fa-f]{6}$");
            if (!regexHex.IsMatch(normalizado))
                throw new Exception($"El color '{normalizado}' no tiene un formato hexadecimal válido. Ejemplo correcto: #FF5733");

            ColorHex = normalizado;
        }

        public void CambiarEstado(bool nuevoEstado)
        {
            Estado = nuevoEstado;
        }

        #endregion
    }
}