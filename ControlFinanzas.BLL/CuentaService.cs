using ControlFinanzas.DAL;
using ControlFinanzas.Entity;

namespace ControlFinanzas.BLL.Servicios
{
    public class CuentaService
    {
        private readonly ICuentaRepository _cuentaRepository;

        public CuentaService()
        {
            _cuentaRepository = new CuentaRepository();
        }

        public ResumenCuentasDTO ObtenerResumenKPIs(int usuarioId)
        {
            if (usuarioId <= 0)
                throw new ArgumentException("El ID de usuario no es válido.");

            return _cuentaRepository.ObtenerResumenKPIs(usuarioId);
        }
    }
}