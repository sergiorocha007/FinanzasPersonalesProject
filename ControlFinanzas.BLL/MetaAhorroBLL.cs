using ControlFinanzas.DAL;
using ControlFinanzas.Entity.Entidades;
using ControlFinanzas.Entity.Sesion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlFinanzas.BLL
{
    public class MetaAhorroBLL
    {
        private readonly MetaAhorroDAL _dal;

        public MetaAhorroBLL(MetaAhorroDAL? dal = null)
        {
            _dal = dal ?? new MetaAhorroDAL();
        }

        public async Task<List<MetaAhorroEntity>> ObtenerPorUsuarioAsync(int usuarioId, string? filtroEstado = null)
        {
            if (usuarioId <= 0)
                throw new ArgumentException("El Id de usuario no es válido.");

            var lista = await _dal.ObtenerPorUsuarioAsync(usuarioId);

            if (string.IsNullOrWhiteSpace(filtroEstado) || filtroEstado.Equals("Todas", StringComparison.OrdinalIgnoreCase) || filtroEstado.Equals("Todos", StringComparison.OrdinalIgnoreCase))
            {
                return lista;
            }

            return lista
                .Where(m => m.Estado.Equals(filtroEstado.Trim(), StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public async Task<int> GuardarAsync(MetaAhorroEntity meta)
        {
            if (meta == null)
                throw new ArgumentNullException(nameof(meta), "Los datos de la meta no pueden ser nulos.");

            if (meta.UsuarioId <= 0 && SesionUsuario.HaySesionActiva)
            {
                meta.AsignarUsuarioId(SesionUsuario.UsuarioId);
            }

            if (meta.UsuarioId <= 0)
                throw new Exception("El Id del usuario es requerido para guardar la meta.");

            if (string.IsNullOrWhiteSpace(meta.Nombre))
                throw new Exception("El nombre de la meta es obligatorio.");

            if (meta.MontoObjetivo <= 0)
                throw new Exception("El monto objetivo debe ser mayor a cero.");

            if (meta.Id == 0)
            {
                if (meta.FechaLimite.Date < DateTime.Today)
                    throw new Exception("La fecha límite debe ser igual o posterior a la fecha actual.");

                int nuevoId = await _dal.InsertarAsync(meta);
                if (nuevoId <= 0)
                    throw new Exception("No se pudo registrar la meta de ahorro en la base de datos.");

                meta.AsignarId(nuevoId);
                EventosFinanzas.NotificarMetasAhorroCambiadas();
                return nuevoId;
            }
            else
            {
                bool exito = await _dal.ActualizarAsync(meta);
                if (!exito)
                    throw new Exception("No se pudo actualizar la meta de ahorro.");

                EventosFinanzas.NotificarMetasAhorroCambiadas();
                return meta.Id;
            }
        }

        public async Task<bool> AbonarAsync(int usuarioId, int metaId, int cuentaId, decimal monto)
        {
            if (usuarioId <= 0)
                throw new ArgumentException("Id de usuario no válido.");

            if (metaId <= 0)
                throw new ArgumentException("Debe seleccionar una meta válida para abonar.");

            if (cuentaId <= 0)
                throw new ArgumentException("Debe seleccionar una cuenta de origen válida.");

            if (monto <= 0)
                throw new ArgumentException("El monto a abonar debe ser mayor a cero.");

            bool resultado = await _dal.AbonarAsync(usuarioId, metaId, cuentaId, monto);
            if (resultado)
            {
                EventosFinanzas.NotificarCuentasCambiadas();
                EventosFinanzas.NotificarMetasAhorroCambiadas();
            }
            return resultado;
        }

        public async Task<bool> CancelarYDevolverAsync(int usuarioId, int metaId, int cuentaDestinoId)
        {
            if (usuarioId <= 0)
                throw new ArgumentException("Id de usuario no válido.");

            if (metaId <= 0)
                throw new ArgumentException("Debe seleccionar una meta válida.");

            if (cuentaDestinoId <= 0)
                throw new ArgumentException("Debe seleccionar una cuenta destino válida para el reembolso.");

            bool resultado = await _dal.CancelarYDevolverAsync(usuarioId, metaId, cuentaDestinoId);
            if (resultado)
            {
                EventosFinanzas.NotificarCuentasCambiadas();
                EventosFinanzas.NotificarMetasAhorroCambiadas();
            }
            return resultado;
        }

        public async Task<bool> CambiarEstadoAsync(int metaId, int usuarioId, string nuevoEstado)
        {
            if (metaId <= 0)
                throw new ArgumentException("Debe seleccionar una meta válida.");

            if (usuarioId <= 0)
                throw new ArgumentException("Id de usuario no válido.");

            bool resultado = await _dal.CambiarEstadoAsync(metaId, usuarioId, nuevoEstado);
            if (resultado)
            {
                EventosFinanzas.NotificarMetasAhorroCambiadas();
            }
            return resultado;
        }

        public async Task<bool> EliminarAsync(int metaId, int usuarioId)
        {
            if (metaId <= 0)
                throw new ArgumentException("Debe seleccionar una meta válida.");

            if (usuarioId <= 0)
                throw new ArgumentException("Id de usuario no válido.");

            bool resultado = await _dal.EliminarAsync(metaId, usuarioId);
            if (resultado)
            {
                EventosFinanzas.NotificarMetasAhorroCambiadas();
            }
            return resultado;
        }
    }
}
