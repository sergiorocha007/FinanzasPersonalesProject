using ControlFinanzas.BLL.Servicios;
using ControlFinanzas.Entity.Entidades;
using ControlFinanzas.Entity.Sesion;


namespace ControlFinanzas.UI.Formularios
{
    public partial class FrmLogin : Form
    {
        private readonly SeguridadService _seguridadService;

        public FrmLogin()
        {
            InitializeComponent();
            _seguridadService = new SeguridadService();
        }

        private void btnRegristarse_Click(object sender, EventArgs e)
        {
            using (var frmRegistro = new FrmRegistro())
            {
                frmRegistro.StartPosition = FormStartPosition.CenterParent;
                frmRegistro.ShowDialog(this);  
            }
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Content.Trim();
            string contrasena = txtContrasena.Content.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor llene todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Llamada a la BLL: ahora retorna el objeto completo o null
            UsuarioEntity usuarioAutenticado = _seguridadService.Autenticar(email, contrasena);

            if (usuarioAutenticado != null)
            {
                // Iniciar sesión con el objeto usuario completo (Id, Nombre, Email)
                SesionUsuario.IniciarSesion(usuarioAutenticado);

                this.DialogResult = DialogResult.OK;
               
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContrasena.Text = "";
                txtContrasena.Focus();
            }
        }

        private void cuiCheckbox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
