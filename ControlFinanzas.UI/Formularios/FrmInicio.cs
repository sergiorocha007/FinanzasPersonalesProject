using ControlFinanzas.Entity.Sesion;
namespace ControlFinanzas.UI.Formularios.Seguridad
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
            _usuarioIdLogueado = SesionUsuario.UsuarioId;
            btnDashboard.Click += btnDashboard_Click;
            btnReportes.Click  += btnReportes_Click;

            // Abrir automáticamente el Dashboard como pantalla de inicio
            btnDashboard_Click(this, EventArgs.Empty);
        }

        private void cuiButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private Form formularioActivo = null;
        private FrmDashboard _dashboard;
        private FrmCuentas _cuentas;
        private FrmCategorias _categorias;
        private FrmReportes _reportes;

        private FrmTransacciones _Transacciones;

        private FrmPresupuestos _presupuesto;

        private FrmMetasAhorro _metasAhorro;

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
            if (_cuentas == null || _cuentas.IsDisposed)
                _cuentas = new FrmCuentas();
            AbrirFormularioHijo(_cuentas, "Cuentas y Tarjetas");
        }

        private void cuiButton4_Click(object sender, EventArgs e)
        {
            if (_categorias == null || _categorias.IsDisposed)
                _categorias = new FrmCategorias(_usuarioIdLogueado);
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
                formularioActivo = null;
            }

            _cuentas?.Dispose();
            _dashboard?.Dispose();
            _categorias?.Dispose();
            _Transacciones?.Dispose();
            _presupuesto?.Dispose();
            _metasAhorro?.Dispose();
            _reportes?.Dispose();

            SesionUsuario.CerrarSesion();

            Application.Restart();
        }

        private void cuiButton3_Click(object sender, EventArgs e)
        {
            if (_Transacciones == null || _Transacciones.IsDisposed)
                _Transacciones = new FrmTransacciones(_usuarioIdLogueado);
            AbrirFormularioHijo(_Transacciones, "Transacciones");
        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            if (_presupuesto == null || _presupuesto.IsDisposed)
            {
                _presupuesto = new FrmPresupuestos();
            }

            AbrirFormularioHijo(_presupuesto, "Presupuestos");
        }

        private void btnMetasAhorro_Click(object sender, EventArgs e)
        {
            if (_metasAhorro == null || _metasAhorro.IsDisposed)
                _metasAhorro = new FrmMetasAhorro();
            AbrirFormularioHijo(_metasAhorro, "Metas Ahorro");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (_dashboard == null || _dashboard.IsDisposed)
                _dashboard = new FrmDashboard();
            AbrirFormularioHijo(_dashboard, "Dashboard");
        }

        // Abre el formulario de Reportes dentro del panel principal
        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (_reportes == null || _reportes.IsDisposed)
                _reportes = new FrmReportes();
            AbrirFormularioHijo(_reportes, "Reportes");
        }
    }
}
