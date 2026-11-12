using ControlFinanzas.BLL;
using ControlFinanzas.DAL;
using ControlFinanzas.Entity.Entidades;
using ControlFinanzas.Entity.Sesion;
using CuoreUI.Controls;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlFinanzas.UI.Formularios
{
    public partial class FrmTransacciones : Form
    {
        #region Campos

        private readonly TransaccionBLL _transaccionBLL;
        private readonly CuentaDAO _cuentaDAO;
        private readonly CategoriaDAL _categoriaDAL;
        private readonly int _usuarioIdLogueado;

        private List<Cuenta> _cuentas = new();
        private List<CategoriaEntity> _categorias = new();
        private bool _cargando;

        // Tipos de movimiento
        private const string TIPO_INGRESO = "Ingreso";
        private const string TIPO_GASTO = "Gasto";
        private const string TIPO_TRANSFERENCIA = "Transferencia";

        #endregion

        #region Constructor
        public FrmTransacciones(int usuarioId)
        {
            InitializeComponent();

            _transaccionBLL = new TransaccionBLL(new TransaccionesDAL());
            _cuentaDAO = new CuentaDAO();
            _categoriaDAL = new CategoriaDAL();
            _usuarioIdLogueado = SesionUsuario.UsuarioId;

            ConfigurarDataGrid();
            InicializarControlesFormulario();
        }

        private async void FrmTransferencias_Load(object sender, EventArgs e)
        {
            ConectarEventos();
            await CargarDatosYListadoAsync();
        }

        #endregion

        #region Mis Metodos

        private void InicializarControlesFormulario()
        {
            _cargando = true;
            LimpiarCampos();
            _cargando = false;
        }

        private void LimpiarCampos()
        {
            cmbCuentaOrigen.SelectedIndex = -1;
            cmbCuentaDestino.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;
            txtMonto.Content = string.Empty;
            txtDescripcion.Content = string.Empty;
            dtpFecha.Content = DateTime.Now;
            lblSaldoOrigen.Text = "$ 0.00";
            lblSaldoDestino.Text = "$ 0.00";
            btnTransferir.Enabled = true;

            // Reajustar el modo visual al tipo seleccionado actualmente
            AjustarVistaPorTipo(ObtenerTipoSeleccionado());
        }

        private void ConectarEventos()
        {
            cmbTipoMoviento.SelectedIndexChanged += cmbTipoMoviento_SelectedIndexChanged;
            txtMonto.KeyPress += txtMonto_KeyPress;
        }

        private async Task CargarDatosYListadoAsync()
        {
            try
            {
                _cargando = true;

                var tareaCuentas = Task.Run(() => _cuentaDAO.ObtenerTodas(_usuarioIdLogueado));
                var tareaCategorias = _categoriaDAL.ObtenerConFiltroAsync(_usuarioIdLogueado, null, "Todas");

                await Task.WhenAll(tareaCuentas, tareaCategorias);

                _cuentas = tareaCuentas.Result ?? new List<Cuenta>();
                _categorias = tareaCategorias.Result ?? new List<CategoriaEntity>();

                LlenarComboCuentas(cmbCuentaOrigen);
                LlenarComboCuentas(cmbCuentaDestino);
                LlenarComboCuentas(cmbFiltrarCuenta, incluirTodas: true);

                // Ajustar categorías y vista según tipo de movimiento actual
                string tipoActual = ObtenerTipoSeleccionado();
                LlenarComboCategoriasPorTipo(tipoActual);
                AjustarVistaPorTipo(tipoActual);

                await CargarHistorialAsync(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Cargar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _cargando = false;
            }
        }

        public Task RecargarAsync() => CargarDatosYListadoAsync();

        #endregion

        #region Logica por Tipo de Movimiento

        /// <summary>
        /// Devuelve el tipo de movimiento actualmente seleccionado en el combo.
        /// </summary>
        private string ObtenerTipoSeleccionado()
        {
            if (cmbTipoMoviento.SelectedItem == null) return TIPO_TRANSFERENCIA;
            return cmbTipoMoviento.SelectedItem.ToString() ?? TIPO_TRANSFERENCIA;
        }
        
        //Me permite mostrar lso txt o combobox a usarse segun el tipo de transferencia
        private void AjustarVistaPorTipo(string tipo)
        {
            switch (tipo)
            {
                case TIPO_TRANSFERENCIA:
                    // Muestra origen y destino; oculta categoría
                    MostrarControl(label6, true);        // "Cuenta Origen"
                    MostrarControl(cmbCuentaOrigen, true);
                    MostrarControl(label5, true);        // "Cuenta Destino"
                    MostrarControl(cmbCuentaDestino, true);
                    MostrarControl(cuiPictureBox4, true);// icono flecha
                    MostrarControl(label7, false);       // "Categoría"
                    MostrarControl(cmbCategoria, false);

                    label3.Text = "Nueva Transferencia";
                    label6.Text = "Cuenta Origen";
                    label5.Text = "Cuenta Destino";
                    label9.Text = "Fecha de Transferencia";
                    btnTransferir.Content = "Transferir";
                    break;

                case TIPO_GASTO:
                    // Muestra origen (cuenta que paga) y categoría de gasto; oculta destino
                    MostrarControl(label6, true);
                    MostrarControl(cmbCuentaOrigen, true);
                    MostrarControl(label5, false);
                    MostrarControl(cmbCuentaDestino, false);
                    MostrarControl(cuiPictureBox4, false);
                    MostrarControl(label7, true);
                    MostrarControl(cmbCategoria, true);

                    label3.Text = "Registrar Gasto";
                    label6.Text = "Cuenta de Pago";
                    label9.Text = "Fecha del Gasto";
                    btnTransferir.Content = "Registrar Gasto";
                    break;

                case TIPO_INGRESO:
                    // Muestra destino (cuenta que recibe) y categoría de ingreso; oculta origen
                    MostrarControl(label6, false);
                    MostrarControl(cmbCuentaOrigen, false);
                    MostrarControl(label5, true);
                    MostrarControl(cmbCuentaDestino, true);
                    MostrarControl(cuiPictureBox4, false);
                    MostrarControl(label7, true);
                    MostrarControl(cmbCategoria, true);

                    label3.Text = "Registrar Ingreso";
                    label5.Text = "Cuenta que Recibe";
                    label9.Text = "Fecha del Ingreso";
                    btnTransferir.Content = "Registrar Ingreso";
                    break;
            }
        }

        private void MostrarControl(Control ctrl, bool visible)
        {
            if (ctrl != null) ctrl.Visible = visible;
        }

        /// Llena el combo de categorías filtrando por tipo (Ingreso/Gasto).
        /// Para Transferencia, se oculta el combo así que no importa.

        private void LlenarComboCategoriasPorTipo(string tipoMovimiento)
        {
            List<string> items = new List<string>();
            items.Add("Sin categoría");

            IEnumerable<CategoriaEntity> filtradas = tipoMovimiento == TIPO_INGRESO
                ? _categorias.Where(c => c.Estado && c.Tipo == "Ingreso")
                : _categorias.Where(c => c.Estado && c.Tipo == "Gasto");

            foreach (var cat in filtradas)
                items.Add(cat.Nombre);

            cmbCategoria.Items = items.ToArray();
            cmbCategoria.SelectedIndex = 0;
        }

        // Mantiene retrocompatibilidad con la carga inicial
        private void LlenarComboCategorias()
        {
            LlenarComboCategoriasPorTipo(ObtenerTipoSeleccionado());
        }

        #endregion

        #region Carga de Combos

        private void LlenarComboCuentas(CuoreUI.Controls.cuiComboBox combo, bool incluirTodas = false)
        {
            List<string> itemsTemporales = new List<string>();
            if (incluirTodas)
                itemsTemporales.Add("Todas las cuentas");

            foreach (var cuenta in _cuentas.Where(c => c.Estado))
                itemsTemporales.Add(cuenta.Nombre);
            combo.Items = itemsTemporales.ToArray();

            combo.SelectedIndex = incluirTodas ? 0 : -1;
        }

        #endregion

        #region Historial y KPIs

        private void CargarHistorial(List<HistorialTransaccionesDTO> historial)
        {
            dgvTransferencias.Rows.Clear();

            // Mostrar todos los movimientos de forma unificada
            foreach (var t in historial.OrderByDescending(h => h.Fecha))
            {
                string cuentaDestino = "—";

                // Si es Transferencia Salida, buscar su par de entrada
                if (t.TipoTransaccion == "Transferencia Salida")
                {
                    var espejo = historial.FirstOrDefault(h =>
                        h.TipoTransaccion == "Transferencia Entrada" &&
                        h.TransferenciaRefId.HasValue &&
                        h.TransferenciaRefId == t.TransferenciaRefId);
                    cuentaDestino = espejo?.Cuenta ?? "—";
                }
                else if (t.TipoTransaccion == "Transferencia Entrada")
                {
                    // Las entradas ya aparecen representadas en la fila de Salida, no duplicar
                    continue;
                }

                // Cuenta origen según tipo
                string cuentaOrigen = t.Cuenta;

                // Para Ingreso, la cuenta que recibe va en "Destino"
                if (t.TipoTransaccion == "Ingreso")
                {
                    cuentaDestino = t.Cuenta;
                    cuentaOrigen = "—";
                }

                string tipoDisplay = t.TipoTransaccion == "Transferencia Salida"
                    ? "Transferencia"
                    : t.TipoTransaccion;

                dgvTransferencias.Rows.Add(
                    t.Id,
                    cuentaOrigen,
                    cuentaDestino,
                    tipoDisplay,
                    t.Monto.ToString("C2"),
                    t.Descripcion,
                    t.Fecha.ToString("dd/MM/yyyy"),
                    t.Categoria
                );
            }
        }

        private void ActualizarKPIs(List<HistorialTransaccionesDTO> historial)
        {
            var ahora = DateTime.Now;

            decimal totalMes = historial
                .Where(h => h.TipoTransaccion == "Transferencia Salida"
                         && h.Fecha.Month == ahora.Month
                         && h.Fecha.Year == ahora.Year)
                .Sum(h => h.Monto);

            lblTotalTransferido.Text = totalMes.ToString("C2");
        }

        private async Task CargarHistorialAsync(int? cuentaIdFiltro)
        {
            try
            {
                List<HistorialTransaccionesDTO> historial;

                if (cuentaIdFiltro.HasValue && cuentaIdFiltro.Value > 0)
                    historial = await _transaccionBLL.ObtenerPorCuentaAsync(cuentaIdFiltro.Value, _usuarioIdLogueado);
                else
                    historial = await _transaccionBLL.ObtenerPorUsuarioAsync(_usuarioIdLogueado);

                CargarHistorial(historial);
                ActualizarKPIs(historial);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar el historial",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Eventos de seleccion

        private void cmbTipoMoviento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cargando) return;

            string tipo = ObtenerTipoSeleccionado();

            // Limpiar selecciones previas
            cmbCuentaOrigen.SelectedIndex = -1;
            cmbCuentaDestino.SelectedIndex = -1;
            lblSaldoOrigen.Text = "$ 0.00";
            lblSaldoDestino.Text = "$ 0.00";

            // Actualizar categorías filtradas por tipo
            if (tipo != TIPO_TRANSFERENCIA)
                LlenarComboCategoriasPorTipo(tipo);

            // Ajustar visibilidad de controles
            AjustarVistaPorTipo(tipo);
        }

        private void cmbCuentaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarSaldoOrigen();
        }

        private void cmbCuentaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarSaldoDestino();
        }

        private async void cmbFiltrarCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cargando) return;

            int? cuentaId = ObtenerCuentaIdDesdeCombo(cmbFiltrarCuenta);
            await CargarHistorialAsync(cuentaId);
        }

        private void ActualizarSaldoOrigen()
        {
            var cuenta = ObtenerCuentaDesdeCombo(cmbCuentaOrigen);
            lblSaldoOrigen.Text = cuenta != null
                ? ObtenerDisponibleCuenta(cuenta).ToString("C2")
                : "$ 0.00";
        }

        private void ActualizarSaldoDestino()
        {
            var cuenta = ObtenerCuentaDesdeCombo(cmbCuentaDestino);
            lblSaldoDestino.Text = cuenta != null
                ? ObtenerDisponibleCuenta(cuenta).ToString("C2")
                : "$ 0.00";
        }

        private decimal ObtenerDisponibleCuenta(Cuenta cuenta)
        {
            if (cuenta is TarjetaCredito tc)
                return tc.LimiteCredito - tc.DeudaActual;
            else if (cuenta is CuentaDebito cd)
                return cd.SaldoActual;

            return 0m;
        }

        #endregion

        #region Mis Botones

        private async void btnTransferir_Click(object sender, EventArgs e)
        {
            string tipo = ObtenerTipoSeleccionado();

            if (!ValidarFormulario(tipo, out string mensaje))
            {
                MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal monto = decimal.Parse(txtMonto.Content, NumberStyles.Currency, CultureInfo.CurrentCulture);
            string descripcion = txtDescripcion.Content?.Trim() ?? string.Empty;
            DateTime fecha = dtpFecha.Content;

            try
            {
                btnTransferir.Enabled = false;

                switch (tipo)
                {
                    case TIPO_TRANSFERENCIA:
                        await EjecutarTransferencia(monto, descripcion);
                        break;

                    case TIPO_GASTO:
                        await EjecutarGasto(monto, fecha, descripcion);
                        break;

                    case TIPO_INGRESO:
                        await EjecutarIngreso(monto, fecha, descripcion);
                        break;
                }

                LimpiarCampos();
                await CargarDatosYListadoAsync();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error de base de datos: {sqlEx.Message}", "Error SQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                btnTransferir.Enabled = true;
            }
        }

        /// <summary>Transfiere entre dos cuentas del usuario.</summary>
        private async Task EjecutarTransferencia(decimal monto, string descripcion)
        {
            var cuentaOrigen = ObtenerCuentaDesdeCombo(cmbCuentaOrigen)!;
            var cuentaDestino = ObtenerCuentaDesdeCombo(cmbCuentaDestino)!;

            var confirm = MessageBox.Show(
                $"¿Transferir {monto:C2} de '{cuentaOrigen.Nombre}' a '{cuentaDestino.Nombre}'?",
                "Confirmar Transferencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            await _transaccionBLL.EjecutarTransferenciaAsync(
                _usuarioIdLogueado,
                cuentaOrigen.Id,
                cuentaDestino.Id,
                monto,
                descripcion);

            MessageBox.Show("Transferencia realizada correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>Registra un gasto: descuenta de la cuenta origen hacia una categoría de gasto.</summary>
        private async Task EjecutarGasto(decimal monto, DateTime fecha, string descripcion)
        {
            var cuentaOrigen = ObtenerCuentaDesdeCombo(cmbCuentaOrigen)!;
            int? categoriaId = ObtenerCategoriaIdDesdeCombo();

            var confirm = MessageBox.Show(
                $"¿Registrar gasto de {monto:C2} desde '{cuentaOrigen.Nombre}'?",
                "Confirmar Gasto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            var transaccion = new TransaccionesEntity(
                cuentaId: cuentaOrigen.Id,
                categoriaId: categoriaId,
                tipoTransaccion: "Gasto",
                monto: monto,
                fecha: fecha,
                descripcion: descripcion);

            await _transaccionBLL.AgregarAsync(_usuarioIdLogueado, transaccion);

            MessageBox.Show("Gasto registrado correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>Registra un ingreso: acredita a la cuenta destino desde una categoría de ingreso.</summary>
        private async Task EjecutarIngreso(decimal monto, DateTime fecha, string descripcion)
        {
            var cuentaDestino = ObtenerCuentaDesdeCombo(cmbCuentaDestino)!;
            int? categoriaId = ObtenerCategoriaIdDesdeCombo();

            var confirm = MessageBox.Show(
                $"¿Registrar ingreso de {monto:C2} en '{cuentaDestino.Nombre}'?",
                "Confirmar Ingreso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            var transaccion = new TransaccionesEntity(
                cuentaId: cuentaDestino.Id,
                categoriaId: categoriaId,
                tipoTransaccion: "Ingreso",
                monto: monto,
                fecha: fecha,
                descripcion: descripcion);

            await _transaccionBLL.AgregarAsync(_usuarioIdLogueado, transaccion);

            MessageBox.Show("Ingreso registrado correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        #endregion

        #region Validaciones

        private bool ValidarFormulario(string tipo, out string mensaje)
        {
            mensaje = string.Empty;

            // Validar monto
            if (string.IsNullOrWhiteSpace(txtMonto.Content) ||
                !decimal.TryParse(txtMonto.Content, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal monto))
            {
                mensaje = "Debe ingresar un monto válido.";
                return false;
            }

            if (monto <= 0)
            {
                mensaje = "El monto debe ser mayor a cero.";
                return false;
            }

            switch (tipo)
            {
                case TIPO_TRANSFERENCIA:
                    var cuentaOrigen = ObtenerCuentaDesdeCombo(cmbCuentaOrigen);
                    if (cuentaOrigen == null)
                    {
                        mensaje = "Debe seleccionar una cuenta de origen.";
                        return false;
                    }

                    var cuentaDestino = ObtenerCuentaDesdeCombo(cmbCuentaDestino);
                    if (cuentaDestino == null)
                    {
                        mensaje = "Debe seleccionar una cuenta de destino.";
                        return false;
                    }

                    if (cuentaOrigen.Id == cuentaDestino.Id)
                    {
                        mensaje = "La cuenta de origen y destino no pueden ser la misma.";
                        return false;
                    }

                    if (monto > ObtenerDisponibleCuenta(cuentaOrigen))
                    {
                        mensaje = "El monto supera el saldo disponible en la cuenta de origen.";
                        return false;
                    }
                    break;

                case TIPO_GASTO:
                    var cuentaPago = ObtenerCuentaDesdeCombo(cmbCuentaOrigen);
                    if (cuentaPago == null)
                    {
                        mensaje = "Debe seleccionar la cuenta de pago.";
                        return false;
                    }

                    if (monto > ObtenerDisponibleCuenta(cuentaPago))
                    {
                        mensaje = "El monto supera el saldo disponible en la cuenta de pago.";
                        return false;
                    }
                    break;

                case TIPO_INGRESO:
                    var cuentaRecibe = ObtenerCuentaDesdeCombo(cmbCuentaDestino);
                    if (cuentaRecibe == null)
                    {
                        mensaje = "Debe seleccionar la cuenta que recibirá el ingreso.";
                        return false;
                    }
                    break;
            }

            return true;
        }

        #endregion

        #region Helpers

        private Cuenta? ObtenerCuentaDesdeCombo(cuiComboBox combo)
        {
            if (combo.SelectedIndex < 0 || combo.SelectedItem == null) return null;

            string nombre = combo.SelectedItem.ToString()!;
            return _cuentas.FirstOrDefault(c => c.Nombre == nombre && c.Estado);
        }

        private int? ObtenerCuentaIdDesdeCombo(cuiComboBox combo)
        {
            if (combo.SelectedIndex <= 0 || combo.SelectedItem == null) return null;

            string nombre = combo.SelectedItem.ToString()!;
            return _cuentas.FirstOrDefault(c => c.Nombre == nombre)?.Id;
        }


        /// Obtiene el Id de la categoría seleccionada en cmbCategoria.
        /// Devuelve null si se eligió "Sin categoría".
        private int? ObtenerCategoriaIdDesdeCombo()
        {
            if (cmbCategoria.SelectedIndex <= 0 || cmbCategoria.SelectedItem == null)
                return null;

            string nombreCat = cmbCategoria.SelectedItem.ToString()!;
            return _categorias.FirstOrDefault(c => c.Nombre == nombreCat && c.Estado)?.Id;
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
                e.Handled = true;
        }

        #endregion

        #region Estilo de DataGrid

        private void ConfigurarDataGrid()
        {
            // Actualizar labels del formulario al inicializar
            label1.Text = "Gestión de Movimientos";
            label2.Text = "Registra ingresos, gastos y transferencias entre tus cuentas.";
            label16.Text = "Historial de Movimientos";

            dgvTransferencias.BorderStyle = BorderStyle.None;
            dgvTransferencias.BackgroundColor = Color.White;
            dgvTransferencias.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTransferencias.GridColor = Color.FromArgb(241, 245, 249);
            dgvTransferencias.RowHeadersVisible = false;
            dgvTransferencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransferencias.MultiSelect = false;
            dgvTransferencias.AllowUserToAddRows = false;
            dgvTransferencias.AllowUserToResizeRows = false;
            dgvTransferencias.ReadOnly = true;
            dgvTransferencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvTransferencias.EnableHeadersVisualStyles = false;
            dgvTransferencias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTransferencias.ColumnHeadersHeight = 42;
            dgvTransferencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTransferencias.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 244, 248);
            dgvTransferencias.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(51, 65, 85);
            dgvTransferencias.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvTransferencias.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvTransferencias.RowTemplate.Height = 45;
            dgvTransferencias.DefaultCellStyle.BackColor = Color.White;
            dgvTransferencias.DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvTransferencias.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dgvTransferencias.DefaultCellStyle.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dgvTransferencias.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 41, 59);

            // Agregar columna de Id oculto y columna de Tipo si no están ya
            if (dgvTransferencias.Columns.Count == 6)
            {
                dgvTransferencias.Columns.Insert(0, new DataGridViewTextBoxColumn
                {
                    Name = "IdInterno",
                    Visible = false
                });

                // Insertar columna "Tipo" entre Cuenta Destino y Monto (posición 3)
                dgvTransferencias.Columns.Insert(3, new DataGridViewTextBoxColumn
                {
                    Name = "Tipo",
                    HeaderText = "Tipo"
                });
            }

            dgvTransferencias.CellPainting += dgvTransferencias_CellPainting;
        }

        private void dgvTransferencias_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Columna Monto (índice 4 con la nueva columna Tipo)
            if (e.ColumnIndex == 4 && e.Value != null)
            {
                e.CellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                e.CellStyle.ForeColor = Color.FromArgb(15, 118, 110);
                return;
            }

            // Columna Tipo (índice 3): pintar badge con color según tipo
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                string tipo = e.Value.ToString()!;
                if (string.IsNullOrWhiteSpace(tipo)) return;

                (Color bg, Color fg) = tipo switch
                {
                    "Ingreso" => (ColorTranslator.FromHtml("#DCFCE7"), ColorTranslator.FromHtml("#166534")),
                    "Gasto" => (ColorTranslator.FromHtml("#FEE2E2"), ColorTranslator.FromHtml("#991B1B")),
                    _ => (ColorTranslator.FromHtml("#DBEAFE"), ColorTranslator.FromHtml("#1D4ED8"))   // Transferencia
                };

                e.PaintBackground(e.CellBounds, true);
                DibujarBadge(e, tipo, bg, fg);
                e.Handled = true;
                return;
            }

            // Columna Categoría (índice 7 con las columnas extra)
            if (e.ColumnIndex == 7 && e.Value != null)
            {
                string categoria = e.Value.ToString()!;
                if (string.IsNullOrWhiteSpace(categoria)) return;

                e.PaintBackground(e.CellBounds, true);
                DibujarBadge(e, categoria,
                    ColorTranslator.FromHtml("#E0E7FF"),
                    ColorTranslator.FromHtml("#3730A3"));
                e.Handled = true;
            }
        }

        private void DibujarBadge(DataGridViewCellPaintingEventArgs e, string texto, Color bgColor, Color txtColor)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            SizeF textSize = e.Graphics.MeasureString(texto, e.CellStyle.Font);
            int badgeWidth = (int)textSize.Width + 20;
            int badgeHeight = (int)textSize.Height + 10;
            int x = e.CellBounds.X + (e.CellBounds.Width - badgeWidth) / 2;
            int y = e.CellBounds.Y + (e.CellBounds.Height - badgeHeight) / 2;
            Rectangle rect = new Rectangle(x, y, badgeWidth, badgeHeight);

            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 10;
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();
                using (SolidBrush b = new SolidBrush(bgColor))
                    e.Graphics.FillPath(b, path);
            }

            using (SolidBrush b = new SolidBrush(txtColor))
            {
                StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                e.Graphics.DrawString(texto, new Font("Segoe UI", 8.5F, FontStyle.Bold), b, rect, sf);
            }
        }

        #endregion
    }
}
