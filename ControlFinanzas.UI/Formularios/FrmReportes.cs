using ControlFinanzas.BLL;
using ControlFinanzas.Entity.Entidades;
using ControlFinanzas.Entity.ObjetosTransferenciaDatos;
using ControlFinanzas.Entity.Sesion;
using ControlFinanzas.UI.Reportes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlFinanzas.UI.Formularios
{
    // Formulario de reportes con tres pestañas: Movimientos, Categorías y Cuentas
    public partial class FrmReportes : Form
    {
        // Instancia de la lógica de negocio de reportes
        private readonly ReportesBLL _bll = new ReportesBLL();

        // Instancia de la lógica de cuentas para cargar el combo de filtros
        private readonly CuentaBLL _cuentaBll = new CuentaBLL();

        // Listas con los datos actuales mostrados en cada grilla
        // Se guardan para poder exportar sin volver a consultar la BD
        private List<ReporteMovimientoDTO> _datosMovimientos = new();
        private ReporteMovimientosResumenDTO _resumenMovimientos = new();
        private List<ReporteGastoCategoriaDTO> _datosCategorias = new();
        private List<ReporteEstadoCuentaDTO> _datosCuentas = new();

        // Lista de cuentas del usuario, se usa para obtener el Id por posición en el combo
        private List<CuentaEntity> _cuentasUsuario = new();

        public FrmReportes()
        {
            InitializeComponent();
            ConfigurarEstilosGrillas();
            ConfigurarEventos();
        }

        // Configura los estilos modernos y elegantes para las tres grillas de los reportes
        private void ConfigurarEstilosGrillas()
        {
            // Aplicar estilo base compartido a los tres DataGridViews
            EstilarGrillaBase(dgvReporteMovimientos);
            EstilarGrillaBase(dgvReporteCategorias);
            EstilarGrillaBase(dgvReporteCuentas);

            // Ajustes específicos de columnas para Movimientos
            colFecha.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colFecha.FillWeight = 85;

            colTipo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colTipo.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colTipo.FillWeight = 90;

            colOrigen.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colOrigen.FillWeight = 110;

            colDestino.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colDestino.FillWeight = 110;

            colDescripcion.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colDescripcion.FillWeight = 140;

            colMonto.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colMonto.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            colMonto.FillWeight = 95;

            // Ajustes específicos de columnas para Categorías
            colCatNombre.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colCatNombre.FillWeight = 135;

            colCatTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCatTotal.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCatTotal.FillWeight = 95;

            colCatPorcentaje.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCatPorcentaje.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCatPorcentaje.FillWeight = 80;

            colCatCantidad.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCatCantidad.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCatCantidad.FillWeight = 75;

            colCatPromedio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCatPromedio.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCatPromedio.FillWeight = 95;

            // Ajustes específicos de columnas para Cuentas
            colCuentaNombre.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colCuentaNombre.FillWeight = 125;

            colCuentaTipo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCuentaTipo.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCuentaTipo.FillWeight = 85;

            colCuentaMoneda.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCuentaMoneda.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCuentaMoneda.FillWeight = 60;

            colCuentaSaldo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCuentaSaldo.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCuentaSaldo.FillWeight = 90;

            colCuentaLimite.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCuentaLimite.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCuentaLimite.FillWeight = 90;

            colCuentaDeuda.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCuentaDeuda.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCuentaDeuda.FillWeight = 90;

            colCuentaDisponible.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCuentaDisponible.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCuentaDisponible.FillWeight = 90;

            // Eventos de pintado personalizado para renderizar badges y viñetas modernas
            dgvReporteMovimientos.CellPainting += DgvReporteMovimientos_CellPainting;
            dgvReporteCategorias.CellPainting  += DgvReporteCategorias_CellPainting;
            dgvReporteCuentas.CellPainting     += DgvReporteCuentas_CellPainting;
        }

        // Aplica el diseño base limpio, moderno y espacioso a un DataGridView
        private void EstilarGrillaBase(DataGridView dgv)
        {
            // Habilitar doble buffer por reflexión para evitar parpadeos al hacer scroll
            typeof(DataGridView).InvokeMember(
                "DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, dgv, new object[] { true });

            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(241, 245, 249); // Línea divisoria gris pizarra suave
            dgv.BackgroundColor = Color.White;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Encabezados modernos planos y espaciosos
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersHeight = 44;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(71, 85, 105); // Pizarra 600
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 8, 0);

            // Filas altas, cómodas y legibles
            dgv.RowTemplate.Height = 42;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59); // Pizarra 800
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dgv.DefaultCellStyle.Padding = new Padding(6, 0, 6, 0);

            // Selección suave en azul claro en lugar del azul oscuro anticuado
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(15, 23, 42);

            // Alternancia de filas sutil para facilitar la lectura
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 252, 255);
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(15, 23, 42);
        }

        // Pintado personalizado de celdas en el reporte de Movimientos
        private void DgvReporteMovimientos_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Columna Tipo (índice 1): Dibuja un badge / píldora redondeada moderna
            if (e.ColumnIndex == 1 && e.Value != null)
            {
                string tipo = e.Value.ToString()!;
                if (string.IsNullOrWhiteSpace(tipo)) return;

                Color bgBadge, txtBadge;
                if (tipo == "Ingreso")
                {
                    bgBadge  = Color.FromArgb(220, 252, 231); // Verde suave
                    txtBadge = Color.FromArgb(22, 101, 52);   // Verde oscuro
                }
                else if (tipo == "Gasto")
                {
                    bgBadge  = Color.FromArgb(254, 226, 226); // Rojo suave
                    txtBadge = Color.FromArgb(153, 27, 27);   // Rojo oscuro
                }
                else
                {
                    bgBadge  = Color.FromArgb(219, 234, 254); // Azul suave
                    txtBadge = Color.FromArgb(30, 64, 175);   // Azul oscuro
                }

                DibujarPildoraBadge(e, tipo, bgBadge, txtBadge);
                return;
            }

            // Columna Monto (índice 5): Aplica tipografía destacada y color según el tipo
            if (e.ColumnIndex == 5 && e.Value != null)
            {
                var row = dgvReporteMovimientos.Rows[e.RowIndex];
                string tipo = row.Cells[1].Value?.ToString() ?? "";

                if (tipo == "Ingreso")
                    e.CellStyle.ForeColor = Color.FromArgb(22, 163, 74); // Verde
                else if (tipo == "Gasto")
                    e.CellStyle.ForeColor = Color.FromArgb(220, 38, 38); // Rojo
                else
                    e.CellStyle.ForeColor = Color.FromArgb(37, 99, 235); // Azul

                e.CellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            }
        }

        // Pintado personalizado de celdas en el reporte de Categorías
        private void DgvReporteCategorias_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Columna Categoría (índice 0): Dibuja un punto de color moderno alineado con el texto
            if (e.ColumnIndex == 0 && e.Value != null && e.RowIndex < _datosCategorias.Count)
            {
                e.PaintBackground(e.CellBounds, true);

                string colorHex = _datosCategorias[e.RowIndex].ColorHex;
                Color colorPunto;
                try
                {
                    colorPunto = ColorTranslator.FromHtml(string.IsNullOrWhiteSpace(colorHex) ? "#3B82F6" : colorHex);
                }
                catch
                {
                    colorPunto = Color.FromArgb(59, 130, 246);
                }

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                int dotSize = 10;
                int dotX    = e.CellBounds.X + 10;
                int dotY    = e.CellBounds.Y + (e.CellBounds.Height - dotSize) / 2;

                using (SolidBrush dotBrush = new SolidBrush(colorPunto))
                {
                    e.Graphics.FillEllipse(dotBrush, dotX, dotY, dotSize, dotSize);
                }

                // Dibuja el texto del nombre al lado del punto de color
                string texto = e.Value.ToString() ?? "";
                Rectangle rectTexto = new Rectangle(dotX + dotSize + 8, e.CellBounds.Y, e.CellBounds.Width - (dotSize + 22), e.CellBounds.Height);
                using (SolidBrush textBrush = new SolidBrush(e.CellStyle.ForeColor))
                using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center })
                {
                    e.Graphics.DrawString(texto, e.CellStyle.Font, textBrush, rectTexto, sf);
                }

                e.Handled = true;
                return;
            }

            // Columna Total Gastado (índice 1): Negrita en tono rojo corporativo
            if (e.ColumnIndex == 1 && e.Value != null)
            {
                e.CellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                e.CellStyle.ForeColor = Color.FromArgb(220, 38, 38);
                return;
            }

            // Columna Porcentaje (índice 2): Badge suave índigo
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                string texto = e.Value.ToString()!;
                DibujarPildoraBadge(e, texto, Color.FromArgb(238, 242, 255), Color.FromArgb(67, 56, 202));
                return;
            }

            // Columna Cantidad (índice 3): Formato centrado limpio
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.CellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                e.CellStyle.ForeColor = Color.FromArgb(71, 85, 105);
            }
        }

        // Pintado personalizado de celdas en el reporte de Cuentas
        private void DgvReporteCuentas_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Columna Nombre (índice 0): Resaltar en negrita suave
            if (e.ColumnIndex == 0 && e.Value != null)
            {
                e.CellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                return;
            }

            // Columna Tipo (índice 1): Badge redondeado diferenciando Crédito y Débito
            if (e.ColumnIndex == 1 && e.Value != null)
            {
                string tipo = e.Value.ToString()!;
                Color bg, fg;

                if (tipo.IndexOf("Crédito", StringComparison.OrdinalIgnoreCase) >= 0 || tipo.IndexOf("Credito", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    bg = Color.FromArgb(254, 243, 199); // Ámbar suave
                    fg = Color.FromArgb(146, 64, 14);   // Ámbar oscuro
                }
                else if (tipo.IndexOf("Débito", StringComparison.OrdinalIgnoreCase) >= 0 || tipo.IndexOf("Debito", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    bg = Color.FromArgb(219, 234, 254); // Azul suave
                    fg = Color.FromArgb(30, 64, 175);   // Azul oscuro
                }
                else
                {
                    bg = Color.FromArgb(243, 232, 255); // Púrpura suave
                    fg = Color.FromArgb(107, 33, 168);  // Púrpura oscuro
                }

                DibujarPildoraBadge(e, tipo, bg, fg);
                return;
            }

            // Columna Moneda (índice 2): Badge gris moderno
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                string moneda = e.Value.ToString()!;
                DibujarPildoraBadge(e, moneda, Color.FromArgb(241, 245, 249), Color.FromArgb(71, 85, 105));
                return;
            }

            // Columna Saldo Actual (índice 3): Verde si >= 0, Rojo si negativo
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.CellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                string texto = e.Value.ToString()!;
                e.CellStyle.ForeColor = texto.StartsWith("-")
                    ? Color.FromArgb(220, 38, 38)
                    : Color.FromArgb(22, 163, 74);
                return;
            }

            // Columna Deuda (índice 5): Resaltado en rojo si tiene deuda activa
            if (e.ColumnIndex == 5 && e.Value != null)
            {
                string deuda = e.Value.ToString()!;
                if (deuda != "—" && !string.IsNullOrWhiteSpace(deuda))
                {
                    e.CellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                    e.CellStyle.ForeColor = Color.FromArgb(220, 38, 38);
                }
                else
                {
                    e.CellStyle.ForeColor = Color.FromArgb(148, 163, 184);
                }
                return;
            }

            // Columna Crédito Disponible (índice 6): Resaltado en esmeralda
            if (e.ColumnIndex == 6 && e.Value != null)
            {
                string disp = e.Value.ToString()!;
                if (disp != "—" && !string.IsNullOrWhiteSpace(disp))
                {
                    e.CellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                    e.CellStyle.ForeColor = Color.FromArgb(5, 150, 105);
                }
                else
                {
                    e.CellStyle.ForeColor = Color.FromArgb(148, 163, 184);
                }
            }
        }

        // Dibuja una píldora o badge moderno centrado dentro de una celda
        private void DibujarPildoraBadge(DataGridViewCellPaintingEventArgs e, string texto, Color bgColor, Color txtColor)
        {
            e.PaintBackground(e.CellBounds, true);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (Font font = new Font("Segoe UI", 8.5F, FontStyle.Bold))
            {
                SizeF textSize = e.Graphics.MeasureString(texto, font);
                int badgeWidth  = Math.Max((int)textSize.Width + 16, 52);
                int badgeHeight = (int)textSize.Height + 6;

                int x = e.CellBounds.X + (e.CellBounds.Width - badgeWidth) / 2;
                int y = e.CellBounds.Y + (e.CellBounds.Height - badgeHeight) / 2;
                Rectangle rect = new Rectangle(x, y, badgeWidth, badgeHeight);

                using (GraphicsPath path = new GraphicsPath())
                {
                    int radius = badgeHeight / 2;
                    path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
                    path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
                    path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
                    path.CloseFigure();

                    using (SolidBrush b = new SolidBrush(bgColor))
                        e.Graphics.FillPath(b, path);
                }

                using (SolidBrush b = new SolidBrush(txtColor))
                using (StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                })
                {
                    e.Graphics.DrawString(texto, font, b, rect, sf);
                }
            }

            e.Handled = true;
        }

        // Suscribe los eventos de los controles del formulario
        private void ConfigurarEventos()
        {
            this.Load                    += FrmReportes_Load;
            btnFiltrarMovimientos.Click  += BtnFiltrarMovimientos_Click;
            btnExportarMovimientos.Click += BtnExportarMovimientos_Click;
            btnFiltrarCat.Click          += BtnFiltrarCat_Click;
            btnExportarCat.Click         += BtnExportarCat_Click;
            btnRefrescarCuentas.Click    += BtnRefrescarCuentas_Click;
            btnExportarCuentas.Click     += BtnExportarCuentas_Click;
        }

        // Al cargar el formulario inicializa fechas, carga los combos y lanza la primera consulta
        private async void FrmReportes_Load(object sender, EventArgs e)
        {
            // Fechas por defecto: primer y último día del mes actual
            DateTime hoy       = DateTime.Today;
            DateTime inicioMes = new DateTime(hoy.Year, hoy.Month, 1);
            DateTime finMes    = inicioMes.AddMonths(1).AddDays(-1);

            // cuiCalendarDatePicker usa la propiedad Content
            dtpDesdeMovimientos.Content = inicioMes;
            dtpHastaMovimientos.Content = finMes;
            dtpDesdeCat.Content         = inicioMes;
            dtpHastaCat.Content         = finMes;

            // cuiComboBox usa Items como string[]
            cmbTipoMovimiento.Items = new string[]
            {
                "Todos",
                "Ingreso",
                "Gasto",
                "Transferencia"
            };
            cmbTipoMovimiento.SelectedIndex = 0;

            // Carga las cuentas del usuario y llena ambos combos de filtro
            await CargarCuentasUsuarioAsync();

            // Carga inicial de los tres reportes
            await CargarMovimientosAsync();
            await CargarCategoriasAsync();
            await CargarEstadoCuentasAsync();
        }

        // Obtiene la lista de cuentas y llena los dos combos de filtro de cuenta
        private async Task CargarCuentasUsuarioAsync()
        {
            try
            {
                _cuentasUsuario = await Task.Run(() => _cuentaBll.ObtenerTodas());

                var nombres = new List<string> { "Todas las cuentas" };
                foreach (var c in _cuentasUsuario)
                    nombres.Add(c.Nombre);

                cmbCuentasMovimientos.Items = nombres.ToArray();
                cmbCuentasCat.Items         = nombres.ToArray();

                cmbCuentasMovimientos.SelectedIndex = 0;
                cmbCuentasCat.SelectedIndex         = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando cuentas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Devuelve el Id de la cuenta seleccionada en un combo o null si es "Todas las cuentas"
        private int? ObtenerCuentaIdSeleccionada(CuoreUI.Controls.cuiComboBox combo)
        {
            int idx = combo.SelectedIndex;
            if (idx <= 0) return null;

            int indexReal = idx - 1;
            if (indexReal >= 0 && indexReal < _cuentasUsuario.Count)
                return _cuentasUsuario[indexReal].Id;

            return null;
        }

        // ==================== PESTAÑA 1 — MOVIMIENTOS ====================

        // Lanza la consulta de movimientos con los filtros actuales y muestra los resultados
        private async Task CargarMovimientosAsync()
        {
            try
            {
                HabilitarControlesMovimientos(false);

                DateTime desde        = dtpDesdeMovimientos.Content.Date;
                DateTime hasta        = dtpHastaMovimientos.Content.Date;
                string tipoMovimiento = cmbTipoMovimiento.SelectedItem?.ToString() ?? "Todos";
                int? cuentaId         = ObtenerCuentaIdSeleccionada(cmbCuentasMovimientos);

                _datosMovimientos = await _bll.ObtenerMovimientosAsync(
                    SesionUsuario.UsuarioId, desde, hasta, tipoMovimiento, cuentaId);

                _resumenMovimientos = _bll.CalcularResumenMovimientos(_datosMovimientos);

                // Actualiza las tarjetas KPI
                lblTotalIngresosRep.Text    = _resumenMovimientos.TotalIngresos.ToString("C2");
                lblTotalGastosRep.Text      = _resumenMovimientos.TotalGastos.ToString("C2");
                lblFlujoNetoRep.Text        = _resumenMovimientos.FlujoNeto.ToString("C2");
                lblTotalTransferidoRep.Text = _resumenMovimientos.TotalTransferido.ToString("C2");

                // Color del flujo neto: verde si positivo, rojo si negativo
                lblFlujoNetoRep.ForeColor = _resumenMovimientos.FlujoNeto >= 0
                    ? Color.FromArgb(22, 163, 74)
                    : Color.FromArgb(220, 38, 38);

                MostrarMovimientosEnGrid(_datosMovimientos);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Rango de fechas inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar movimientos:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                HabilitarControlesMovimientos(true);
            }
        }

        // Llena la grilla de movimientos con la lista recibida
        private void MostrarMovimientosEnGrid(List<ReporteMovimientoDTO> lista)
        {
            dgvReporteMovimientos.Rows.Clear();

            foreach (var item in lista)
            {
                dgvReporteMovimientos.Rows.Add(
                    item.Fecha.ToString("dd/MM/yyyy"),
                    item.TipoMovimiento,
                    item.CuentaOrigen,
                    item.DestinoOCategoria,
                    item.Descripcion,
                    item.Monto.ToString("C2"));
            }
        }

        // Bloquea o desbloquea los botones mientras se consulta la BD
        private void HabilitarControlesMovimientos(bool habilitar)
        {
            btnFiltrarMovimientos.Enabled  = habilitar;
            btnExportarMovimientos.Enabled = habilitar;
        }

        // Evento del botón "Filtrar" de la pestaña Movimientos
        private async void BtnFiltrarMovimientos_Click(object sender, EventArgs e)
        {
            await CargarMovimientosAsync();
        }

        // Evento del botón "Exportar PDF" de la pestaña Movimientos
        private void BtnExportarMovimientos_Click(object sender, EventArgs e)
        {
            if (_datosMovimientos.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar. Aplique los filtros primero.",
                    "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string? ruta = PedirRutaGuardado("Reporte_Movimientos");
            if (ruta == null) return;

            try
            {
                string desde       = dtpDesdeMovimientos.Content.ToString("dd/MM/yyyy");
                string hasta       = dtpHastaMovimientos.Content.ToString("dd/MM/yyyy");
                string tipoFiltro  = cmbTipoMovimiento.SelectedItem?.ToString() ?? "Todos";
                string cuentaFiltro = cmbCuentasMovimientos.SelectedItem?.ToString() ?? "Todas las cuentas";

                GeneradorPDFReportes.GenerarPDFMovimientos(
                    _datosMovimientos, _resumenMovimientos,
                    desde, hasta, tipoFiltro, cuentaFiltro,
                    SesionUsuario.Nombre, ruta);

                OfrecerAbrirPDF(ruta);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==================== PESTAÑA 2 — CATEGORÍAS ====================

        // Consulta y muestra el desglose de gastos por categoría
        private async Task CargarCategoriasAsync()
        {
            try
            {
                HabilitarControlesCategorias(false);

                DateTime desde = dtpDesdeCat.Content.Date;
                DateTime hasta = dtpHastaCat.Content.Date;
                int? cuentaId  = ObtenerCuentaIdSeleccionada(cmbCuentasCat);

                _datosCategorias = await _bll.ObtenerGastosPorCategoriaAsync(
                    SesionUsuario.UsuarioId, desde, hasta, cuentaId);

                var (totalGastado, topCat, totalTransacciones) =
                    _bll.CalcularResumenCategorias(_datosCategorias);

                // Actualiza las tarjetas KPI de la pestaña categorías
                lblTotalGastoCatRep.Text        = totalGastado.ToString("C2");
                lblTotalGastadoCategoriaTo.Text = totalGastado.ToString("C2");
                lblTopCategoriaRep.Text         = topCat;
                lblNumTransaccionesCatRep.Text  = totalTransacciones.ToString();

                MostrarCategoriasEnGrid(_datosCategorias);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Rango de fechas inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                HabilitarControlesCategorias(true);
            }
        }

        // Llena la grilla de categorías
        private void MostrarCategoriasEnGrid(List<ReporteGastoCategoriaDTO> lista)
        {
            dgvReporteCategorias.Rows.Clear();

            for (int i = 0; i < lista.Count; i++)
            {
                var cat = lista[i];
                dgvReporteCategorias.Rows.Add(
                    cat.Categoria,
                    cat.TotalGastado.ToString("C2"),
                    $"{cat.Porcentaje:F1}%",
                    cat.CantidadTransacciones,
                    cat.PromedioPorTransaccion.ToString("C2"));
            }
        }

        // Bloquea o desbloquea los botones de la pestaña categorías
        private void HabilitarControlesCategorias(bool habilitar)
        {
            btnFiltrarCat.Enabled  = habilitar;
            btnExportarCat.Enabled = habilitar;
        }

        // Evento del botón "Filtrar" de la pestaña Categorías
        private async void BtnFiltrarCat_Click(object sender, EventArgs e)
        {
            await CargarCategoriasAsync();
        }

        // Evento del botón "Exportar PDF" de la pestaña Categorías
        private void BtnExportarCat_Click(object sender, EventArgs e)
        {
            if (_datosCategorias.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar. Aplique los filtros primero.",
                    "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string? ruta = PedirRutaGuardado("Reporte_Categorias");
            if (ruta == null) return;

            try
            {
                string desde = dtpDesdeCat.Content.ToString("dd/MM/yyyy");
                string hasta = dtpHastaCat.Content.ToString("dd/MM/yyyy");

                GeneradorPDFReportes.GenerarPDFGastosCategorias(
                    _datosCategorias, desde, hasta, SesionUsuario.Nombre, ruta);

                OfrecerAbrirPDF(ruta);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==================== PESTAÑA 3 — CUENTAS ====================

        // Consulta y muestra el estado actual de todas las cuentas del usuario
        private async Task CargarEstadoCuentasAsync()
        {
            try
            {
                HabilitarControlesCuentas(false);

                _datosCuentas = await _bll.ObtenerEstadoCuentasAsync(SesionUsuario.UsuarioId);

                var (liquidez, deuda, patrimonio) = _bll.CalcularTotalesCuentas(_datosCuentas);

                // Actualiza las tarjetas KPI de la pestaña cuentas
                lblLiquidezTotalRep.Text  = liquidez.ToString("C2");
                lblDeudaTotalRep.Text     = deuda.ToString("C2");
                lblPatrimonioNetoRep.Text = patrimonio.ToString("C2");

                // Color del patrimonio: verde si positivo, rojo si negativo
                lblPatrimonioNetoRep.ForeColor = patrimonio >= 0
                    ? Color.FromArgb(22, 163, 74)
                    : Color.FromArgb(220, 38, 38);

                MostrarCuentasEnGrid(_datosCuentas);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cuentas:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                HabilitarControlesCuentas(true);
            }
        }

        // Llena la grilla de cuentas
        private void MostrarCuentasEnGrid(List<ReporteEstadoCuentaDTO> lista)
        {
            dgvReporteCuentas.Rows.Clear();

            for (int i = 0; i < lista.Count; i++)
            {
                var c = lista[i];
                dgvReporteCuentas.Rows.Add(
                    c.Nombre,
                    c.TipoCuenta,
                    c.Moneda,
                    c.SaldoActual.ToString("C2"),
                    c.LimiteCredito   > 0 ? c.LimiteCredito.ToString("C2")    : "—",
                    c.DeudaActual     > 0 ? c.DeudaActual.ToString("C2")      : "—",
                    c.CreditoDisponible > 0 ? c.CreditoDisponible.ToString("C2") : "—");
            }
        }

        // Bloquea o desbloquea los botones de la pestaña cuentas
        private void HabilitarControlesCuentas(bool habilitar)
        {
            btnRefrescarCuentas.Enabled = habilitar;
            btnExportarCuentas.Enabled  = habilitar;
        }

        // Evento del botón "Actualizar" de la pestaña Cuentas
        private async void BtnRefrescarCuentas_Click(object sender, EventArgs e)
        {
            await CargarEstadoCuentasAsync();
        }

        // Evento del botón "Exportar PDF" de la pestaña Cuentas
        private void BtnExportarCuentas_Click(object sender, EventArgs e)
        {
            if (_datosCuentas.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.",
                    "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string? ruta = PedirRutaGuardado("Reporte_EstadoCuentas");
            if (ruta == null) return;

            try
            {
                GeneradorPDFReportes.GenerarPDFEstadoCuentas(
                    _datosCuentas, SesionUsuario.Nombre, ruta);

                OfrecerAbrirPDF(ruta);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==================== UTILIDADES ====================

        // Muestra el diálogo para que el usuario elija dónde guardar el PDF
        // Retorna la ruta completa elegida o null si canceló
        private string? PedirRutaGuardado(string nombreSugerido)
        {
            using SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title            = "Guardar reporte PDF";
            dlg.Filter           = "Archivo PDF (*.pdf)|*.pdf";
            dlg.FileName         = $"{nombreSugerido}_{DateTime.Now:yyyyMMdd_HHmm}.pdf";
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            return dlg.ShowDialog() == DialogResult.OK ? dlg.FileName : null;
        }

        // Pregunta al usuario si desea abrir el PDF recién generado con el visor predeterminado
        private void OfrecerAbrirPDF(string ruta)
        {
            MessageBox.Show("✅ PDF generado correctamente.", "Listo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult resp = MessageBox.Show(
                "¿Deseas abrir el archivo ahora?",
                "Abrir PDF",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                // Abre el PDF con la aplicación predeterminada del sistema (Acrobat, Edge, etc.)
                Process.Start(new ProcessStartInfo
                {
                    FileName        = ruta,
                    UseShellExecute = true
                });
            }
        }
    }
}
