using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ControlFinanzas.DAL;
using ControlFinanzas.Entity.Entidades;
using ControlFinanzas.Entity.Sesion; // Suponiendo que mantienes tu clase estática de sesión

namespace ControlFinanzas.BLL
{
    public class CategoriaBLL
    {
        private readonly CategoriaDAL _categoriaDAL;

        public CategoriaBLL()
        {
            _categoriaDAL = new CategoriaDAL();
        }

        // ──────────────────────────────────────────────────────────────
        //  MÉTODOS PÚBLICOS ASÍNCRONOS
        // ──────────────────────────────────────────────────────────────

        public async Task<List<CategoriaEntity>> ObtenerConFiltroAsync(int usuarioId, string? buscar, string filtroTipo)
        {
            return await _categoriaDAL.ObtenerConFiltroAsync(usuarioId, buscar, filtroTipo);
        }

        public async Task<CategoriaKPI> ObtenerKPIsAsync(int usuarioId)
        {
            return await _categoriaDAL.ObtenerKPIsAsync(usuarioId);
        }

        public async Task<int> GuardarAsync(CategoriaEntity cat)
        {
            // Asignar el ID de usuario desde la sesión actual
            cat.AsignarUsuarioId(SesionUsuario.UsuarioId);

            // Validar la entidad antes de interactuar con la BD[cite: 3]
            ValidarCategoria(cat);

            if (cat.Id == 0)
            {
                int nuevoId = await Task.Run(() => _categoriaDAL.Insertar(cat));
                if (nuevoId <= 0)
                    throw new ApplicationException("No se pudo registrar la categoría en la base de datos.");

                cat.AsignarId(nuevoId);
                return nuevoId;
            }
            else
            {
                bool exito = await Task.Run(() => _categoriaDAL.Actualizar(cat));
                if (!exito)
                    throw new ApplicationException("No se pudo actualizar la categoría. Verifique que aún exista.");

                return cat.Id;
            }
        }

        public async Task CambiarEstadoAsync(int id, bool nuevoEstado)
        {
            if (id <= 0)
                throw new ApplicationException("Debe seleccionar una categoría válida para cambiar su estado.");

            int usuarioId = SesionUsuario.UsuarioId;
            bool exito = await Task.Run(() => _categoriaDAL.CambiarEstado(id, usuarioId, nuevoEstado));

            if (!exito)
                throw new ApplicationException("No se pudo cambiar el estado de la categoría.");
        }

        // ──────────────────────────────────────────────────────────────
        //  MÉTODOS PRIVADOS (Reglas de Negocio)
        // ──────────────────────────────────────────────────────────────

        private void ValidarCategoria(CategoriaEntity cat)
        {
            // Las validaciones principales (Nombre, Tipo, Color) ya se ejecutan en 
            // los métodos mutadores de CategoriaEntity (CambiarNombre, CambiarTipo, etc.),
            // por lo que aquí solo validamos reglas a nivel de negocio/contexto[cite: 3].

            if (cat.UsuarioId <= 0)
                throw new ApplicationException("El identificador de usuario no es válido. Inicie sesión nuevamente.");

            // Si necesitas forzar una doble validación de RegEx a nivel de BLL, puedes dejar esto:
            Regex regexHex = new Regex(@"^#[0-9A-Fa-f]{6}$");
            if (!regexHex.IsMatch(cat.ColorHex))
                throw new ApplicationException($"El color '{cat.ColorHex}' no tiene un formato hexadecimal válido. Ejemplo correcto: #FF5733");
        }
    }
}
