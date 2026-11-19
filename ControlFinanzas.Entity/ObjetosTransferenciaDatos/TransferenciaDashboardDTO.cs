using System;

namespace ControlFinanzas.Entity.ObjetosTransferenciaDatos
{
    // DTO para mostrar los datos de transferencias entre cuentas en el DataGridView del Dashboard
    public class TransferenciaDashboardDTO
    {
        public int Id { get; set; }

        public string CuentaOrigen { get; set; } = string.Empty;

        public string CuentaDestino { get; set; } = string.Empty;

        public decimal Monto { get; set; }

        public DateTime Fecha { get; set; }
    }
}
