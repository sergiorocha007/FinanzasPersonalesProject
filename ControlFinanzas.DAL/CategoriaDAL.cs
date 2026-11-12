using ControlFinanzas.DAL.Common;
using ControlFinanzas.Entity.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControlFinanzas.DAL
{
    public class CategoriaDAL
    {
        // ──────────────────────────────────────────────────────────────
        //  INSERT
        // ──────────────────────────────────────────────────────────────

        /// <param name="cat">Entidad a insertar.</param>
        /// <returns>El ID generado por la BD para la nueva categoría; -1 si falló.</returns>
        public int Insertar(CategoriaEntity cat)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_Categorias_Insert", con))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Parámetros de entrada al SP
                cmd.Parameters.AddWithValue("@UsuarioId", cat.UsuarioId);
                cmd.Parameters.AddWithValue("@Nombre", cat.Nombre);
                cmd.Parameters.AddWithValue("@Tipo", cat.Tipo);
                cmd.Parameters.AddWithValue("@ColorHex", cat.ColorHex);
                cmd.Parameters.AddWithValue("@Estado", cat.Estado);

                con.Open();

                // El SP devuelve el ID generado en la primera columna del primer row
                object resultado = cmd.ExecuteScalar();
                return resultado != null && resultado != DBNull.Value
                    ? Convert.ToInt32(resultado)
                    : -1;
            }
        }

        // ──────────────────────────────────────────────────────────────
        //  UPDATE
        // ──────────────────────────────────────────────────────────────

        /// <summary>
        /// Actualiza los datos de una categoría existente.
        /// </summary>
        /// <param name="cat">Entidad con los datos actualizados (debe tener Id > 0).</param>
        /// <returns>true si se afectó al menos una fila; false en caso contrario.</returns>
        public bool Actualizar(CategoriaEntity cat)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_Categorias_Update", con))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", cat.Id);
                cmd.Parameters.AddWithValue("@UsuarioId", cat.UsuarioId);
                cmd.Parameters.AddWithValue("@Nombre", cat.Nombre);
                cmd.Parameters.AddWithValue("@Tipo", cat.Tipo);
                cmd.Parameters.AddWithValue("@ColorHex", cat.ColorHex);
                cmd.Parameters.AddWithValue("@Estado", cat.Estado);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        /// <param name="id">ID de la categoría a modificar.</param>
        /// <param name="usuarioId">ID del usuario dueño (para seguridad multitenant).</param>
        /// <param name="nuevoEstado">true = activar, false = desactivar.</param>
        /// <returns>true si se afectó al menos una fila.</returns>
        public bool CambiarEstado(int id, int usuarioId, bool nuevoEstado)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_Categorias_CambiarEstado", con))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                cmd.Parameters.AddWithValue("@NuevoEstado", nuevoEstado);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ──────────────────────────────────────────────────────────────
        //  SELECT CON FILTROS
        // ──────────────────────────────────────────────────────────────

        /// <summary>
        /// Obtiene la lista de categorías del usuario aplicando filtros de búsqueda.
        /// </summary>
        public List<CategoriaEntity> ObtenerPorFiltro(int usuarioId, string buscar, string filtroTipo)
        {
            var lista = new List<CategoriaEntity>();

            using (SqlConnection con = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_Categorias_GetByUsuarioFiltro", con))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                cmd.Parameters.AddWithValue("@Buscar", buscar ?? string.Empty);
                cmd.Parameters.AddWithValue("@FiltroTipo", filtroTipo ?? "Todas");

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(MapearCategoriaDesdeReader(reader));
                    }
                }
            }

            return lista;
        }

        // ──────────────────────────────────────────────────────────────
        //  KPIs
        // ──────────────────────────────────────────────────────────────

        /// <summary>
        /// Obtiene el resumen KPI de categorías para el usuario.
        /// </summary>
        public CategoriaKPI ObtenerKPIs(int usuarioId)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_Categorias_ObtenerKPIs", con))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new CategoriaKPI
                        {
                            TotalCategorias = Convert.ToInt32(reader["TotalCategorias"]),
                            TotalIngresos = Convert.ToInt32(reader["TotalIngresos"]),
                            TotalGastos = Convert.ToInt32(reader["TotalGastos"])
                        };
                    }
                }
            }

            return new CategoriaKPI();
        }

        // ──────────────────────────────────────────────────────────────
        //  MÉTODOS PRIVADOS (Mapeo)
        // ──────────────────────────────────────────────────────────────

        /// <summary>
        /// Mapea una fila del SqlDataReader instanciando CategoriaEntity 
        /// y usando sus métodos mutadores para evitar errores de solo lectura[cite: 2].
        /// </summary>
        private CategoriaEntity MapearCategoriaDesdeReader(SqlDataReader reader)
        {
            CategoriaEntity cat = new CategoriaEntity();

            cat.AsignarId(Convert.ToInt32(reader["Id"]));
            cat.AsignarUsuarioId(Convert.ToInt32(reader["UsuarioId"]));
            cat.CambiarNombre(reader["Nombre"].ToString()!);
            cat.CambiarTipo(reader["Tipo"].ToString()!.Trim());
            cat.CambiarColorHex(reader["ColorHex"].ToString()!);
            cat.CambiarEstado(Convert.ToBoolean(reader["Estado"]));

            return cat;
        }

        // ──────────────────────────────────────────────────────────────
        //  MÉTODOS ASÍNCRONOS WRAPPERS
        // ──────────────────────────────────────────────────────────────

        public Task<List<CategoriaEntity>> ObtenerConFiltroAsync(int usuarioId, string? buscar, string filtroTipo)
        {
            return Task.Run(() => ObtenerPorFiltro(usuarioId, buscar ?? string.Empty, filtroTipo ?? "Todas"));
        }

        public Task<CategoriaKPI> ObtenerKPIsAsync(int usuarioId)
        {
            return Task.Run(() => ObtenerKPIs(usuarioId));
        }
    }
}
