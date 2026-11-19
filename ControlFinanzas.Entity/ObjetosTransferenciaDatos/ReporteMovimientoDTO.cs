using System;

namespace ControlFinanzas.Entity.ObjetosTransferenciaDatos
{
    // DTO que representa una fila individual del reporte de movimientos
    public class ReporteMovimientoDTO
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public string TipoMovimiento { get; set; } = string.Empty;

        public string CuentaOrigen { get; set; } = string.Empty;

        public string DestinoOCategoria { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public decimal Monto { get; set; }
    }
}
