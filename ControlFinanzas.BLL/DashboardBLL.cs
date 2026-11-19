using ControlFinanzas.DAL;
using ControlFinanzas.Entity.ObjetosTransferenciaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlFinanzas.BLL
{
    public class DashboardBLL
    {
        private readonly DashboardDAL _dashboardDAL;
        private readonly PresupuestoDAL _presupuestoDAL;

        // Constructor que inicializa las dependencias DAL necesarias
        public DashboardBLL(DashboardDAL? dashboardDAL = null, PresupuestoDAL? presupuestoDAL = null)
        {
            _dashboardDAL = dashboardDAL ?? new DashboardDAL();
            _presupuestoDAL = presupuestoDAL ?? new PresupuestoDAL();
        }

        // Obtiene los montos consolidados para las 4 tarjetas principales
        public async Task<DashboardResumenDTO> ObtenerResumenAsync(int usuarioId)
        {
            if (usuarioId <= 0)
                throw new ArgumentException("El ID de usuario no es válido.");

            return await _dashboardDAL.ObtenerResumenAsync(usuarioId);
        }

        // Obtiene la lista de categorías con su gasto y porcentaje para el mes especificado
        public async Task<List<GastoPorCategoriaDTO>> ObtenerGastosPorCategoriaAsync(int usuarioId, int? mes = null, int? anio = null)
        {
            if (usuarioId <= 0)
                throw new ArgumentException("El ID de usuario no es válido.");

            int mesConsulta = mes ?? DateTime.Now.Month;
            int anioConsulta = anio ?? DateTime.Now.Year;

            return await _dashboardDAL.ObtenerGastosPorCategoriaAsync(usuarioId, mesConsulta, anioConsulta);
        }

        // Obtiene el historial de ingresos vs gastos de los últimos 6 meses para la gráfica de barras
        public async Task<List<ComparativaMesDTO>> ObtenerIngresosVsGastos6MesesAsync(int usuarioId)
        {
            if (usuarioId <= 0)
                throw new ArgumentException("El ID de usuario no es válido.");

            return await _dashboardDAL.ObtenerIngresosVsGastos6MesesAsync(usuarioId);
        }

        // Obtiene las transferencias más recientes realizadas entre cuentas
        public async Task<List<TransferenciaDashboardDTO>> ObtenerUltimasTransferenciasAsync(int usuarioId, int top = 5)
        {
            if (usuarioId <= 0)
                throw new ArgumentException("El ID de usuario no es válido.");

            if (top <= 0)
                top = 5;

            return await _dashboardDAL.ObtenerUltimasTransferenciasAsync(usuarioId, top);
        }

        // Obtiene los 3 presupuestos que están en mayor riesgo (mayor porcentaje consumido) en el mes actual
        public async Task<List<PresupuestoDTO>> ObtenerPresupuestosEnRiesgoAsync(int usuarioId, byte? mes = null, short? anio = null, int top = 3)
        {
            if (usuarioId <= 0)
                throw new ArgumentException("El ID de usuario no es válido.");

            byte mesConsulta = mes ?? (byte)DateTime.Now.Month;
            short anioConsulta = anio ?? (short)DateTime.Now.Year;

            // Consultar todos los presupuestos del periodo mediante la DAL de Presupuestos
            List<PresupuestoDTO> todos = await _presupuestoDAL.ObtenerPorPeriodoAsync(usuarioId, mesConsulta, anioConsulta);

            // Ordenar de mayor a menor porcentaje consumido y tomar los 3 primeros
            return todos
                .OrderByDescending(p => p.PorcentajeConsumido)
                .Take(top)
                .ToList();
        }
    }
}
