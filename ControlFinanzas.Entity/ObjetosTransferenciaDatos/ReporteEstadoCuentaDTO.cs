using System;

namespace ControlFinanzas.Entity.ObjetosTransferenciaDatos
{
    // DTO que representa una fila del Reporte 3 (Estado General de Cuentas)
    public class ReporteEstadoCuentaDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string TipoCuenta { get; set; } = string.Empty;

        public string Moneda { get; set; } = string.Empty;

        public decimal SaldoActual { get; set; }

        public decimal LimiteCredito { get; set; }

        public decimal DeudaActual { get; set; }

        public decimal CreditoDisponible { get; set; }

        public int? DiaCorte { get; set; }

        public int? DiaPago { get; set; }

        public bool Estado { get; set; }
    }
}
