using System;

namespace ControlFinanzas.Entity.ObjetosTransferenciaDatos
{
    // DTO que representa una fila del Reporte 2 (Gastos por Categoría)
    public class ReporteGastoCategoriaDTO
    {
        public string Categoria { get; set; } = string.Empty;

        public string ColorHex { get; set; } = "#3B82F6";

        public decimal TotalGastado { get; set; }

        public decimal Porcentaje { get; set; }

        public int CantidadTransacciones { get; set; }

        public decimal PromedioPorTransaccion { get; set; }
    }
}
