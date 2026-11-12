using ControlFinanzas.Entity;

namespace ControlFinanzas.DAL
{
    public interface ICuentaRepository
    {
        ResumenCuentasDTO ObtenerResumenKPIs(int usuarioId);
    }

}
