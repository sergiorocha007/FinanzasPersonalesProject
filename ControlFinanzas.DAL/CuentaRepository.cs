using ControlFinanzas.DAL.Common; // <-- Asegúrate de agregar esta referencia
using ControlFinanzas.Entity;
using Microsoft.Data.SqlClient;
using System.Data;


namespace ControlFinanzas.DAL
{
    public class CuentaRepository : ICuentaRepository
    {
        // Usa la conexión dinámica de tu proyecto
        private string ConnectionString => Conexion.CadenaConexion;

        public ResumenCuentasDTO ObtenerResumenKPIs(int usuarioId)
        {
            ResumenCuentasDTO resumen = new ResumenCuentasDTO();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Cuentas_ObtenerResumenKPIs", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            resumen.TotalLiquidez = Convert.ToDecimal(reader["TotalLiquidez"]);
                            resumen.TotalDeudaCredito = Convert.ToDecimal(reader["TotalDeudaCredito"]);
                            resumen.TotalCreditoDisponible = Convert.ToDecimal(reader["TotalCreditoDisponible"]);
                            resumen.TotalLimiteCredito = Convert.ToDecimal(reader["TotalLimiteCredito"]);
                        }
                    }
                }
            }

            return resumen;
        }
    }
}