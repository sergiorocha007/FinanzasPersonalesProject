using Microsoft.Data.SqlClient;
using ControlFinanzas.Entity.Entidades;

namespace ControlFinanzas.DAL.Common
{
    public class Conexion
    {
        public static string CadenaConexion { get; set; } = string.Empty;

        public static string ConstruirCadena(ConexionEntity? config)
        {
            if (config == null)
                return string.Empty;

            return ConstruirCadena(config.Servidor, config.BaseDatos, config.UsuarioSql, config.Password);
        }

        public static string ConstruirCadena(string servidor, string baseDatos, string usuario, string password)
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = servidor,
                InitialCatalog = baseDatos,
                UserID = usuario,
                Password = password,
                TrustServerCertificate = true,
                ConnectTimeout = 15
            };

            return builder.ConnectionString;
        }

        public static SqlConnection ObtenerConexion()
        {
            if (string.IsNullOrWhiteSpace(CadenaConexion))
            {
                throw new InvalidOperationException("La cadena de conexión a la base de datos no está configurada.");
            }

            return new SqlConnection(CadenaConexion);
        }
    }
}
