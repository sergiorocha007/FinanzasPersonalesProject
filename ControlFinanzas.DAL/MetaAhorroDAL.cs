using ControlFinanzas.DAL.Common;
using ControlFinanzas.Entity.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace ControlFinanzas.DAL
{
    public class MetaAhorroDAL
    {
        private MetaAhorroEntity MapearMeta(SqlDataReader dr)
        {
            var meta = new MetaAhorroEntity();

            meta.AsignarId(Convert.ToInt32(dr["Id"]));
            meta.AsignarUsuarioId(Convert.ToInt32(dr["UsuarioId"]));
            meta.CambiarNombre(dr["Nombre"].ToString() ?? string.Empty);
            meta.AsignarMontoObjetivo(Convert.ToDecimal(dr["MontoObjetivo"]));
            meta.AsignarMontoActual(Convert.ToDecimal(dr["MontoActual"]));
            meta.CargarFechaDesdeBD(Convert.ToDateTime(dr["FechaLimite"]));
            meta.CambiarEstado(dr["Estado"].ToString() ?? "Activa");

            return meta;
        }

        public async Task<int> InsertarAsync(MetaAhorroEntity meta)
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new SqlCommand("sp_MetasAhorro_Insertar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UsuarioId", meta.UsuarioId);
                cmd.Parameters.AddWithValue("@Nombre", meta.Nombre);
                cmd.Parameters.AddWithValue("@MontoObjetivo", meta.MontoObjetivo);
                cmd.Parameters.AddWithValue("@FechaLimite", meta.FechaLimite);

                await cn.OpenAsync();
                object? result = await cmd.ExecuteScalarAsync();

                return (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<MetaAhorroEntity>> ObtenerPorUsuarioAsync(int usuarioId)
        {
            try
            {
                List<MetaAhorroEntity> lista = new List<MetaAhorroEntity>();

                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new SqlCommand("sp_MetasAhorro_ObtenerPorUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                await cn.OpenAsync();
                using SqlDataReader dr = await cmd.ExecuteReaderAsync();

                while (await dr.ReadAsync())
                {
                    lista.Add(MapearMeta(dr));
                }

                return lista;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> ActualizarAsync(MetaAhorroEntity meta)
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new SqlCommand("sp_MetasAhorro_Actualizar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", meta.Id);
                cmd.Parameters.AddWithValue("@UsuarioId", meta.UsuarioId);
                cmd.Parameters.AddWithValue("@Nombre", meta.Nombre);
                cmd.Parameters.AddWithValue("@MontoObjetivo", meta.MontoObjetivo);
                cmd.Parameters.AddWithValue("@FechaLimite", meta.FechaLimite);

                await cn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();

                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> CambiarEstadoAsync(int metaId, int usuarioId, string estado)
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new SqlCommand("sp_MetasAhorro_CambiarEstado", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", metaId);
                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                cmd.Parameters.AddWithValue("@Estado", estado);

                await cn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();

                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> EliminarAsync(int metaId, int usuarioId)
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new SqlCommand("sp_MetasAhorro_Eliminar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", metaId);
                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                await cn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();

                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> AbonarAsync(int usuarioId, int metaId, int cuentaId, decimal monto)
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new SqlCommand("sp_MetasAhorro_Abonar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                cmd.Parameters.AddWithValue("@MetaId", metaId);
                cmd.Parameters.AddWithValue("@CuentaId", cuentaId);
                cmd.Parameters.AddWithValue("@Monto", monto);

                await cn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();

                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> CancelarYDevolverAsync(int usuarioId, int metaId, int cuentaDestinoId)
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new SqlCommand("sp_MetasAhorro_CancelarYDevolver", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                cmd.Parameters.AddWithValue("@MetaId", metaId);
                cmd.Parameters.AddWithValue("@CuentaDestinoId", cuentaDestinoId);

                await cn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();

                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
