using ControlFinanzas.BLL.Servicios;
using System;
using System.Windows.Forms;

namespace ControlFinanzas.UI.Formularios
{
    public partial class FrmRegistro : Form
    {
        private readonly SeguridadService _seguridadService;

        public FrmRegistro()
        {
            InitializeComponent();
            _seguridadService = new SeguridadService();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Content.Trim();
            string email = txtEmail.Content.Trim();
            string pass = txtContrasena.Content.Trim();
            string confirmPass = txtConfirmarContrasena.Content.Trim();

            // 1. Validaciones básicas en UI
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar que las contraseñas coincidan
            if (pass != confirmPass)
            {
                MessageBox.Show("Las contraseñas no coinciden. Intenta de nuevo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Enviar a la BLL para registrar
            string resultado = _seguridadService.RegistrarUsuario(nombre, email, pass);

            if (resultado == "OK")
            {
                MessageBox.Show("¡Cuenta creada con éxito! Ahora puedes iniciar sesión.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar todos los campos antes de cerrar (no dejar datos sensibles en memoria de controles)
                LimpiarCampos();

                // Cerrar y volver al Login (NO se inicia sesión automáticamente)
                this.Close();
            }
            else
            {
                MessageBox.Show(resultado, "Error en Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            this.Close();
        }

        /// <summary>
        /// Purga todos los controles de texto para no dejar datos sensibles en memoria.
        /// </summary>
        private void LimpiarCampos()
        {
            txtNombre.Content = string.Empty;
            txtEmail.Content = string.Empty;
            txtContrasena.Content = string.Empty;
            txtConfirmarContrasena.Content = string.Empty;
        }
    }
}
