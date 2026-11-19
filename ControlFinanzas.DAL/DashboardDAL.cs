using ControlFinanzas.DAL.Common;
using ControlFinanzas.Entity.ObjetosTransferenciaDatos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace ControlFinanzas.DAL
{
    
    public class DashboardDAL
    {
        // Obtiene el consolidado de las 4 tarjetas de resumen del mes actual
        public async Task<DashboardResumenDTO> ObtenerResumenAsync(int usuarioId)
        {
            DashboardResumenDTO resumen = new DashboardResumenDTO();

            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new SqlCommand("sp_Dashboard_ObtenerResumen", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                await cn.OpenAsync();
                using SqlDataReader dr = await cmd.ExecuteReaderAsync();

                if (await dr.ReadAsync())
                {
                    resumen.TotalPatrimonio = dr["TotalPatrimonio"] != DBNull.Value ? Convert.ToDecimal(dr["TotalPatrimonio"]) : 0m;
                    resumen.TotalIngresosMes = dr["TotalIngresosMes"] != DBNull.Value ? Convert.ToDecimal(dr["TotalIngresosMes"]) : 0m;
                    resumen.TotalGastosMes = dr["TotalGastosMes"] != DBNull.Value ? Convert.ToDecimal(dr["TotalGastosMes"]) : 0m;
                    resumen.TotalAhorrado = dr["TotalAhorrado"] != DBNull.Value ? Convert.ToDecimal(dr["TotalAhorrado"]) : 0m;
                }

                return resumen;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el resumen del Dashboard: " + ex.Message);
            }
        }

        // Obtiene el desglose de gastos agrupados por categoría para la gráfica de dona
        public async Task<List<GastoPorCategoriaDTO>> ObtenerGastosPorCategoriaAsync(int usuarioId, int mes, int anio)
        {
            List<GastoPorCategoriaDTO> lista = new List<GastoPorCategoriaDTO>();

            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new SqlCommand("sp_Dashboard_GastosPorCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                cmd.Parameters.AddWithValue("@Mes", mes);
                cmd.Parameters.AddWithValue("@Anio", anio);

                await cn.OpenAsync();
                using SqlDataReader dr = await cmd.ExecuteReaderAsync();

                while (await dr.ReadAsync())
                {
                    GastoPorCategoriaDTO item = new GastoPorCategoriaDTO
                    {
                        Categoria = dr["Categoria"] != DBNull.Value ? dr["Categoria"].ToString()! : string.Empty,
                        ColorHex = dr["ColorHex"] != DBNull.Value ? dr["ColorHex"].ToString()! : "#808080",
                        TotalGasto = dr["TotalGasto"] != DBNull.Value ? Convert.ToDecimal(dr["TotalGasto"]) : 0m,
                        Porcentaje = dr["Porcentaje"] != DBNull.Value ? Convert.ToDecimal(dr["Porcentaje"]) : 0m
                    };
                    lista.Add(item);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los gastos por categoría: " + ex.Message);
            }
        }

        // Obtiene la comparativa mensual de ingresos vs gastos de los últimos 6 meses
        public async Task<List<ComparativaMesDTO>> ObtenerIngresosVsGastos6MesesAsync(int usuarioId)
        {
            List<ComparativaMesDTO> lista = new List<ComparativaMesDTO>();

            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new SqlCommand("sp_Dashboard_IngresosVsGastos6Meses", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                await cn.OpenAsync();
                using SqlDataReader dr = await cmd.ExecuteReaderAsync();

                while (await dr.ReadAsync())
                {
                    ComparativaMesDTO item = new ComparativaMesDTO
                    {
                        NombreMes = dr["NombreMes"] != DBNull.Value ? dr["NombreMes"].ToString()! : string.Empty,
                        Mes = dr["Mes"] != DBNull.Value ? Convert.ToInt32(dr["Mes"]) : 1,
                        Anio = dr["Anio"] != DBNull.Value ? Convert.ToInt32(dr["Anio"]) : DateTime.Now.Year,
                        TotalIngresos = dr["TotalIngresos"] != DBNull.Value ? Convert.ToDecimal(dr["TotalIngresos"]) : 0m,
                        TotalGastos = dr["TotalGastos"] != DBNull.Value ? Convert.ToDecimal(dr["TotalGastos"]) : 0m
                    };
                    lista.Add(item);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la comparativa de los últimos 6 meses: " + ex.Message);
            }
        }

        // Obtiene las transferencias más recientes realizadas entre cuentas
        public async Task<List<TransferenciaDashboardDTO>> ObtenerUltimasTransferenciasAsync(int usuarioId, int top = 5)
        {
            List<TransferenciaDashboardDTO> lista = new List<TransferenciaDashboardDTO>();

            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new SqlCommand("sp_Dashboard_UltimasTransferencias", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                cmd.Parameters.AddWithValue("@Top", top);

                await cn.OpenAsync();
                using SqlDataReader dr = await cmd.ExecuteReaderAsync();

                while (await dr.ReadAsync())
                {
                    TransferenciaDashboardDTO item = new TransferenciaDashboardDTO
                    {
                        Id = dr["Id"] != DBNull.Value ? Convert.ToInt32(dr["Id"]) : 0,
                        CuentaOrigen = dr["CuentaOrigen"] != DBNull.Value ? dr["CuentaOrigen"].ToString()! : string.Empty,
                        CuentaDestino = dr["CuentaDestino"] != DBNull.Value ? dr["CuentaDestino"].ToString()! : "—",
                        Monto = dr["Monto"] != DBNull.Value ? Convert.ToDecimal(dr["Monto"]) : 0m,
                        Fecha = dr["Fecha"] != DBNull.Value ? Convert.ToDateTime(dr["Fecha"]) : DateTime.Now
                    };
                    lista.Add(item);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las últimas transferencias: " + ex.Message);
            }
        }
    }
}
