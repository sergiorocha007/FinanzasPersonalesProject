using ControlFinanzas.DAL.Common;
using ControlFinanzas.Entity.Entidades;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ControlFinanzas.DAL
{
    public class PresupuestoDAL
    {
        private PresupuestoDTO CrearPresupuestoDTO(SqlDataReader dr)
        {
            return new PresupuestoDTO
            {
                IdPresupuesto = Convert.ToInt32(dr["IdPresupuesto"]),
                CategoriaId = Convert.ToInt32(dr["CategoriaId"]),
                CategoriaNombre = dr["CategoriaNombre"].ToString()!,
                ColorHex = dr["ColorHex"] != DBNull.Value ? dr["ColorHex"].ToString()! : "#808080",
                Mes = Convert.ToByte(dr["Mes"]),
                Anio = Convert.ToInt16(dr["Anio"]),
                LimiteMensual = Convert.ToDecimal(dr["LimiteMensual"]),
                GastoActual = Convert.ToDecimal(dr["GastoActual"]),
                Restante = Convert.ToDecimal(dr["Restante"]),
                PorcentajeConsumido = Convert.ToDecimal(dr["PorcentajeConsumido"])
            };
        }

        public async Task<int> GuardarAsync(PresupuestoEntity presupuesto)
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new SqlCommand("sp_Presupuestos_Guardar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UsuarioId", presupuesto.UsuarioId);
                cmd.Parameters.AddWithValue("@CategoriaId", presupuesto.CategoriaId);
                cmd.Parameters.AddWithValue("@Mes", presupuesto.Mes);
                cmd.Parameters.AddWithValue("@Anio", presupuesto.Anio);
                cmd.Parameters.AddWithValue("@LimiteMensual", presupuesto.LimiteMensual);

                await cn.OpenAsync();
                object? result = await cmd.ExecuteScalarAsync();
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el presupuesto: " + ex.Message);
            }
        }

        public async Task<List<PresupuestoDTO>> ObtenerPorPeriodoAsync(int usuarioId, byte mes, short anio)
        {
            try
            {
                List<PresupuestoDTO> lista = new List<PresupuestoDTO>();

                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new SqlCommand("sp_Presupuestos_GetByPeriodo", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                cmd.Parameters.AddWithValue("@Mes", mes);
                cmd.Parameters.AddWithValue("@Anio", anio);

                await cn.OpenAsync();
                using SqlDataReader dr = await cmd.ExecuteReaderAsync();

                while (await dr.ReadAsync())
                {
                    lista.Add(CrearPresupuestoDTO(dr));
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los presupuestos: " + ex.Message);
            }
        }

        public async Task EliminarAsync(int idPresupuesto, int usuarioId)
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new SqlCommand("sp_Presupuestos_Eliminar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", idPresupuesto);
                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                await cn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el presupuesto: " + ex.Message);
            }
        }
    }
}
