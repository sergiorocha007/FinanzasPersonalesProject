using System;

namespace ControlFinanzas.BLL
{
    public static class EventosFinanzas
    {

        public static event EventHandler? CuentasCambiadas;

        public static event EventHandler? MetasAhorroCambiadas;

        public static event EventHandler? TransaccionesCambiadas;

        public static event EventHandler? PresupuestosCambiados;

        public static event EventHandler? CategoriasCambiadas;

        public static void NotificarCuentasCambiadas()
        {
            CuentasCambiadas?.Invoke(null, EventArgs.Empty);
        }

        public static void NotificarMetasAhorroCambiadas()
        {
            MetasAhorroCambiadas?.Invoke(null, EventArgs.Empty);
        }

        public static void NotificarTransaccionesCambiadas()
        {
            TransaccionesCambiadas?.Invoke(null, EventArgs.Empty);
        }

        public static void NotificarPresupuestosCambiados()
        {
            PresupuestosCambiados?.Invoke(null, EventArgs.Empty);
        }

        public static void NotificarCategoriasCambiadas()
        {
            CategoriasCambiadas?.Invoke(null, EventArgs.Empty);
        }
    }
}
