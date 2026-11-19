using ControlFinanzas.Entity.ObjetosTransferenciaDatos;

namespace ControlFinanzas.DAL
{
    public interface ICuentaRepository
    {
        ResumenCuentasDTO ObtenerResumenKPIs(int usuarioId);
    }

}
