using ControlFinanzas.DAL;
using ControlFinanzas.Entity.Entidades;

namespace ControlFinanzas.BLL
{
    public class TransaccionBLL
    {
        private readonly TransaccionesDAL _transaccionesDAL;

        
        public static event EventHandler? TransferenciaEjecutada;
        /// <summary>
        /// Se dispara cuando se registra un Ingreso o un Gasto,
        /// para que otros formularios (ej. FrmCuentas) actualicen sus saldos.
        /// </summary>
        public static event EventHandler? MovimientoRegistrado;

        private static void NotificarTransferenciaEjecutada()
        {
            TransferenciaEjecutada?.Invoke(null, EventArgs.Empty);
        }

        private static void NotificarMovimientoRegistrado()
        {
            MovimientoRegistrado?.Invoke(null, EventArgs.Empty);
        }

        public TransaccionBLL(TransaccionesDAL transaccionDal)
        {
            _transaccionesDAL = transaccionDal;
        }

        public async Task<int> AgregarAsync(int usuarioId, TransaccionesEntity transaccion)
        {
            int nuevoId = await _transaccionesDAL.AgregarAsync(usuarioId, transaccion);

            // Notificar a FrmCuentas y otros suscriptores para que refresquen saldos
            NotificarMovimientoRegistrado();

            return nuevoId;
        }

        public async Task<List<HistorialTransaccionesDTO>> ObtenerPorCuentaAsync(int cuentaId, int usuarioId)
        {
            if (cuentaId <= 0)
                throw new ArgumentException("Debe seleccionar una cuenta válida.");

            return await _transaccionesDAL.ObtenerPorCuentaAsync(cuentaId, usuarioId);
        }

        public async Task<List<HistorialTransaccionesDTO>> ObtenerPorUsuarioAsync(int usuarioId)
        {
            return await _transaccionesDAL.ObtenerPorUsuarioAsync(usuarioId);
        }

        public async Task EliminarTransferenciaAsync(int idTransaccion, int usuarioId)
        {
            if (idTransaccion <= 0)
                throw new ArgumentException("ID de transacción inválido.");

            await _transaccionesDAL.EliminarTransferenciaAsync(idTransaccion, usuarioId);
        }

        public async Task<Guid> EjecutarTransferenciaAsync(int usuarioId, int cuentaOrigenId, int cuentaDestinoId, decimal monto, string descripcion)
        {
            if (cuentaOrigenId == cuentaDestinoId)
                throw new ArgumentException("La cuenta de origen y destino no pueden ser la misma.");

            if (monto <= 0)
                throw new ArgumentException("El monto a transferir debe ser mayor a cero.");

            if (cuentaOrigenId <= 0 || cuentaDestinoId <= 0)
                throw new ArgumentException("Debe seleccionar las cuentas de origen y destino.");

            if (!string.IsNullOrWhiteSpace(descripcion) && descripcion.Length > 200)
                throw new ArgumentException("La descripción no puede exceder los 200 caracteres.");

            Guid refId = await _transaccionesDAL.EjecutarTransferenciaAsync(usuarioId, cuentaOrigenId, cuentaDestinoId, monto, descripcion);

            // Notificar a todos los formularios suscritos que hubo una transferencia exitosa
            NotificarTransferenciaEjecutada();

            return refId;
        }
    }
}
