using ControlFinanzas.DAL;
using ControlFinanzas.Entity.ObjetosTransferenciaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlFinanzas.BLL
{
    // Lógica de negocio para el módulo de reportes
    // Valida los filtros antes de llamar al DAL y calcula los KPI de cabecera
    public class ReportesBLL
    {
        private readonly ReportesDAL _dal = new ReportesDAL();

        // Valida que la fecha inicial no sea mayor que la fecha final
        private void ValidarRangoFechas(DateTime desde, DateTime hasta)
        {
            if (desde > hasta)
                throw new ArgumentException("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.");
        }

        // Obtiene la lista de movimientos del Reporte 1 aplicando los filtros dados
        public async Task<List<ReporteMovimientoDTO>> ObtenerMovimientosAsync(
            int usuarioId,
            DateTime desde,
            DateTime hasta,
            string tipoMovimiento,
            int? cuentaId)
        {
            ValidarRangoFechas(desde, hasta);
            return await _dal.ObtenerMovimientosAsync(usuarioId, desde, hasta, tipoMovimiento, cuentaId);
        }

        // Calcula los totales de cabecera (KPI cards) a partir de la lista de movimientos ya obtenida
        // De esta forma no hace una segunda consulta a la base de datos
        public ReporteMovimientosResumenDTO CalcularResumenMovimientos(List<ReporteMovimientoDTO> movimientos)
        {
            // Suma los ingresos filtrando por el tipo
            decimal totalIngresos = movimientos
                .Where(m => m.TipoMovimiento == "Ingreso")
                .Sum(m => m.Monto);

            // Suma los gastos filtrando por el tipo
            decimal totalGastos = movimientos
                .Where(m => m.TipoMovimiento == "Gasto")
                .Sum(m => m.Monto);

            // Suma el dinero movilizado en transferencias (el SP devuelve 'Transferencia')
            decimal totalTransferido = movimientos
                .Where(m => m.TipoMovimiento == "Transferencia" || m.TipoMovimiento == "Transferencia Salida")
                .Sum(m => m.Monto);

            return new ReporteMovimientosResumenDTO
            {
                TotalIngresos    = totalIngresos,
                TotalGastos      = totalGastos,
                FlujoNeto        = totalIngresos - totalGastos,
                TotalTransferido = totalTransferido
            };
        }

        // Obtiene el desglose de gastos agrupado por categoría para el Reporte 2
        public async Task<List<ReporteGastoCategoriaDTO>> ObtenerGastosPorCategoriaAsync(
            int usuarioId,
            DateTime desde,
            DateTime hasta,
            int? cuentaId)
        {
            ValidarRangoFechas(desde, hasta);
            return await _dal.ObtenerGastosPorCategoriaAsync(usuarioId, desde, hasta, cuentaId);
        }

        // Calcula los KPI del Reporte 2 (totales de la pestaña de categorías)
        public (decimal totalGastado, string topCategoria, int totalTransacciones)
            CalcularResumenCategorias(List<ReporteGastoCategoriaDTO> categorias)
        {
            decimal total = categorias.Sum(c => c.TotalGastado);

            // La categoría con más gasto es la primera al ordenar descendente
            string top = categorias.OrderByDescending(c => c.TotalGastado)
                                   .FirstOrDefault()?.Categoria ?? "—";

            int transacciones = categorias.Sum(c => c.CantidadTransacciones);

            return (total, top, transacciones);
        }

        // Obtiene la fotografía actual de todas las cuentas del usuario para el Reporte 3
        public async Task<List<ReporteEstadoCuentaDTO>> ObtenerEstadoCuentasAsync(int usuarioId)
        {
            return await _dal.ObtenerEstadoCuentasAsync(usuarioId);
        }

        // Calcula los totales del pie del Reporte 3
        public (decimal liquidez, decimal deuda, decimal patrimonio)
            CalcularTotalesCuentas(List<ReporteEstadoCuentaDTO> cuentas)
        {
            // Liquidez: saldo de cuentas que no son de crédito
            decimal liquidez = cuentas
                .Where(c => c.TipoCuenta != "Crédito")
                .Sum(c => c.SaldoActual);

            // Deuda: total acumulado en tarjetas de crédito
            decimal deuda = cuentas.Sum(c => c.DeudaActual);

            // Patrimonio neto = liquidez total menos deuda total
            decimal patrimonio = liquidez - deuda;

            return (liquidez, deuda, patrimonio);
        }
    }
}
