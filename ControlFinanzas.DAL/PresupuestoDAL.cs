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
                IdPresupuesto = dr["IdPresupuesto"] != DBNull.Value ? Convert.ToInt32(dr["IdPresupuesto"]) : 0,
                CategoriaId = dr["CategoriaId"] != DBNull.Value ? Convert.ToInt32(dr["CategoriaId"]) : 0,
                CategoriaNombre = dr["CategoriaNombre"] != DBNull.Value ? dr["CategoriaNombre"].ToString()! : string.Empty,
                ColorHex = dr["ColorHex"] != DBNull.Value ? dr["ColorHex"].ToString()! : "#808080",
                Mes = dr["Mes"] != DBNull.Value ? Convert.ToByte(dr["Mes"]) : (byte)1,
                Anio = dr["Anio"] != DBNull.Value ? Convert.ToInt16(dr["Anio"]) : (short)DateTime.Now.Year,
                LimiteMensual = dr["LimiteMensual"] != DBNull.Value ? Convert.ToDecimal(dr["LimiteMensual"]) : 0m,
                GastoActual = dr["GastoActual"] != DBNull.Value ? Convert.ToDecimal(dr["GastoActual"]) : 0m,
                Restante = dr["Restante"] != DBNull.Value ? Convert.ToDecimal(dr["Restante"]) : 0m,
                PorcentajeConsumido = dr["PorcentajeConsumido"] != DBNull.Value ? Convert.ToDecimal(dr["PorcentajeConsumido"]) : 0m
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
                return (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 0;
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
