using ControlFinanzas.DAL.Common;
using ControlFinanzas.Entity.Sesion;
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
            // FrmLogin internamente llama a SesionUsuario.IniciarSesion() al autenticar.
            // Solo retorna DialogResult.OK si la sesión fue iniciada exitosamente.
            using (FrmLogin frmLogin = new FrmLogin())
            {
                if (frmLogin.ShowDialog() != DialogResult.OK)
                {
                    // Asegurar que no quede sesión residual si se cancela
                    SesionUsuario.CerrarSesion();
                    return;
                }
            }

            // 4. Formulario Principal de la aplicación
            // La sesión activa (SesionUsuario) ya está disponible para todos los formularios.
            Application.Run(new FrmInicio());

            // 5. Al salir del Application.Run (cierre normal), purgar la sesión en memoria
            SesionUsuario.CerrarSesion();
        }
    }
}
