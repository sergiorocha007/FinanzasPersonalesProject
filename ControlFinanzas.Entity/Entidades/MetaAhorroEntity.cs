using System;
using System.Text.RegularExpressions;

namespace ControlFinanzas.Entity.Entidades
{
    public class MetaAhorroEntity
    {
        #region Propiedades

        public int Id { get; private set; }

        public int UsuarioId { get; private set; }

        public string Nombre { get; private set; } = string.Empty;

        public decimal MontoObjetivo { get; private set; }

        public decimal MontoActual { get; private set; }

        public DateTime FechaLimite { get; private set; }

        public string Estado { get; private set; } = "Activa";

        #endregion

        #region Propiedades Calculadas
        /// Porcentaje de progreso de 0 a 100%.
        public decimal PorcentajeCompletado
        {
            get
            {
                if (MontoObjetivo <= 0) return 0m;
                decimal pct = (MontoActual / MontoObjetivo) * 100m;
                return Math.Min(100m, Math.Round(pct, 2));
            }
        }

        /// Dinero faltante para alcanzar el objetivo.
        public decimal MontoFaltante
        {
            get
            {
                decimal falta = MontoObjetivo - MontoActual;
                return falta > 0 ? falta : 0m;
            }
        }

        /// Días restantes hasta la fecha límite.
        public int DiasRestantes
        {
            get
            {
                int dias = (FechaLimite.Date - DateTime.Today).Days;
                return dias > 0 ? dias : 0;
            }
        }


        /// Indica si la meta ya alcanzó o superó el objetivo.
        public bool EstaCompletada => MontoActual >= MontoObjetivo;

        /// Cuánto ahorrar por semana para cumplir la meta a tiempo.
        public decimal SugerenciaSemanal
        {
            get
            {
                if (EstaCompletada || MontoFaltante <= 0) return 0m;
                double semanas = Math.Max(1.0, DiasRestantes / 7.0);
                return Math.Round(MontoFaltante / (decimal)semanas, 2);
            }
        }

        #endregion

        #region Constructores

        public MetaAhorroEntity() { }

        public MetaAhorroEntity(int usuarioId, string nombre, decimal montoObjetivo, DateTime fechaLimite)
        {
            AsignarUsuarioId(usuarioId);
            CambiarNombre(nombre);
            AsignarMontoObjetivo(montoObjetivo);
            AsignarFechaLimite(fechaLimite);

            MontoActual = 0.00m;
            Estado = "Activa";
        }

        #endregion

        #region Metodos

        public void AsignarId(int id)
        {
            if (id <= 0)
                throw new Exception("El Id de la meta de ahorro debe ser mayor a cero.");

            Id = id;
        }

        public void AsignarUsuarioId(int usuarioId)
        {
            if (usuarioId <= 0)
                throw new Exception("El Id del Usuario debe ser mayor a cero.");

            UsuarioId = usuarioId;
        }

        public void CambiarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("El campo 'Nombre' de la meta es obligatorio.");

            if (nombre.Trim().Length > 100)
                throw new Exception("El 'Nombre' de la meta no puede superar los 100 caracteres.");

            Regex regexNombre = new Regex(@"[^a-zA-ZáéíóúÁÉÍÓÚñÑüÜ0-9 \-_]");
            if (regexNombre.IsMatch(nombre))
                throw new Exception("El 'Nombre' contiene caracteres no permitidos. Use solo letras, números, espacios, guión (-) y guión bajo (_).");

            Nombre = nombre.Trim();
        }

        public void AsignarMontoObjetivo(decimal montoObjetivo)
        {
            if (montoObjetivo <= 0)
                throw new Exception("El monto objetivo debe ser mayor a cero.");

            MontoObjetivo = montoObjetivo;
        }

        public void AsignarMontoActual(decimal montoActual)
        {
            if (montoActual < 0)
                throw new Exception("El monto actual no puede ser negativo.");

            MontoActual = montoActual;
        }

        public void AsignarFechaLimite(DateTime fechaLimite)
        {
            if (fechaLimite.Date < DateTime.Today)
                throw new Exception("La fecha límite no puede ser anterior a la fecha actual.");

            FechaLimite = fechaLimite.Date;
        }

        public void CargarFechaDesdeBD(DateTime fechaLimite)
        {
            FechaLimite = fechaLimite.Date;
        }

        public void CambiarEstado(string nuevoEstado)
        {
            if (string.IsNullOrWhiteSpace(nuevoEstado))
                throw new Exception("El estado de la meta es obligatorio.");

            string normalizado = nuevoEstado.Trim();
            if (normalizado != "Activa" && normalizado != "Completada" && normalizado != "Cancelada")
                throw new Exception("El estado debe ser estrictamente 'Activa', 'Completada' o 'Cancelada'.");

            Estado = normalizado;
        }

        #endregion
    }
}
