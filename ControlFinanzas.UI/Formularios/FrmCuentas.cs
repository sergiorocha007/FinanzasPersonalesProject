using ControlFinanzas.BLL;
using ControlFinanzas.BLL.Servicios;
using ControlFinanzas.Entity;
using ControlFinanzas.Entity.Entidades;
using ControlFinanzas.Entity.Sesion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlFinanzas.UI.Formularios
{
    public partial class FrmCuentas : Form
    {

        private readonly CuentaService _cuentaService;
        private readonly int _usuarioIdLogueado;

        private readonly CuentaBLL _cuentaBLL = new CuentaBLL();


        private int _cuentaIdSeleccionada = 0;
        // Guard para evitar que eventos de CuoreUI disparen logica antes de que el form cargue
        private bool _formularioInicializado = false;

        private List<Cuenta> _listaCuentas = new List<Cuenta>();

        public FrmCuentas()
        {
            InitializeComponent();
            _cuentaService = new CuentaService();
            _usuarioIdLogueado = SesionUsuario.UsuarioId;
            ConfigurarEstiloGrid();
            SuscribirEventos();

            // Escuchar transferencias exitosas para refrescar cuentas en tiempo real
            TransaccionBLL.TransferenciaEjecutada += OnTransferenciaEjecutada;
            // Escuchar ingresos y gastos para refrescar saldos en tiempo real
            TransaccionBLL.MovimientoRegistrado += OnTransferenciaEjecutada;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Desuscribir para evitar memory leaks
            TransaccionBLL.TransferenciaEjecutada -= OnTransferenciaEjecutada;
            TransaccionBLL.MovimientoRegistrado -= OnTransferenciaEjecutada;
            base.OnFormClosed(e);
        }

        private void OnTransferenciaEjecutada(object? sender, EventArgs e)
        {
            // Garantizar ejecución en el hilo de UI
            if (this.IsDisposed || !this.IsHandleCreated) return;

            if (this.InvokeRequired)
                this.Invoke(RefrescarTrasTransferencia);
            else
                RefrescarTrasTransferencia();
        }

        private void RefrescarTrasTransferencia()
        {
            CargarCuentas();
            CargarTarjetasKPI();
        }

        private void FrmCuentas_Load(object sender, EventArgs e)
        {
            CargarCuentas();

            AplicarEstiloTarjetas();
            CargarTarjetasKPI();

            MostrarPanelSegunTipo(cuiComboBox2.SelectedItem?.ToString() ?? "Efectivo");
            _formularioInicializado = true; // Desde aqui los eventos del combo son validos
        }


        private void SuscribirEventos()
        {

            cuiTextBox1.ContentChanged += txtBuscar_ContentChanged;

            cuiComboBox2.SelectedIndexChanged += cmbTipoCuenta_SelectedItemChanged;


            cuiButton3.Click += btnGuardar_Click;
            cuiButton4.Click += btnCancelar_Click;


            cuiButton1.Click += btnEditar_Click;
            cuiButton2.Click += btnDesactivarActivar_Click;
        }

        private void CargarCuentas()
        {
            try
            {
                _listaCuentas = _cuentaBLL.ObtenerTodas();
                MostrarEnGrid(_listaCuentas);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cuentas:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarEnGrid(List<Cuenta> cuentas)
        {
            dgvCuentas.Rows.Clear();

            foreach (Cuenta c in cuentas)
            {
                string saldoMostrar = c.ObtenerSaldoMostrar().ToString("N2");
                string estado = c.Estado ? "Activa" : "Inactiva";

                dgvCuentas.Rows.Add(
                    c.Id,
                    c.Nombre,
                    c.TipoCuenta,
                    c.Moneda,
                    saldoMostrar,
                    estado
                );
            }
        }
        private void MostrarPanelSegunTipo(string tipo)
        {
            // 1. Corte de seguridad: si el form o sus paneles ya murieron, no tocamos nada
            if (this.IsDisposed || !this.IsHandleCreated) return;
            if (cuiPanel6 == null || cuiPanel6.IsDisposed) return;
            if (cuiPanel7 == null || cuiPanel7.IsDisposed) return;

            bool esCredito = tipo == "Credito";

            // pnlDebito = cuiPanel6  |  pnlCredito = cuiPanel7
            cuiPanel6.Visible = !esCredito;
            cuiPanel7.Visible = esCredito;

            if (!esCredito)
            {
                // Limpiar campos de crédito al cambiar a otro tipo
                if (txtLimiteCredito != null && !txtLimiteCredito.IsDisposed)
                    txtLimiteCredito.Content = string.Empty;

                if (txtDeudaActual != null && !txtDeudaActual.IsDisposed)
                    txtDeudaActual.Content = string.Empty;

                if (txtDiaCorte != null && !txtDiaCorte.IsDisposed)
                    txtDiaCorte.Content = string.Empty;

                if (txtDiaPago != null && !txtDiaPago.IsDisposed)
                    txtDiaPago.Content = string.Empty;
            }
            else
            {
                // Limpiar saldo al cambiar a crédito
                if (cuiTextBox3 != null && !cuiTextBox3.IsDisposed)
                    cuiTextBox3.Content = string.Empty;
            }
        }

        #region Metodos Pra Buscar

        private void cmbTipoCuenta_SelectedItemChanged(object sender, EventArgs e)
        {
            if (!_formularioInicializado) return;
            if (this.IsDisposed || !this.IsHandleCreated) return;   // ← guard extra

            string tipo = cuiComboBox2.SelectedItem?.ToString() ?? string.Empty;
            MostrarPanelSegunTipo(tipo);
        }

        private void FiltrarCuentas()
        {
            string termino = cuiTextBox1.Content?.Trim() ?? string.Empty;
            string tipo = ComboboxBuscarPorTipo.SelectedItem?.ToString() ?? string.Empty;

            IEnumerable<ControlFinanzas.Entity.Entidades.Cuenta> consulta = _listaCuentas;

            if (!string.IsNullOrEmpty(termino))
            {
                consulta = consulta.Where(c => c.Nombre != null && c.Nombre.IndexOf(termino, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (!string.IsNullOrEmpty(tipo) && tipo != "Todos" && tipo != "Efectivo" && tipo != "Credito")
            {
                // Si el combo incluye opciones más allá de los tipos específicos, filtrar por coincidencia exacta.
                consulta = consulta.Where(c => c.TipoCuenta != null && c.TipoCuenta.Equals(tipo, StringComparison.OrdinalIgnoreCase));
            }
            else if (!string.IsNullOrEmpty(tipo) && (tipo == "Efectivo" || tipo == "Credito"))
            {
                // Filtrar por los tipos definidos en la entidad.
                consulta = consulta.Where(c => c.TipoCuenta != null && c.TipoCuenta.Equals(tipo, StringComparison.OrdinalIgnoreCase));
            }

            MostrarEnGrid(consulta.ToList());
        }

        private void txtBuscar_ContentChanged(object sender, EventArgs e)
        {
            string termino = cuiTextBox1.Content?.Trim() ?? string.Empty;

            if (string.IsNullOrEmpty(termino))
            {
                MostrarEnGrid(_listaCuentas);
            }
            else
            {
                try
                {
                    var resultados = _cuentaBLL.BuscarPorNombre(termino);
                    MostrarEnGrid(resultados);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error en búsqueda:\n{ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ComboboxBuscarPorTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarCuentas();
        }

        #endregion


        #region Metodos De mis Botones
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string tipo = cuiComboBox2.SelectedItem?.ToString() ?? string.Empty;
                string nombre = cuiTextBox2.Content?.Trim() ?? string.Empty;
                string moneda = cuiComboBox3.SelectedItem?.ToString() ?? string.Empty;
                bool estado = cuiCheckbox1.Checked;

                // Polimorfismo de creación: instancia la subclase correcta
                Cuenta cuenta;

                if (tipo == "Credito")
                {
                    if (!decimal.TryParse(txtLimiteCredito.Content, out decimal limite))
                        throw new ArgumentException("El Límite de Crédito debe ser un número válido.");

                    if (!decimal.TryParse(txtDeudaActual.Content, out decimal deuda))
                        throw new ArgumentException("La Deuda Actual debe ser un número válido.");

                    if (!int.TryParse(txtDiaCorte.Content, out int diaCorte))
                        throw new ArgumentException("El Día de Corte debe ser un número entero.");

                    if (!int.TryParse(txtDiaPago.Content, out int diaPago))
                        throw new ArgumentException("El Día de Pago debe ser un número entero.");

                    cuenta = new TarjetaCredito
                    {
                        LimiteCredito = limite,
                        DeudaActual = deuda,
                        DiaCorte = diaCorte,
                        DiaPago = diaPago
                    };
                }
                else
                {
                    if (!decimal.TryParse(cuiTextBox3.Content, out decimal saldo))
                        throw new ArgumentException("El Saldo Actual debe ser un número válido.");

                    cuenta = new CuentaDebito
                    {
                        SaldoActual = saldo
                    };
                }

                // Propiedades comunes
                cuenta.Id = _cuentaIdSeleccionada;
                // UsuarioId es forzado por CuentaBLL.Guardar() desde SesionUsuario
                cuenta.Nombre = nombre;
                cuenta.TipoCuenta = tipo;
                cuenta.Moneda = moneda;
                cuenta.Estado = estado;

                // Enviar a la BLL (valida y persiste)
                string resultado = _cuentaBLL.Guardar(cuenta);

                if (resultado == "OK")
                {
                    MessageBox.Show(
                        _cuentaIdSeleccionada == 0 ? "Cuenta creada exitosamente." : "Cuenta actualizada exitosamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormulario();
                    CargarCuentas();
                    CargarTarjetasKPI();
                }
                else
                {
                    MessageBox.Show(resultado, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCuentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cuenta de la lista para editar.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow fila = dgvCuentas.SelectedRows[0];
            _cuentaIdSeleccionada = Convert.ToInt32(fila.Cells["Column1"].Value);

            // Buscar el objeto en la lista en memoria para rellenar todos los campos
            Cuenta cuenta = _listaCuentas.Find(c => c.Id == _cuentaIdSeleccionada);
            if (cuenta == null)
            {
                MessageBox.Show("No se encontró la cuenta seleccionada.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Propiedades comunes
            cuiTextBox2.Content = cuenta.Nombre;
            cuiComboBox2.SelectedItem = cuenta.TipoCuenta;
            cuiComboBox3.SelectedItem = cuenta.Moneda;
            cuiCheckbox1.Checked = cuenta.Estado;

            MostrarPanelSegunTipo(cuenta.TipoCuenta);

            // Propiedades específicas por tipo
            if (cuenta is TarjetaCredito tc)
            {
                txtLimiteCredito.Content = tc.LimiteCredito.ToString("N2");
                txtDeudaActual.Content = tc.DeudaActual.ToString("N2");
                txtDiaCorte.Content = tc.DiaCorte.ToString();
                txtDiaPago.Content = tc.DiaPago.ToString();
            }
            else if (cuenta is CuentaDebito cd)
            {
                cuiTextBox3.Content = cd.SaldoActual.ToString("N2");
            }

            label3.Text = "Editando Cuenta";
        }

        private void btnDesactivarActivar_Click(object sender, EventArgs e)
        {
            if (dgvCuentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cuenta de la lista.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow fila = dgvCuentas.SelectedRows[0];
            int id = Convert.ToInt32(fila.Cells["Column1"].Value);
            string nombre = fila.Cells["Column2"].Value?.ToString() ?? "la cuenta";
            string estado = fila.Cells["Column6"].Value?.ToString() ?? "";

            string accion = estado == "Activa" ? "desactivar" : "activar";

            DialogResult confirm = MessageBox.Show(
                $"¿Desea {accion} la cuenta \"{nombre}\"?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                string resultado = _cuentaBLL.DesactivarActivar(id);

                if (resultado == "OK")
                {
                    MessageBox.Show($"Cuenta {accion}da exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarCuentas();
                }
                else
                {
                    MessageBox.Show(resultado, "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
        #endregion

        private void LimpiarFormulario()
        {
            _cuentaIdSeleccionada = 0;
            label3.Text = "Nueva Cuenta";

            cuiTextBox2.Content = string.Empty;
            cuiComboBox2.SelectedItem = "Efectivo";
            cuiComboBox3.SelectedItem = "USD";
            cuiCheckbox1.Checked = true;

            cuiTextBox3.Content = string.Empty;
            txtLimiteCredito.Content = string.Empty;
            txtDeudaActual.Content = string.Empty;
            txtDiaCorte.Content = string.Empty;
            txtDiaPago.Content = string.Empty;

            MostrarPanelSegunTipo("Efectivo");
        }

        #region DiseñoDataGrid
        private void ConfigurarEstiloGrid()
        {
            dgvCuentas.BorderStyle = BorderStyle.None;
            dgvCuentas.BackgroundColor = Color.White;
            dgvCuentas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCuentas.GridColor = Color.FromArgb(241, 245, 249);
            dgvCuentas.RowHeadersVisible = false;
            dgvCuentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCuentas.MultiSelect = false;
            dgvCuentas.AllowUserToAddRows = false;
            dgvCuentas.AllowUserToResizeRows = false;
            dgvCuentas.ReadOnly = true;
            dgvCuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCuentas.EnableHeadersVisualStyles = false;
            dgvCuentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCuentas.ColumnHeadersHeight = 42;
            dgvCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCuentas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 244, 248);
            dgvCuentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(51, 65, 85);
            dgvCuentas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvCuentas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvCuentas.RowTemplate.Height = 45;
            dgvCuentas.DefaultCellStyle.BackColor = Color.White;
            dgvCuentas.DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvCuentas.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dgvCuentas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dgvCuentas.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 41, 59);

            dgvCuentas.CellPainting += dgvCuentas_CellPainting;
            dgvCuentas.CellFormatting += dgvCuentas_CellFormatting;
        }

        private void dgvCuentas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCuentas.Columns[e.ColumnIndex].Name == "Column2" && e.Value != null)
            {
                e.CellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            }
        }


        private void dgvCuentas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCuentas.Columns[e.ColumnIndex].Name == "Column6")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                string estado = e.Value?.ToString() ?? "";

                Color backColor = estado == "Activa"
                    ? Color.FromArgb(220, 252, 231)
                    : Color.FromArgb(241, 245, 249);
                Color textColor = estado == "Activa"
                    ? Color.FromArgb(22, 101, 52)
                    : Color.FromArgb(71, 85, 105);

                int badgeWidth = 70;
                int badgeHeight = 24;
                int rectX = e.CellBounds.X + (e.CellBounds.Width - badgeWidth) / 2;
                int rectY = e.CellBounds.Y + (e.CellBounds.Height - badgeHeight) / 2;

                Rectangle badgeRect = new Rectangle(rectX, rectY, badgeWidth, badgeHeight);

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                using (GraphicsPath path = ObtenerRutaRedondeada(badgeRect, 12))
                using (SolidBrush brushFondo = new SolidBrush(backColor))
                using (SolidBrush brushTexto = new SolidBrush(textColor))
                {
                    e.Graphics.FillPath(brushFondo, path);
                    using (StringFormat sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    })
                    using (Font fontBadge = new Font("Segoe UI", 8.5F, FontStyle.Bold))
                    {
                        e.Graphics.DrawString(estado, fontBadge, brushTexto, badgeRect, sf);
                    }
                }

                e.Handled = true;
            }
        }
        private void cuiPanel3_Paint(object sender, PaintEventArgs e) { }
        private void cuiPanel4_Paint(object sender, PaintEventArgs e) { }

        private GraphicsPath ObtenerRutaRedondeada(Rectangle rect, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            int diametro = radio * 2;

            path.AddArc(rect.X, rect.Y, diametro, diametro, 180, 90);
            path.AddArc(rect.Right - diametro, rect.Y, diametro, diametro, 270, 90);
            path.AddArc(rect.Right - diametro, rect.Bottom - diametro, diametro, diametro, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diametro, diametro, diametro, 90, 90);
            path.CloseFigure();

            return path;
        }
        #endregion

        private void AplicarEstiloTarjetas()
        {
            // --- Tarjeta 1: Total Liquidez ---
            if (pnlCardLiquidez != null) pnlCardLiquidez.BackColor = Color.White;
            lblTituloLiquidez.Text = "Total Liquidez";
            lblTituloLiquidez.ForeColor = Color.FromArgb(100, 116, 139); // Gris (#64748B)
            lblTituloLiquidez.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            lblMontoLiquidez.ForeColor = Color.FromArgb(0, 150, 64);     // Verde (#009640)
            lblMontoLiquidez.Font = new Font("Segoe UI", 18F, FontStyle.Bold);

            // --- Tarjeta 2: Deuda en Crédito ---
            if (pnlCardDeuda != null) pnlCardDeuda.BackColor = Color.White;
            lblTituloDeuda.Text = "Deuda en Crédito";
            lblTituloDeuda.ForeColor = Color.FromArgb(100, 116, 139);
            lblTituloDeuda.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            lblMontoDeuda.ForeColor = Color.FromArgb(220, 38, 38);        // Rojo (#DC2626)
            lblMontoDeuda.Font = new Font("Segoe UI", 18F, FontStyle.Bold);

            // --- Tarjeta 3: Crédito Disponible ---
            if (pnlCardCredito != null) pnlCardCredito.BackColor = Color.White;
            lblTituloCredito.Text = "Crédito Disponible";
            lblTituloCredito.ForeColor = Color.FromArgb(100, 116, 139);
            lblTituloCredito.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            lblMontoCredito.ForeColor = Color.FromArgb(37, 99, 235);      // Azul (#2563EB)
            lblMontoCredito.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        }

        public void CargarTarjetasKPI()
        {
            try
            {
                ResumenCuentasDTO kpis = _cuentaService.ObtenerResumenKPIs(_usuarioIdLogueado);
                CultureInfo culturaUSD = new CultureInfo("en-US");

                lblMontoLiquidez.Text = $"USD {kpis.TotalLiquidez.ToString("N2", culturaUSD)}";
                lblMontoDeuda.Text = $"USD {kpis.TotalDeudaCredito.ToString("N2", culturaUSD)}";
                lblMontoCredito.Text = $"USD {kpis.TotalCreditoDisponible.ToString("N2", culturaUSD)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los KPIs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
