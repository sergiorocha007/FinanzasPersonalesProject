using ControlFinanzas.DAL.Common;
using ControlFinanzas.Entity.Entidades;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ControlFinanzas.DAL
{
    public class CuentaDAO
    {
        public bool Insertar(Cuenta cuenta)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_Cuentas_Insert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    MapearParametrosComunes(cmd, cuenta);

                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        cuenta.Id = Convert.ToInt32(result);
                        return true;
                    }
                    return false;
                }
            }
        }

        public bool Actualizar(Cuenta cuenta)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_Cuentas_Update", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", cuenta.Id);
                    MapearParametrosComunes(cmd, cuenta);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }

        public bool DesactivarActivar(int id, int usuarioId)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_Cuentas_DesactivarActivar", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public List<Cuenta> ObtenerTodas(int usuarioId)
        {
            var lista = new List<Cuenta>();

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_Cuentas_GetByUsuario", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(MapearDesdeReader(reader));
                        }
                    }
                }
            }

            return lista;
        }


        public List<Cuenta> BuscarPorNombre(string nombre, int usuarioId)
        {
            var lista = new List<Cuenta>();

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_Cuentas_BuscarPorNombre", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(MapearDesdeReader(reader));
                        }
                    }
                }
            }

            return lista;
        }



        private Cuenta MapearDesdeReader(SqlDataReader reader)
        {
            string tipo = reader["TipoCuenta"].ToString()!;
            Cuenta cuenta;

            if (tipo == "Credito")
            {
                cuenta = new TarjetaCredito
                {
                    LimiteCredito = reader["LimiteCredito"] != DBNull.Value ? Convert.ToDecimal(reader["LimiteCredito"]) : 0m,
                    DeudaActual = reader["DeudaActual"] != DBNull.Value ? Convert.ToDecimal(reader["DeudaActual"]) : 0m,
                    DiaCorte = reader["DiaCorte"] != DBNull.Value ? Convert.ToInt32(reader["DiaCorte"]) : 0,
                    DiaPago = reader["DiaPago"] != DBNull.Value ? Convert.ToInt32(reader["DiaPago"]) : 0
                };
            }
            else
            {
                cuenta = new CuentaDebito
                {
                    SaldoActual = reader["SaldoActual"] != DBNull.Value ? Convert.ToDecimal(reader["SaldoActual"]) : 0m
                };
            }

            cuenta.Id = Convert.ToInt32(reader["Id"]);
            cuenta.UsuarioId = Convert.ToInt32(reader["UsuarioId"]);
            cuenta.Nombre = reader["Nombre"].ToString()!;
            cuenta.TipoCuenta = tipo;
            cuenta.Moneda = reader["Moneda"].ToString()!;
            cuenta.Estado = Convert.ToBoolean(reader["Estado"]);

            return cuenta;
        }


        private void MapearParametrosComunes(SqlCommand cmd, Cuenta cuenta)
        {
            cmd.Parameters.AddWithValue("@UsuarioId", cuenta.UsuarioId);
            cmd.Parameters.AddWithValue("@Nombre", cuenta.Nombre);
            cmd.Parameters.AddWithValue("@TipoCuenta", cuenta.TipoCuenta);
            cmd.Parameters.AddWithValue("@Moneda", cuenta.Moneda);
            cmd.Parameters.AddWithValue("@Estado", cuenta.Estado);

            if (cuenta is TarjetaCredito tc)
            {
                cmd.Parameters.AddWithValue("@SaldoActual", 0m);
                cmd.Parameters.AddWithValue("@LimiteCredito", tc.LimiteCredito);
                cmd.Parameters.AddWithValue("@DeudaActual", tc.DeudaActual);
                cmd.Parameters.AddWithValue("@DiaCorte", (object)tc.DiaCorte ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DiaPago", (object)tc.DiaPago ?? DBNull.Value);
            }
            else if (cuenta is CuentaDebito cd)
            {
                cmd.Parameters.AddWithValue("@SaldoActual", cd.SaldoActual);
                cmd.Parameters.AddWithValue("@LimiteCredito", 0m);
                cmd.Parameters.AddWithValue("@DeudaActual", 0m);
                cmd.Parameters.AddWithValue("@DiaCorte", DBNull.Value);
                cmd.Parameters.AddWithValue("@DiaPago", DBNull.Value);
            }
        }
    }
}
