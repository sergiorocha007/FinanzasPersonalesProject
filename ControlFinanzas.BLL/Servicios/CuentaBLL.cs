using ControlFinanzas.DAL;
using ControlFinanzas.Entity.Entidades;
using ControlFinanzas.Entity.Sesion;

namespace ControlFinanzas.BLL.Servicios
{

    public class CuentaBLL
    {
        private readonly CuentaDAO _cuentaDAO;

        public CuentaBLL()
        {
            _cuentaDAO = new CuentaDAO();

        }
        public string Guardar(Cuenta cuenta)
        {
            cuenta.UsuarioId = SesionUsuario.UsuarioId;

            ValidarCuenta(cuenta);

            bool exito;
            if (cuenta.Id == 0)
                exito = _cuentaDAO.Insertar(cuenta);
            else
                exito = _cuentaDAO.Actualizar(cuenta);

            return exito ? "OK" : "No se pudo guardar la cuenta en la base de datos.";
        }

    
        public string DesactivarActivar(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Debe seleccionar una cuenta válida para cambiar su estado.");

            bool exito = _cuentaDAO.DesactivarActivar(id, SesionUsuario.UsuarioId);
            return exito ? "OK" : "No se pudo cambiar el estado de la cuenta.";
        }

        public List<Cuenta> ObtenerTodas()
        {
            return _cuentaDAO.ObtenerTodas(SesionUsuario.UsuarioId);
        }


        public List<Cuenta> BuscarPorNombre(string nombre)
        {
            return _cuentaDAO.BuscarPorNombre(nombre, SesionUsuario.UsuarioId);
        }


        private void ValidarCuenta(Cuenta cuenta)
        {
            
            if (string.IsNullOrWhiteSpace(cuenta.Nombre))
                throw new ArgumentException("El campo Nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(cuenta.TipoCuenta))
                throw new ArgumentException("El campo Tipo de Cuenta es obligatorio.");

            if (string.IsNullOrWhiteSpace(cuenta.Moneda))
                throw new ArgumentException("El campo Moneda es obligatorio.");

            
            if (cuenta is TarjetaCredito tc)
            {
                if (tc.LimiteCredito <= 0)
                    throw new ArgumentException("El Límite de Crédito debe ser mayor a 0.");

                if (tc.DiaCorte < 1 || tc.DiaCorte > 31)
                    throw new ArgumentException("El Día de Corte debe estar entre 1 y 31.");

                if (tc.DiaPago < 1 || tc.DiaPago > 31)
                    throw new ArgumentException("El Día de Pago debe estar entre 1 y 31.");
            }

            
            if (cuenta is CuentaDebito cd)
            {
                if (cd.SaldoActual < 0)
                    throw new ArgumentException("El Saldo Actual no puede ser negativo.");
            }
        }
    }
}
