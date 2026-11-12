using ControlFinanzas.Entity.Sesion;
namespace ControlFinanzas.UI.Formularios.Seguridad
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
            _usuarioIdLogueado = SesionUsuario.UsuarioId;
        }

        private void cuiButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private Form formularioActivo = null;
        private FrmCuentas _cuentas;
        private FrmCategorias _categorias;

        private FrmTransacciones _Transacciones;

        private FrmPresupuestos _presupuesto;

        private readonly int _usuarioIdLogueado;

        private void AbrirFormularioHijo(Form formularioHijo, string rutaNavegacion)
        {
            if (formularioActivo != null && !ReferenceEquals(formularioActivo, formularioHijo))
                formularioActivo.Hide();   // solo ocultar, NO dispose

            if (!pnlContenedor.Controls.Contains(formularioHijo))
            {
                formularioHijo.TopLevel = false;
                formularioHijo.FormBorderStyle = FormBorderStyle.None;
                formularioHijo.Dock = DockStyle.Fill;
                pnlContenedor.Controls.Add(formularioHijo);
            }

            formularioHijo.BringToFront();
            formularioHijo.Show();
            formularioActivo = formularioHijo;
        }



        private void cuiButton2_Click(object sender, EventArgs e)
        {
            // Carga FrmCuentas dentro del pnlContenedor
            _cuentas ??= new FrmCuentas();
            AbrirFormularioHijo(_cuentas, "Cuentas y Tarjetas");
        }

        private void cuiButton4_Click(object sender, EventArgs e)
        {
            _categorias ??= new FrmCategorias(_usuarioIdLogueado);
            AbrirFormularioHijo(_categorias, "Categorias");
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
        "¿Deseas cerrar la sesión actual?",
        "Cerrar Sesión",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            if (formularioActivo != null)
            {
                pnlContenedor.Controls.Remove(formularioActivo);
                formularioActivo.Dispose();
                formularioActivo = null;
            }

            SesionUsuario.CerrarSesion();

            Application.Restart();
        }

        private void cuiButton3_Click(object sender, EventArgs e)
        {
            _Transacciones ??= new FrmTransacciones(_usuarioIdLogueado);
            AbrirFormularioHijo(_Transacciones, "Transacciones");
        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            _presupuesto ??= new FrmPresupuestos();
            AbrirFormularioHijo(_presupuesto, "Presupuestos");
        }
    }
}
