using System;
using System.Windows.Forms;
using ControlFinanzas.DAL.Common;
using ControlFinanzas.UI.Formularios;
using ControlFinanzas.UI.Formularios.Seguridad;

namespace ControlFinanzas.UI
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            ConfiguracionDal configuracionDal = new();

            // 1. Verificación de la configuración de base de datos
            if (!configuracionDal.ExisteConfiguracion())
            {
                using (FrmConfiguracionConexion1 frmConfig = new FrmConfiguracionConexion1())
                {
                    if (frmConfig.ShowDialog() != DialogResult.OK)
                        return; // Cancela la ejecución si no se configuró la BD
                }
            }

            // 2. Obtención y asignación de la cadena de conexión
            var config = configuracionDal.Obtener();
            if (config == null)
            {
                MessageBox.Show("No se pudo obtener la configuración de conexión a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Conexion.CadenaConexion = Conexion.ConstruirCadena(config);

            // 3. Autenticación de usuario (Login)
            using (FrmLogin frmLogin = new FrmLogin())
            {
                if (frmLogin.ShowDialog() != DialogResult.OK)
                    return; // Cancela si falla el login o se cierra la ventana
            }

            // 4. Formulario Principal de la aplicación
            Application.Run(new FrmInicio()); // Reemplaza por FrmMenu o FrmPrincipal según el nombre exacto de tu ventana principal
        }
    }
}