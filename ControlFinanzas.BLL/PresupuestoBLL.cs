using ControlFinanzas.DAL;
using ControlFinanzas.Entity.Entidades;

namespace ControlFinanzas.BLL
{
    public class PresupuestoBLL
    {
        private readonly PresupuestoDAL _presupuestoDAL;

        public PresupuestoBLL(PresupuestoDAL presupuestoDAL)
        {
            _presupuestoDAL = presupuestoDAL;
        }

        public async Task<int> GuardarAsync(PresupuestoEntity presupuesto)
        {
            if (presupuesto.LimiteMensual <= 0)
                throw new ArgumentException("El dinero mensual asignado debe ser mayor a cero.");

            if (presupuesto.Mes < 1 || presupuesto.Mes > 12)
                throw new ArgumentException("El mes debe estar entre 1 y 12.");

            if (presupuesto.Anio < 2000)
                throw new ArgumentException("El año ingresado no es válido.");

            if (presupuesto.CategoriaId <= 0)
                throw new ArgumentException("Debe seleccionar una categoría de gasto válida.");

            return await _presupuestoDAL.GuardarAsync(presupuesto);
        }

        public async Task<List<PresupuestoDTO>> ObtenerPorPeriodoAsync(int usuarioId, byte mes, short anio)
        {
            if (usuarioId <= 0)
                throw new ArgumentException("Usuario no válido.");

            if (mes < 1 || mes > 12)
                throw new ArgumentException("El mes debe estar entre 1 y 12.");

            return await _presupuestoDAL.ObtenerPorPeriodoAsync(usuarioId, mes, anio);
        }

        public async Task EliminarAsync(int idPresupuesto, int usuarioId)
        {
            if (idPresupuesto <= 0)
                throw new ArgumentException("ID de presupuesto inválido.");

            await _presupuestoDAL.EliminarAsync(idPresupuesto, usuarioId);
        }
    }
}
