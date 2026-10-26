using ControlFinanzas.BLL.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


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
            this.Hide(); // Ocultamos el login
            FrmRegistro frmRegistro = new FrmRegistro();
            frmRegistro.ShowDialog();
            this.Show();
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Content.Trim(); // Usa .Content si usas CuoreUI
            string contrasena = txtContrasena.Content.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor llene todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Llamada a la BLL[cite: 3]
            bool esValido = _seguridadService.Autenticar(email, contrasena);

            if (esValido)
            {
                this.DialogResult = DialogResult.OK; // Retorna OK para abrir el Dashboard en Program.cs[cite: 3]
                this.Close();
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
