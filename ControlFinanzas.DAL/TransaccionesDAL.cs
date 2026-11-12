using ControlFinanzas.DAL.Common;
using ControlFinanzas.Entity.Entidades;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ControlFinanzas.DAL
{
    public class TransaccionesDAL
    {

        #region Metodos Privados
        private HistorialTransaccionesDTO CrearHistorialTransaccion(SqlDataReader dr)
        {
            HistorialTransaccionesDTO historial = new HistorialTransaccionesDTO();

            historial.Id = Convert.ToInt32(dr["Id"]);

            if (ColumnExists(dr, "CuentaId") && dr["CuentaId"] != DBNull.Value)
                historial.CuentaId = Convert.ToInt32(dr["CuentaId"]);

            if (ColumnExists(dr, "Cuenta") && dr["Cuenta"] != DBNull.Value)
                historial.Cuenta = dr["Cuenta"].ToString()!;

            if (ColumnExists(dr, "CategoriaId") && dr["CategoriaId"] != DBNull.Value)
                historial.CategoriaId = Convert.ToInt32(dr["CategoriaId"]);

            if (ColumnExists(dr, "Categoria") && dr["Categoria"] != DBNull.Value)
                historial.Categoria = dr["Categoria"].ToString()!;

            historial.TipoTransaccion = dr["TipoTransaccion"].ToString()!;
            historial.Monto = Convert.ToDecimal(dr["Monto"]);
            historial.Fecha = Convert.ToDateTime(dr["Fecha"]);

            if (ColumnExists(dr, "Descripcion") && dr["Descripcion"] != DBNull.Value)
                historial.Descripcion = dr["Descripcion"].ToString()!;

            if (ColumnExists(dr, "TransferenciaRefId") && dr["TransferenciaRefId"] != DBNull.Value)
                historial.TransferenciaRefId = (Guid)dr["TransferenciaRefId"];

            return historial;
        }


        // Método auxiliar para verificar si una columna existe en el DataReader (útil porque GetByCuenta y GetByUsuario devuelven columnas ligeramente distintas)
        private bool ColumnExists(IDataRecord dr, string columnName)
        {
            for (int i = 0; i < dr.FieldCount; i++)
            {
                if (dr.GetName(i).Equals(columnName, StringComparison.InvariantCultureIgnoreCase))
                    return true;
            }
            return false;
        }
        #endregion

        #region Metodos Publicos

        public async Task<int> AgregarAsync(int usuarioId, TransaccionesEntity transaccion)
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new SqlCommand("sp_Transacciones_Insert", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                cmd.Parameters.AddWithValue("@CuentaId", transaccion.CuentaId);
                cmd.Parameters.AddWithValue("@CategoriaId", transaccion.CategoriaId.HasValue ? (object)transaccion.CategoriaId.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@TipoTransaccion", transaccion.TipoTransaccion);
                cmd.Parameters.AddWithValue("@Monto", transaccion.Monto);
                cmd.Parameters.AddWithValue("@Fecha", transaccion.Fecha);
                cmd.Parameters.AddWithValue("@Descripcion", string.IsNullOrWhiteSpace(transaccion.Descripcion) ? DBNull.Value : (object)transaccion.Descripcion);
                cmd.Parameters.AddWithValue("@TransferenciaRefId", transaccion.TransferenciaRefId.HasValue ? (object)transaccion.TransferenciaRefId.Value : DBNull.Value);

                await cn.OpenAsync();

                object? result = await cmd.ExecuteScalarAsync();
                if (result == null || result == DBNull.Value)
                    throw new Exception("No se pudo obtener el ID de la transacción insertada.");
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar la transacción: " + ex.Message);
            }
        }

        public async Task<List<HistorialTransaccionesDTO>> ObtenerPorCuentaAsync(int cuentaId, int usuarioId)
        {
            try
            {
                List<HistorialTransaccionesDTO> lista = new List<HistorialTransaccionesDTO>();

                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new SqlCommand("sp_Transacciones_GetByCuenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CuentaId", cuentaId);
                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                await cn.OpenAsync();

                using SqlDataReader dr = await cmd.ExecuteReaderAsync();

                while (await dr.ReadAsync())
                {
                    lista.Add(CrearHistorialTransaccion(dr));
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar el historial de la cuenta: " + ex.Message);
            }
        }

        public async Task<List<HistorialTransaccionesDTO>> ObtenerPorUsuarioAsync(int usuarioId)
        {
            try
            {
                List<HistorialTransaccionesDTO> lista = new List<HistorialTransaccionesDTO>();

                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new SqlCommand("sp_Transacciones_GetByUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                await cn.OpenAsync();

                using SqlDataReader dr = await cmd.ExecuteReaderAsync();

                while (await dr.ReadAsync())
                {
                    lista.Add(CrearHistorialTransaccion(dr));
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar el historial del usuario: " + ex.Message);
            }
        }

        // 4. DELETE — borrado de transferencia completa
        public async Task EliminarTransferenciaAsync(int idTransaccion, int usuarioId)
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new SqlCommand("sp_Transacciones_Delete", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", idTransaccion);
                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                await cn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message); 
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la transacción: " + ex.Message);
            }
        }

        public async Task<Guid> EjecutarTransferenciaAsync(int usuarioId, int cuentaOrigenId, int cuentaDestinoId, decimal monto, string descripcion)
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new SqlCommand("sp_Transacciones_EjecutarTransferencia", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                cmd.Parameters.AddWithValue("@CuentaOrigenId", cuentaOrigenId);
                cmd.Parameters.AddWithValue("@CuentaDestinoId", cuentaDestinoId);
                cmd.Parameters.AddWithValue("@Monto", monto);
                cmd.Parameters.AddWithValue("@Descripcion", string.IsNullOrWhiteSpace(descripcion) ? DBNull.Value : (object)descripcion);

                await cn.OpenAsync();
                object result = await cmd.ExecuteScalarAsync();
                return (Guid)result;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error interno al ejecutar la transferencia: " + ex.Message);
            }
        }

        #endregion

    }
}
