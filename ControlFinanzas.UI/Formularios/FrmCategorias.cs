using ControlFinanzas.BLL;
using ControlFinanzas.Entity.Entidades;
using ControlFinanzas.Entity.Sesion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlFinanzas.UI.Formularios
{
    public partial class FrmCategorias : Form
    {
        private readonly CategoriaBLL _categoriaBLL;
        private readonly int _usuarioIdLogueado;

        private int _categoriaIdSeleccionada = 0;
        private bool _formularioInicializado = false;
        private List<CategoriaEntity> _listaCategorias = new List<CategoriaEntity>();

        public FrmCategorias() : this(SesionUsuario.HaySesionActiva ? SesionUsuario.UsuarioId : 0)
        {
        }

        public FrmCategorias(int usuarioId)
        {
            InitializeComponent();

            _usuarioIdLogueado = usuarioId > 0 ? usuarioId : (SesionUsuario.HaySesionActiva ? SesionUsuario.UsuarioId : 0);
            _categoriaBLL = new CategoriaBLL();

            ConfigurarEstiloGrid();
            SuscribirEventos();

            // Escuchar cambios de categorías en tiempo real
            EventosFinanzas.CategoriasCambiadas += OnCategoriasCambiadas;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            EventosFinanzas.CategoriasCambiadas -= OnCategoriasCambiadas;
            base.OnFormClosed(e);
        }

        protected override async void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (!this.Visible || IsDisposed || Disposing || !_formularioInicializado)
                return;

            await RefrescarDatosAsync();
        }

        private void OnCategoriasCambiadas(object? sender, EventArgs e)
        {
            if (this.IsDisposed || !this.IsHandleCreated) return;

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(async () => await RefrescarDatosAsync()));
            }
            else
            {
                _ = RefrescarDatosAsync();
            }
        }

        private async Task RefrescarDatosAsync()
        {
            if (this.IsDisposed || !this.IsHandleCreated) return;

            await CargarKPIsAsync();
            await CargarCategoriasAsync();
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            AplicarEstiloTarjetas();
            LimpiarFormulario();

            await CargarKPIsAsync();
            await CargarCategoriasAsync();

            _formularioInicializado = true;
        }

        #region Configuración y Estilo Visual

        private void AplicarEstiloTarjetas()
        {
            // Tarjeta 1: Total Categorías
            if (pnlCardLiquidez != null) pnlCardLiquidez.PanelColor = Color.White;
            lblTituloTotalCategoria.Text = "Total Categorías";
            lblTituloTotalCategoria.ForeColor = Color.FromArgb(100, 116, 139);
            lblTituloTotalCategoria.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblTotalCategoria.ForeColor = Color.FromArgb(37, 99, 235);
            lblTotalCategoria.Font = new Font("Segoe UI", 22F, FontStyle.Bold);

            // Tarjeta 2: Categorías Ingreso
            if (pnlCardDeuda != null) pnlCardDeuda.PanelColor = Color.White;
            lblTituloTotalCategoriasIngreso.Text = "Total Categorías Ingreso";
            lblTituloTotalCategoriasIngreso.ForeColor = Color.FromArgb(100, 116, 139);
            lblTituloTotalCategoriasIngreso.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblTotalCategoriasIngreso.ForeColor = Color.FromArgb(22, 101, 52);
            lblTotalCategoriasIngreso.Font = new Font("Segoe UI", 22F, FontStyle.Bold);

            // Tarjeta 3: Categorías Gasto
            if (pnlCardCredito != null) pnlCardCredito.PanelColor = Color.White;
            lbTitulolTotalCategoriasGasto.Text = "Total Categorías Gasto";
            lbTitulolTotalCategoriasGasto.ForeColor = Color.FromArgb(100, 116, 139);
            lbTitulolTotalCategoriasGasto.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblTotalCategoriasGasto.ForeColor = Color.FromArgb(220, 38, 38);
            lblTotalCategoriasGasto.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        }

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
            dgvCuentas.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvCuentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvCuentas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

            if (dgvCuentas.Columns["colColor"] != null)
            {
                dgvCuentas.Columns["colColor"].Width = 65;
                dgvCuentas.Columns["colColor"].Resizable = DataGridViewTriState.False;
                dgvCuentas.Columns["colColor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvCuentas.Columns["colTipo"] != null)
            {
                dgvCuentas.Columns["colTipo"].Width = 110;
                dgvCuentas.Columns["colTipo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvCuentas.Columns["colEstado"] != null)
            {
                dgvCuentas.Columns["colEstado"].Width = 110;
                dgvCuentas.Columns["colEstado"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvCuentas.RowTemplate.Height = 46;
            dgvCuentas.DefaultCellStyle.BackColor = Color.White;
            dgvCuentas.DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvCuentas.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dgvCuentas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dgvCuentas.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 41, 59);

            dgvCuentas.CellPainting += dgvCuentas_CellPainting;
            dgvCuentas.CellFormatting += dgvCuentas_CellFormatting;
            dgvCuentas.CellDoubleClick += dgvCuentas_CellDoubleClick;
        }

        private void SuscribirEventos()
        {
            textBox1.TextChanged += textBox1_TextChanged;
        }

        #endregion

        #region Pintado y Formato del DataGrid (Diseño Exacto a la Imagen)

        private void dgvCuentas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCuentas.Columns[e.ColumnIndex].Name == "colNombre" && e.Value != null)
            {
                e.CellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                e.CellStyle.ForeColor = Color.Black;
            }
        }

        private void dgvCuentas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvCuentas.Columns[e.ColumnIndex].Name;

            // 1. Columna Color: dibujar círculo sólido con el color de la categoría
            if (colName == "colColor")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                string hex = e.Value?.ToString() ?? "#808080";
                Color colorCirculo;
                try
                {
                    colorCirculo = ColorTranslator.FromHtml(hex);
                }
                catch
                {
                    colorCirculo = Color.Gray;
                }

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                int diametro = 20;
                int x = e.CellBounds.X + (e.CellBounds.Width - diametro) / 2;
                int y = e.CellBounds.Y + (e.CellBounds.Height - diametro) / 2;

                using (SolidBrush brush = new SolidBrush(colorCirculo))
                {
                    e.Graphics.FillEllipse(brush, x, y, diametro, diametro);
                }

                e.Handled = true;
                return;
            }

            // 2. Columna Tipo: badge píldora para "Ingreso" y "Gasto"
            if (colName == "colTipo")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                string tipo = e.Value?.ToString() ?? "";
                bool esIngreso = tipo.Equals("Ingreso", StringComparison.OrdinalIgnoreCase);

                Color bg = esIngreso ? Color.FromArgb(220, 252, 231) : Color.FromArgb(254, 226, 226);
                Color fg = esIngreso ? Color.FromArgb(22, 101, 52) : Color.FromArgb(153, 27, 27);

                DibujarBadgePildora(e, tipo, bg, fg);
                e.Handled = true;
                return;
            }

            // 3. Columna Estado: badge píldora para "Activa" e "Inactiva"
            if (colName == "colEstado")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                string estado = e.Value?.ToString() ?? "";
                bool esActiva = estado.Equals("Activa", StringComparison.OrdinalIgnoreCase);

                Color bg = esActiva ? Color.FromArgb(220, 252, 231) : Color.FromArgb(241, 245, 249);
                Color fg = esActiva ? Color.FromArgb(22, 101, 52) : Color.FromArgb(71, 85, 105);

                DibujarBadgePildora(e, estado, bg, fg);
                e.Handled = true;
                return;
            }
        }

        private void DibujarBadgePildora(DataGridViewCellPaintingEventArgs e, string texto, Color bg, Color fg)
        {
            int badgeWidth = 76;
            int badgeHeight = 26;
            int x = e.CellBounds.X + (e.CellBounds.Width - badgeWidth) / 2;
            int y = e.CellBounds.Y + (e.CellBounds.Height - badgeHeight) / 2;
            Rectangle badgeRect = new Rectangle(x, y, badgeWidth, badgeHeight);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = ObtenerRutaRedondeada(badgeRect, 13))
            using (SolidBrush brushFondo = new SolidBrush(bg))
            using (SolidBrush brushTexto = new SolidBrush(fg))
            {
                e.Graphics.FillPath(brushFondo, path);
                using (StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                })
                using (Font fontBadge = new Font("Segoe UI", 9F, FontStyle.Bold))
                {
                    e.Graphics.DrawString(texto, fontBadge, brushTexto, badgeRect, sf);
                }
            }
        }

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

        #region Carga de Datos y KPIs

        private async Task CargarKPIsAsync()
        {
            try
            {
                var kpis = await _categoriaBLL.ObtenerKPIsAsync(_usuarioIdLogueado);
                lblTotalCategoria.Text = kpis.TotalCategorias.ToString();
                lblTotalCategoriasIngreso.Text = kpis.TotalIngresos.ToString();
                lblTotalCategoriasGasto.Text = kpis.TotalGastos.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los KPIs:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarCategoriasAsync()
        {
            try
            {
                string buscar = txtBuscarCategoriaPorNombre.Content?.Trim() ?? string.Empty;
                string filtroTipo = ComboboxBuscarCategoriaPorTipo.SelectedItem?.ToString() ?? "Todas";

                _listaCategorias = await _categoriaBLL.ObtenerConFiltroAsync(_usuarioIdLogueado, buscar, filtroTipo);
                MostrarEnGrid(_listaCategorias);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarEnGrid(List<CategoriaEntity> categorias)
        {
            dgvCuentas.Rows.Clear();

            foreach (CategoriaEntity c in categorias)
            {
                int rowIndex = dgvCuentas.Rows.Add(
                    c.ColorHex,
                    c.Nombre,
                    c.Tipo,
                    c.Estado ? "Activa" : "Inactiva"
                );

                // Asignamos la entidad al Tag de la fila (POO)
                dgvCuentas.Rows[rowIndex].Tag = c;
            }

            dgvCuentas.ClearSelection();
        }

        #endregion

        #region Búsqueda y Filtros

        private async void txtBuscarCategoriaPorNombre_ContentChanged(object sender, EventArgs e)
        {
            if (!_formularioInicializado) return;
            await CargarCategoriasAsync();
        }

        private async void ComboboxBuscarCategoriaPorTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_formularioInicializado) return;
            await CargarCategoriasAsync();
        }

        #endregion

        #region Color Picker y Control de Color

        private void btnSeleccinarColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                dlg.FullOpen = true;
                try
                {
                    dlg.Color = ColorTranslator.FromHtml(textBox1.Text.Trim());
                }
                catch
                {
                    dlg.Color = Color.FromArgb(128, 128, 128);
                }

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string hex = $"#{dlg.Color.R:X2}{dlg.Color.G:X2}{dlg.Color.B:X2}";
                    textBox1.Text = hex;
                    pnlColorPreview.PanelColor = dlg.Color;
                }
            }
        }

        private void textBox1_TextChanged(object? sender, EventArgs e)
        {
            string hex = textBox1.Text.Trim();
            if (Regex.IsMatch(hex, @"^#?[0-9A-Fa-f]{6}$"))
            {
                try
                {
                    if (!hex.StartsWith("#")) hex = "#" + hex;
                    pnlColorPreview.PanelColor = ColorTranslator.FromHtml(hex);
                }
                catch { }
            }
        }

        #endregion

        #region CRUD: Guardar, Editar, Cancelar y Activar/Desactivar

        private async void cuiButton3_Click(object sender, EventArgs e)
        {
            // Botón Guardar / Actualizar
            await GuardarCategoriaAsync();
        }

        private async Task GuardarCategoriaAsync()
        {
            try
            {
                string nombre = cuiTextBox2.Content?.Trim() ?? string.Empty;
                string tipo = cmbTipoCategoria.SelectedItem?.ToString() ?? "Ingreso";
                string colorHex = textBox1.Text?.Trim() ?? "#808080";
                bool estado = cuiCheckbox1.Checked;

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El campo 'Nombre' es obligatorio.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (tipo != "Ingreso" && tipo != "Gasto")
                {
                    MessageBox.Show("Debe seleccionar el tipo de categoría ('Ingreso' o 'Gasto').", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CategoriaEntity cat = new CategoriaEntity();

                if (_categoriaIdSeleccionada > 0)
                {
                    cat.AsignarId(_categoriaIdSeleccionada);
                }

                cat.AsignarUsuarioId(_usuarioIdLogueado);
                cat.CambiarNombre(nombre);
                cat.CambiarTipo(tipo);
                cat.CambiarColorHex(colorHex);
                cat.CambiarEstado(estado);

                await _categoriaBLL.GuardarAsync(cat);

                MessageBox.Show(
                    _categoriaIdSeleccionada == 0
                        ? "Categoría registrada exitosamente."
                        : "Categoría actualizada exitosamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                await CargarCategoriasAsync();
                await CargarKPIsAsync();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
                if (mensaje.Contains("UNIQUE") || mensaje.Contains("duplicad", StringComparison.OrdinalIgnoreCase))
                {
                    mensaje = "Ya existe una categoría registrada con ese nombre. Ingrese uno diferente.";
                }

                MessageBox.Show($"Error al procesar la categoría:\n{mensaje}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            CargarSeleccionParaEdicion();
        }

        private void dgvCuentas_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CargarSeleccionParaEdicion();
            }
        }

        private void CargarSeleccionParaEdicion()
        {
            if (dgvCuentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una categoría de la lista para editar.", "Sin selección",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow fila = dgvCuentas.SelectedRows[0];
            if (fila.Tag is not CategoriaEntity cat)
            {
                MessageBox.Show("No se pudo cargar la información de la categoría seleccionada.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _categoriaIdSeleccionada = cat.Id;
            label3.Text = "Editar Categoría";
            btnGuardarCategoria.Content = "Actualizar";

            cuiTextBox2.Content = cat.Nombre;
            cmbTipoCategoria.SelectedItem = cat.Tipo;
            textBox1.Text = cat.ColorHex;

            try
            {
                pnlColorPreview.PanelColor = ColorTranslator.FromHtml(cat.ColorHex);
            }
            catch
            {
                pnlColorPreview.PanelColor = Color.FromArgb(128, 128, 128);
            }

            cuiCheckbox1.Checked = cat.Estado;
        }

        private async void btnActivarDesactivar_Click(object sender, EventArgs e)
        {
            if (dgvCuentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una categoría de la lista para cambiar su estado.", "Sin selección",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow fila = dgvCuentas.SelectedRows[0];
            if (fila.Tag is not CategoriaEntity cat) return;

            string accion = cat.Estado ? "desactivar" : "activar";

            DialogResult confirm = MessageBox.Show(
                $"¿Desea {accion} la categoría \"{cat.Nombre}\"?",
                "Confirmar Acción",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                await _categoriaBLL.CambiarEstadoAsync(cat.Id, !cat.Estado);

                MessageBox.Show(
                    $"Categoría {(cat.Estado ? "desactivada" : "activada")} exitosamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (_categoriaIdSeleccionada == cat.Id)
                {
                    cuiCheckbox1.Checked = !cat.Estado;
                }

                await CargarCategoriasAsync();
                await CargarKPIsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar el estado de la categoría:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cuiButton4_Click(object sender, EventArgs e)
        {
            // Botón Cancelar
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            _categoriaIdSeleccionada = 0;
            label3.Text = "Nueva Categoria";
            btnGuardarCategoria.Content = "Guardar";

            cuiTextBox2.Content = string.Empty;
            cmbTipoCategoria.SelectedItem = "Ingreso";
            textBox1.Text = "#808080";
            pnlColorPreview.PanelColor = Color.FromArgb(128, 128, 128);
            cuiCheckbox1.Checked = true;
        }

        private void cuiComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Evento opcional para cmbTipoCategoria
        }

        #endregion
    }
}
