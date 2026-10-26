using ControlFinanzas.DAL.Common;
using ControlFinanzas.Entity.Entidades;
using Microsoft.Data.SqlClient;
using System;

namespace ControlFinanzas.DAL
{
    public class UsuarioRepository : IUsuarioRepository
    {

        public bool Insertar(UsuarioEntity usuario)
        {
            using (SqlConnection con = new SqlConnection(Conexion.CadenaConexion))
            {
                string query = "INSERT INTO Usuarios (Nombre, Email, PasswordHash, Estado) VALUES (@Nombre, @Email, @PasswordHash, 1)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@Email", usuario.Email);
                    cmd.Parameters.AddWithValue("@PasswordHash", usuario.PasswordHash);

                    con.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        public UsuarioEntity ObtenerPorEmail(string email)
        {
            using (SqlConnection con = new SqlConnection(Conexion.CadenaConexion))
            {
                string query = "SELECT Id, Nombre, Email, PasswordHash, Estado FROM Usuarios WHERE Email = @Email AND Estado = 1";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new UsuarioEntity
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Nombre = reader["Nombre"].ToString(),
                                Email = reader["Email"].ToString(),
                                PasswordHash = reader["PasswordHash"].ToString(),
                                Estado = Convert.ToBoolean(reader["Estado"])
                            };
                        }
                    }
                }
            }
            return null; // Si no existe el usuario
        }
    }
}
