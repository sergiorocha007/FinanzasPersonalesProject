
using ControlFinanzas.DAL.Common;
using Microsoft.Data.SqlClient;

namespace ControlFinanzas.BLL.Common
{
    public class ConexionBll
    {
        public async Task<(bool Exitoso, string Mensaje)> ProbarConexion(string servidor, string baseDatos, string usuario, string password)
        {
            string cadena = Conexion.ConstruirCadena(servidor, baseDatos, usuario, password);

            try
            {
                using SqlConnection cn = new(cadena);
                await cn.OpenAsync();
                return (true, "Conexión exitosa a la base de datos.");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}
