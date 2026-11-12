using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlFinanzas
{
    public partial class FrmCategorias : Form
    {
        private readonly int _usuarioId;

        public FrmCategorias() : this(0) { }

        public FrmCategorias(int usuarioId)
        {
            _usuarioId = usuarioId;
            InitializeComponent();
            dgvCategorias.CellPainting += Dgv_CellPainting;
            cmbTipo.DrawItem += CmbTipo_DrawItem;
            btnElegirColor.Click += (s, e) => ElegirColor();
            pnlColorPreview.Click += (s, e) => ElegirColor();
            txtColor.ContentChanged += (s, e) => ActualizarPreview();   // en algunas versiones: TextChanged
            chkEstado.CheckedChanged += (s, e) => lblEstadoTexto.Text = chkEstado.Checked ? "Activa" : "Inactiva";
            btnNuevo.Click += (s, e) => Limpiar();
            btnGuardar.Click += BtnGuardar_Click;
            txtBuscar.ContentChanged += (s, e) => Filtrar();
            cmbFiltroTipo.SelectedIndexChanged += (s, e) => Filtrar();
            dgvCategorias.CellClick += Dgv_CellClick;
        }

        // Columna visual: círculo con el ColorHex + "pill" de Tipo + texto de Estado
        private void Dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string col = dgvCategorias.Columns[e.ColumnIndex].Name;
            if (col != "colColor" && col != "colTipo") return;

            e.PaintBackground(e.CellBounds, true);
            var g = e.Graphics; g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (col == "colColor")
            {
                Color c; try { c = ColorTranslator.FromHtml(e.Value?.ToString() ?? "#808080"); } catch { c = Color.Gray; }
                var r = new Rectangle(e.CellBounds.X + 14, e.CellBounds.Y + (e.CellBounds.Height - 18) / 2, 18, 18);
                using var b = new SolidBrush(c); g.FillEllipse(b, r);
            }
            else
            {
                string tipo = e.Value?.ToString() ?? "";
                Color c = tipo == "Ingreso" ? ColorTranslator.FromHtml("#10B981") : ColorTranslator.FromHtml("#EF4444");
                var font = new Font("Segoe UI Semibold", 8.5F);
                var sz = TextRenderer.MeasureText(tipo, font);
                var r = new Rectangle(e.CellBounds.X + 8, e.CellBounds.Y + (e.CellBounds.Height - 24) / 2, sz.Width + 16, 24);
                using var bg = new SolidBrush(Color.FromArgb(28, c));
                using var path = Redondeado(r, 12);
                g.FillPath(bg, path);
                TextRenderer.DrawText(g, tipo, font, r, c, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
            e.Handled = true;
        }

        private void CmbTipo_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            e.DrawBackground();
            string t = cmbTipo.Items[e.Index].ToString();
            Color c = t == "Ingreso" ? ColorTranslator.FromHtml("#10B981") : ColorTranslator.FromHtml("#EF4444");
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (var b = new SolidBrush(c)) e.Graphics.FillEllipse(b, e.Bounds.X + 8, e.Bounds.Y + (e.Bounds.Height - 10) / 2, 10, 10);
            TextRenderer.DrawText(e.Graphics, t, e.Font, new Point(e.Bounds.X + 26, e.Bounds.Y + 5), ColorTranslator.FromHtml("#0F172A"));
        }

        private static System.Drawing.Drawing2D.GraphicsPath Redondeado(Rectangle r, int rad)
        {
            var p = new System.Drawing.Drawing2D.GraphicsPath(); int d = rad * 2;
            p.AddArc(r.X, r.Y, d, d, 180, 90); p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90); p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure(); return p;
        }

        private void ElegirColor()
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                txtColor.Content = $"#{colorDialog.Color.R:X2}{colorDialog.Color.G:X2}{colorDialog.Color.B:X2}";
        }

        private void ActualizarPreview()
        {
            try { pnlColorPreview.PanelColor = ColorTranslator.FromHtml(txtColor.Content); } catch { }
        }

        private void Limpiar()
        {
            lblFormTitulo.Text = "Nueva categoría";
            txtNombre.Content = ""; cmbTipo.SelectedIndex = 1; txtColor.Content = "#808080"; chkEstado.Checked = true;
            dgvCategorias.ClearSelection();
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvCategorias.Rows[e.RowIndex];
            lblFormTitulo.Text = "Editar categoría";
            txtNombre.Content = row.Cells["colNombre"].Value?.ToString();
            cmbTipo.SelectedItem = row.Cells["colTipo"].Value?.ToString();
            txtColor.Content = row.Cells["colHex"].Value?.ToString();
            chkEstado.Checked = row.Cells["colEstado"].Value?.ToString() == "Activa";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Content) || txtNombre.Content.Length > 50)
            { MessageBox.Show("El nombre es obligatorio (máx. 50 caracteres)."); return; }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtColor.Content ?? "", "^#[0-9A-Fa-f]{6}$"))
            { MessageBox.Show("Color inválido. Usa formato #RRGGBB."); return; }
            // TODO: INSERT/UPDATE en tabla Categorias (Nombre, Tipo, ColorHex, Estado)
            Filtrar(); ActualizarKpis();
        }

        private void Filtrar() { /* TODO: aplicar txtBuscar.Content y cmbFiltroTipo al DataSource */ }

        public void ActualizarKpis()
        {
            int ing = 0, gas = 0;
            foreach (DataGridViewRow r in dgvCategorias.Rows)
            {
                if (r.Cells["colEstado"].Value?.ToString() != "Activa") continue;
                if (r.Cells["colTipo"].Value?.ToString() == "Ingreso") ing++; else gas++;
            }
            lblKpiTotal.Text = (ing + gas).ToString();
            lblKpiIngresos.Text = ing.ToString();
            lblKpiGastos.Text = gas.ToString();
        }
    }
}
