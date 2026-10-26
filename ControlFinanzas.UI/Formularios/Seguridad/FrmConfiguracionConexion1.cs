using ControlFinanzas.DAL.Common;
using ControlFinanzas.Entity.Entidades;
using ControlFinanzas.BLL.Common;
using System;
using System.Windows.Forms;

namespace ControlFinanzas.UI.Formularios
{
    public partial class FrmConfiguracionConexion1 : Form
    {
        public FrmConfiguracionConexion1()
        {
            InitializeComponent();
            CargarConfiguracionExistente();
        }

        private void CargarConfiguracionExistente()
        {
            ConfiguracionDal dal = new();
            var config = dal.Obtener();

            if (config != null)
            {
                txtServidor.Text = config.Servidor;
                txtBaseDatos.Text = config.BaseDatos;
                txtUsuario.Text = config.UsuarioSql;
                txtContrasena.Text = config.Password;
            }
        }

        private bool ValidarControl()
        {
            errorIcon.Clear();

            if (string.IsNullOrWhiteSpace(txtServidor.Text))
            {
                errorIcon.SetError(txtServidor, "Debe ingresar el nombre del servidor");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBaseDatos.Text))
            {
                errorIcon.SetError(txtBaseDatos, "Debe ingresar el nombre de la base de datos");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                errorIcon.SetError(txtUsuario, "Debe ingresar el nombre de usuario");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                errorIcon.SetError(txtContrasena, "Debe ingresar la clave de usuario");
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarControl())
                return;

            ConexionEntity config = new()
            {
                Servidor = txtServidor.Text.Trim(),
                BaseDatos = txtBaseDatos.Text.Trim(),
                UsuarioSql = txtUsuario.Text.Trim(),
                Password = txtContrasena.Text.Trim()
            };

            ConfiguracionDal dal = new();
            bool resultado = dal.Guardar(config);

            if (!resultado)
            {
                MessageBox.Show("No fue posible guardar la configuración.", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Configuración guardada correctamente.", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private async void btnProbarConexion_Click(object sender, EventArgs e)
        {
            if (!ValidarControl())
                return;

            btnProbarConexion.Enabled = false;
            Cursor = Cursors.WaitCursor;

            try
            {
                ConexionBll conexionBll = new();

                var (ok, mensaje) = await conexionBll.ProbarConexion(
                    txtServidor.Text.Trim(),
                    txtBaseDatos.Text.Trim(),
                    txtUsuario.Text.Trim(),
                    txtContrasena.Text.Trim());

                if (ok)
                {
                    MessageBox.Show("Conexión exitosa", "Mensaje", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    btnGuardar.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"Error al conectar con la base de datos:\n\n{mensaje}", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    btnGuardar.Enabled = false;
                }
            }
            finally
            {
                btnProbarConexion.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
