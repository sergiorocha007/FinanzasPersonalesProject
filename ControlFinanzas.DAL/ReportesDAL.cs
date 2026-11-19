using ControlFinanzas.DAL.Common;
using ControlFinanzas.Entity.ObjetosTransferenciaDatos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace ControlFinanzas.DAL
{
    // Capa de acceso a datos para los tres reportes del módulo de reportes
    public class ReportesDAL
    {
        // Llama al SP sp_Reportes_MovimientosIntegral y retorna la lista de movimientos
        // filtrada por usuario, rango de fechas, tipo de movimiento y cuenta
        public async Task<List<ReporteMovimientoDTO>> ObtenerMovimientosAsync(
            int usuarioId,
            DateTime desde,
            DateTime hasta,
            string tipoMovimiento,
            int? cuentaId)
        {
            var lista = new List<ReporteMovimientoDTO>();

            using (SqlConnection con = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_Reportes_MovimientosIntegral", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                cmd.Parameters.AddWithValue("@FechaDesde", desde.Date);
                cmd.Parameters.AddWithValue("@FechaHasta", hasta.Date);

                // Si viene "Todos" o vacío mandamos DBNull para que el SP no filtre por tipo
                if (string.IsNullOrEmpty(tipoMovimiento) || tipoMovimiento == "Todos")
                    cmd.Parameters.AddWithValue("@TipoMovimiento", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@TipoMovimiento", tipoMovimiento);

                // Si no se eligió cuenta específica mandamos DBNull
                if (cuentaId.HasValue)
                    cmd.Parameters.AddWithValue("@CuentaId", cuentaId.Value);
                else
                    cmd.Parameters.AddWithValue("@CuentaId", DBNull.Value);

                await con.OpenAsync();

                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        lista.Add(new ReporteMovimientoDTO
                        {
                            Id                 = Convert.ToInt32(reader["Id"]),
                            Fecha              = Convert.ToDateTime(reader["Fecha"]),
                            TipoMovimiento     = reader["TipoMovimiento"].ToString() ?? string.Empty,
                            CuentaOrigen       = reader["CuentaOrigen"].ToString() ?? string.Empty,
                            DestinoOCategoria  = reader["DestinoOCategoria"].ToString() ?? string.Empty,
                            Descripcion        = reader["Descripcion"].ToString() ?? string.Empty,
                            Monto              = Convert.ToDecimal(reader["Monto"])
                        });
                    }
                }
            }

            return lista;
        }

        // Llama al SP sp_Reportes_GastosPorCategoria y retorna el desglose por categoría
        public async Task<List<ReporteGastoCategoriaDTO>> ObtenerGastosPorCategoriaAsync(
            int usuarioId,
            DateTime desde,
            DateTime hasta,
            int? cuentaId)
        {
            var lista = new List<ReporteGastoCategoriaDTO>();

            using (SqlConnection con = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_Reportes_GastosPorCategoria", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                cmd.Parameters.AddWithValue("@FechaDesde", desde.Date);
                cmd.Parameters.AddWithValue("@FechaHasta", hasta.Date);

                if (cuentaId.HasValue)
                    cmd.Parameters.AddWithValue("@CuentaId", cuentaId.Value);
                else
                    cmd.Parameters.AddWithValue("@CuentaId", DBNull.Value);

                await con.OpenAsync();

                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        lista.Add(new ReporteGastoCategoriaDTO
                        {
                            Categoria              = reader["Categoria"].ToString() ?? string.Empty,
                            ColorHex               = reader["ColorHex"] != DBNull.Value
                                                        ? reader["ColorHex"].ToString()!
                                                        : "#3B82F6",
                            TotalGastado           = Convert.ToDecimal(reader["TotalGastado"]),
                            Porcentaje             = Convert.ToDecimal(reader["Porcentaje"]),
                            CantidadTransacciones  = Convert.ToInt32(reader["CantidadTransacciones"]),
                            PromedioPorTransaccion = Convert.ToDecimal(reader["PromedioPorTransaccion"])
                        });
                    }
                }
            }

            return lista;
        }

        // Llama al SP sp_Reportes_EstadoCuentas y retorna la fotografía actual de todas las cuentas
        public async Task<List<ReporteEstadoCuentaDTO>> ObtenerEstadoCuentasAsync(int usuarioId)
        {
            var lista = new List<ReporteEstadoCuentaDTO>();

            using (SqlConnection con = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_Reportes_EstadoCuentas", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                await con.OpenAsync();

                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        lista.Add(new ReporteEstadoCuentaDTO
                        {
                            Id               = Convert.ToInt32(reader["Id"]),
                            Nombre           = reader["Nombre"].ToString() ?? string.Empty,
                            TipoCuenta       = reader["TipoCuenta"].ToString() ?? string.Empty,
                            Moneda           = reader["Moneda"].ToString() ?? string.Empty,
                            SaldoActual      = Convert.ToDecimal(reader["SaldoActual"]),
                            LimiteCredito    = reader["LimiteCredito"] != DBNull.Value
                                                ? Convert.ToDecimal(reader["LimiteCredito"]) : 0m,
                            DeudaActual      = reader["DeudaActual"] != DBNull.Value
                                                ? Convert.ToDecimal(reader["DeudaActual"]) : 0m,
                            CreditoDisponible = reader["CreditoDisponible"] != DBNull.Value
                                                ? Convert.ToDecimal(reader["CreditoDisponible"]) : 0m,
                            DiaCorte         = reader["DiaCorte"] != DBNull.Value
                                                ? (int?)Convert.ToInt32(reader["DiaCorte"]) : null,
                            DiaPago          = reader["DiaPago"] != DBNull.Value
                                                ? (int?)Convert.ToInt32(reader["DiaPago"]) : null,
                            Estado           = Convert.ToBoolean(reader["Estado"])
                        });
                    }
                }
            }

            return lista;
        }
    }
}
