using System;

namespace ControlFinanzas.Entity.ObjetosTransferenciaDatos
{
    // DTO que agrupa los totales de cabecera del Reporte 1 (Historial de Movimientos)
    public class ReporteMovimientosResumenDTO
    {
        public decimal TotalIngresos { get; set; }

        public decimal TotalGastos { get; set; }

        public decimal FlujoNeto { get; set; }

        public decimal TotalTransferido { get; set; }
    }
}
