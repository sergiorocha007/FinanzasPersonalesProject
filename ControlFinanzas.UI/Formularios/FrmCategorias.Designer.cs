// ControlFinanzas - Módulo Gestión de Categorías
// Requiere: CuoreUI (NuGet: CuoreUI.Winforms). Nombres de propiedades basados en CuoreUI 2025.x;
// si tu versión difiere, ajusta Rounding / NormalBackground / PanelColor en el diseñador.
namespace ControlFinanzas
{
    partial class FrmCategorias
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Paleta
        private static readonly System.Drawing.Color CFondo     = System.Drawing.ColorTranslator.FromHtml("#F8FAFC");
        private static readonly System.Drawing.Color CTarjeta   = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
        private static readonly System.Drawing.Color CBorde     = System.Drawing.ColorTranslator.FromHtml("#E2E8F0");
        private static readonly System.Drawing.Color CTexto     = System.Drawing.ColorTranslator.FromHtml("#0F172A");
        private static readonly System.Drawing.Color CLabel     = System.Drawing.ColorTranslator.FromHtml("#64748B");
        private static readonly System.Drawing.Color CPrimario  = System.Drawing.ColorTranslator.FromHtml("#2563EB");
        private static readonly System.Drawing.Color CPrimHover = System.Drawing.ColorTranslator.FromHtml("#1D4ED8");
        private static readonly System.Drawing.Color CIngreso   = System.Drawing.ColorTranslator.FromHtml("#10B981");
        private static readonly System.Drawing.Color CGasto     = System.Drawing.ColorTranslator.FromHtml("#EF4444");
        #endregion

        #region Código generado por el Diseñador
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            pnlKpiTotal = new CuoreUI.Controls.cuiPanel();
            pnlKpiIngresos = new CuoreUI.Controls.cuiPanel();
            pnlKpiGastos = new CuoreUI.Controls.cuiPanel();
            lblKpiTotalTit = new Label();
            lblKpiTotal = new Label();
            lblKpiIngTit = new Label();
            lblKpiIngresos = new Label();
            lblKpiGasTit = new Label();
            lblKpiGastos = new Label();
            pnlLista = new CuoreUI.Controls.cuiPanel();
            txtBuscar = new CuoreUI.Controls.cuiTextBox();
            cmbFiltroTipo = new ComboBox();
            dgvCategorias = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colColor = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colHex = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            pnlForm = new CuoreUI.Controls.cuiPanel();
            lblFormTitulo = new Label();
            lblNombre = new Label();
            txtNombre = new CuoreUI.Controls.cuiTextBox();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            lblColor = new Label();
            pnlColorPreview = new CuoreUI.Controls.cuiPanel();
            txtColor = new CuoreUI.Controls.cuiTextBox();
            btnElegirColor = new CuoreUI.Controls.cuiButton();
            lblEstado = new Label();
            chkEstado = new CuoreUI.Controls.cuiSwitch();
            lblEstadoTexto = new Label();
            btnGuardar = new CuoreUI.Controls.cuiButton();
            btnNuevo = new CuoreUI.Controls.cuiButton();
            colorDialog = new ColorDialog();
            pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            pnlForm.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 16F);
            lblTitulo.Location = new Point(24, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(231, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Categorías";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.Location = new Point(26, 52);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(239, 15);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Organiza tus ingresos y gastos por categoría";
            // 
            // pnlKpiTotal
            // 
            pnlKpiTotal.Location = new Point(0, 0);
            pnlKpiTotal.Name = "pnlKpiTotal";
            pnlKpiTotal.OutlineThickness = 1F;
            pnlKpiTotal.PanelColor = Color.White;
            pnlKpiTotal.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            pnlKpiTotal.Rounding = new Padding(8);
            pnlKpiTotal.Size = new Size(346, 150);
            pnlKpiTotal.TabIndex = 2;
            // 
            // pnlKpiIngresos
            // 
            pnlKpiIngresos.Location = new Point(0, 0);
            pnlKpiIngresos.Name = "pnlKpiIngresos";
            pnlKpiIngresos.OutlineThickness = 1F;
            pnlKpiIngresos.PanelColor = Color.White;
            pnlKpiIngresos.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            pnlKpiIngresos.Rounding = new Padding(8);
            pnlKpiIngresos.Size = new Size(346, 150);
            pnlKpiIngresos.TabIndex = 3;
            // 
            // pnlKpiGastos
            // 
            pnlKpiGastos.Location = new Point(0, 0);
            pnlKpiGastos.Name = "pnlKpiGastos";
            pnlKpiGastos.OutlineThickness = 1F;
            pnlKpiGastos.PanelColor = Color.White;
            pnlKpiGastos.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            pnlKpiGastos.Rounding = new Padding(8);
            pnlKpiGastos.Size = new Size(346, 150);
            pnlKpiGastos.TabIndex = 4;
            // 
            // lblKpiTotalTit
            // 
            lblKpiTotalTit.Location = new Point(0, 0);
            lblKpiTotalTit.Name = "lblKpiTotalTit";
            lblKpiTotalTit.Size = new Size(100, 23);
            lblKpiTotalTit.TabIndex = 0;
            // 
            // lblKpiTotal
            // 
            lblKpiTotal.Location = new Point(0, 0);
            lblKpiTotal.Name = "lblKpiTotal";
            lblKpiTotal.Size = new Size(100, 23);
            lblKpiTotal.TabIndex = 0;
            // 
            // lblKpiIngTit
            // 
            lblKpiIngTit.Location = new Point(0, 0);
            lblKpiIngTit.Name = "lblKpiIngTit";
            lblKpiIngTit.Size = new Size(100, 23);
            lblKpiIngTit.TabIndex = 0;
            // 
            // lblKpiIngresos
            // 
            lblKpiIngresos.Location = new Point(0, 0);
            lblKpiIngresos.Name = "lblKpiIngresos";
            lblKpiIngresos.Size = new Size(100, 23);
            lblKpiIngresos.TabIndex = 0;
            // 
            // lblKpiGasTit
            // 
            lblKpiGasTit.Location = new Point(0, 0);
            lblKpiGasTit.Name = "lblKpiGasTit";
            lblKpiGasTit.Size = new Size(100, 23);
            lblKpiGasTit.TabIndex = 0;
            // 
            // lblKpiGastos
            // 
            lblKpiGastos.Location = new Point(0, 0);
            lblKpiGastos.Name = "lblKpiGastos";
            lblKpiGastos.Size = new Size(100, 23);
            lblKpiGastos.TabIndex = 0;
            // 
            // pnlLista
            // 
            pnlLista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlLista.Controls.Add(txtBuscar);
            pnlLista.Controls.Add(cmbFiltroTipo);
            pnlLista.Controls.Add(dgvCategorias);
            pnlLista.Location = new Point(24, 196);
            pnlLista.Name = "pnlLista";
            pnlLista.OutlineThickness = 1F;
            pnlLista.PanelColor = Color.White;
            pnlLista.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            pnlLista.Rounding = new Padding(12);
            pnlLista.Size = new Size(860, 500);
            pnlLista.TabIndex = 5;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.BackgroundColor = Color.White;
            txtBuscar.Content = "";
            txtBuscar.FocusBackgroundColor = Color.White;
            txtBuscar.FocusImageTint = Color.White;
            txtBuscar.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txtBuscar.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.Gray;
            txtBuscar.Image = null;
            txtBuscar.ImageExpand = new Point(0, 0);
            txtBuscar.ImageOffset = new Point(0, 0);
            txtBuscar.Location = new Point(0, 0);
            txtBuscar.Margin = new Padding(4);
            txtBuscar.Multiline = false;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.NormalImageTint = Color.White;
            txtBuscar.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtBuscar.Padding = new Padding(16, 14, 16, 0);
            txtBuscar.PasswordChar = false;
            txtBuscar.PlaceholderColor = Color.LightGray;
            txtBuscar.PlaceholderText = "Placeholder text..";
            txtBuscar.Rounding = new Padding(8);
            txtBuscar.Size = new Size(266, 45);
            txtBuscar.TabIndex = 0;
            txtBuscar.TextOffset = new Size(0, 0);
            txtBuscar.UnderlinedStyle = true;
            // 
            // cmbFiltroTipo
            // 
            cmbFiltroTipo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFiltroTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroTipo.FlatStyle = FlatStyle.Flat;
            cmbFiltroTipo.Font = new Font("Segoe UI", 10F);
            cmbFiltroTipo.Items.AddRange(new object[] { "Todos", "Ingreso", "Gasto" });
            cmbFiltroTipo.Location = new Point(636, 26);
            cmbFiltroTipo.Name = "cmbFiltroTipo";
            cmbFiltroTipo.Size = new Size(204, 25);
            cmbFiltroTipo.TabIndex = 1;
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.AllowUserToResizeRows = false;
            dgvCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.BorderStyle = BorderStyle.None;
            dgvCategorias.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCategorias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategorias.ColumnHeadersHeight = 42;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCategorias.Columns.AddRange(new DataGridViewColumn[] { colId, colColor, colNombre, colTipo, colHex, colEstado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCategorias.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCategorias.EnableHeadersVisualStyles = false;
            dgvCategorias.Location = new Point(20, 76);
            dgvCategorias.MultiSelect = false;
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.RowTemplate.Height = 44;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(820, 404);
            dgvCategorias.TabIndex = 2;
            // 
            // colId
            // 
            colId.DataPropertyName = "IdCategoria";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colColor
            // 
            colColor.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colColor.DataPropertyName = "ColorHex";
            colColor.HeaderText = "";
            colColor.Name = "colColor";
            colColor.ReadOnly = true;
            colColor.Width = 48;
            // 
            // colNombre
            // 
            colNombre.DataPropertyName = "Nombre";
            colNombre.FillWeight = 40F;
            colNombre.HeaderText = "NOMBRE";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.DataPropertyName = "Tipo";
            colTipo.FillWeight = 20F;
            colTipo.HeaderText = "TIPO";
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // colHex
            // 
            colHex.DataPropertyName = "ColorHex";
            colHex.FillWeight = 20F;
            colHex.HeaderText = "COLOR";
            colHex.Name = "colHex";
            colHex.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.DataPropertyName = "Estado";
            colEstado.FillWeight = 20F;
            colEstado.HeaderText = "ESTADO";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // pnlForm
            // 
            pnlForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlForm.Controls.Add(lblFormTitulo);
            pnlForm.Controls.Add(lblNombre);
            pnlForm.Controls.Add(txtNombre);
            pnlForm.Controls.Add(lblTipo);
            pnlForm.Controls.Add(cmbTipo);
            pnlForm.Controls.Add(lblColor);
            pnlForm.Controls.Add(pnlColorPreview);
            pnlForm.Controls.Add(txtColor);
            pnlForm.Controls.Add(btnElegirColor);
            pnlForm.Controls.Add(lblEstado);
            pnlForm.Controls.Add(chkEstado);
            pnlForm.Controls.Add(lblEstadoTexto);
            pnlForm.Controls.Add(btnGuardar);
            pnlForm.Controls.Add(btnNuevo);
            pnlForm.Location = new Point(904, 196);
            pnlForm.Name = "pnlForm";
            pnlForm.OutlineThickness = 1F;
            pnlForm.PanelColor = Color.White;
            pnlForm.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            pnlForm.Rounding = new Padding(12);
            pnlForm.Size = new Size(352, 500);
            pnlForm.TabIndex = 6;
            // 
            // lblFormTitulo
            // 
            lblFormTitulo.AutoSize = true;
            lblFormTitulo.Font = new Font("Segoe UI Semibold", 12F);
            lblFormTitulo.Location = new Point(24, 22);
            lblFormTitulo.Name = "lblFormTitulo";
            lblFormTitulo.Size = new Size(129, 21);
            lblFormTitulo.TabIndex = 0;
            lblFormTitulo.Text = "Nueva categoría";
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(0, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(100, 23);
            lblNombre.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.BackgroundColor = Color.White;
            txtNombre.Content = "";
            txtNombre.FocusBackgroundColor = Color.White;
            txtNombre.FocusImageTint = Color.White;
            txtNombre.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txtNombre.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.Gray;
            txtNombre.Image = null;
            txtNombre.ImageExpand = new Point(0, 0);
            txtNombre.ImageOffset = new Point(0, 0);
            txtNombre.Location = new Point(0, 0);
            txtNombre.Margin = new Padding(4);
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.NormalImageTint = Color.White;
            txtNombre.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtNombre.Padding = new Padding(16, 14, 16, 0);
            txtNombre.PasswordChar = false;
            txtNombre.PlaceholderColor = Color.LightGray;
            txtNombre.PlaceholderText = "Placeholder text..";
            txtNombre.Rounding = new Padding(8);
            txtNombre.Size = new Size(266, 45);
            txtNombre.TabIndex = 2;
            txtNombre.TextOffset = new Size(0, 0);
            txtNombre.UnderlinedStyle = true;
            // 
            // lblTipo
            // 
            lblTipo.Location = new Point(0, 0);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(100, 23);
            lblTipo.TabIndex = 3;
            // 
            // cmbTipo
            // 
            cmbTipo.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FlatStyle = FlatStyle.Flat;
            cmbTipo.Font = new Font("Segoe UI", 10F);
            cmbTipo.ItemHeight = 28;
            cmbTipo.Items.AddRange(new object[] { "Ingreso", "Gasto" });
            cmbTipo.Location = new Point(24, 168);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(304, 34);
            cmbTipo.TabIndex = 4;
            // 
            // lblColor
            // 
            lblColor.Location = new Point(0, 0);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(100, 23);
            lblColor.TabIndex = 5;
            // 
            // pnlColorPreview
            // 
            pnlColorPreview.Cursor = Cursors.Hand;
            pnlColorPreview.Location = new Point(24, 244);
            pnlColorPreview.Name = "pnlColorPreview";
            pnlColorPreview.OutlineThickness = 1F;
            pnlColorPreview.PanelColor = Color.FromArgb(128, 128, 128);
            pnlColorPreview.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            pnlColorPreview.Rounding = new Padding(8);
            pnlColorPreview.Size = new Size(40, 40);
            pnlColorPreview.TabIndex = 6;
            // 
            // txtColor
            // 
            txtColor.BackgroundColor = Color.White;
            txtColor.Content = "";
            txtColor.FocusBackgroundColor = Color.White;
            txtColor.FocusImageTint = Color.White;
            txtColor.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txtColor.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtColor.ForeColor = Color.Gray;
            txtColor.Image = null;
            txtColor.ImageExpand = new Point(0, 0);
            txtColor.ImageOffset = new Point(0, 0);
            txtColor.Location = new Point(0, 0);
            txtColor.Margin = new Padding(4);
            txtColor.Multiline = false;
            txtColor.Name = "txtColor";
            txtColor.NormalImageTint = Color.White;
            txtColor.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtColor.Padding = new Padding(10, 7, 10, 7);
            txtColor.PasswordChar = false;
            txtColor.PlaceholderColor = Color.LightGray;
            txtColor.PlaceholderText = "Placeholder text..";
            txtColor.Rounding = new Padding(8);
            txtColor.Size = new Size(266, 45);
            txtColor.TabIndex = 7;
            txtColor.TextOffset = new Size(0, 0);
            txtColor.UnderlinedStyle = true;
            // 
            // btnElegirColor
            // 
            btnElegirColor.CheckButton = false;
            btnElegirColor.Checked = false;
            btnElegirColor.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnElegirColor.CheckedForeColor = Color.White;
            btnElegirColor.CheckedImageTint = Color.White;
            btnElegirColor.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnElegirColor.Content = "Your text here!";
            btnElegirColor.DialogResult = DialogResult.None;
            btnElegirColor.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnElegirColor.ForeColor = Color.Black;
            btnElegirColor.HoverBackground = Color.White;
            btnElegirColor.HoverForeColor = Color.DimGray;
            btnElegirColor.HoverImageTint = Color.DimGray;
            btnElegirColor.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnElegirColor.Image = null;
            btnElegirColor.ImageExpand = new Point(0, 0);
            btnElegirColor.Location = new Point(0, 0);
            btnElegirColor.Name = "btnElegirColor";
            btnElegirColor.NormalBackground = Color.White;
            btnElegirColor.NormalForeColor = Color.Black;
            btnElegirColor.NormalImageTint = Color.Black;
            btnElegirColor.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnElegirColor.OutlineThickness = 1F;
            btnElegirColor.Padding = new Padding(12);
            btnElegirColor.PressedBackground = Color.WhiteSmoke;
            btnElegirColor.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnElegirColor.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnElegirColor.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnElegirColor.Rounding = new Padding(8);
            btnElegirColor.Size = new Size(153, 45);
            btnElegirColor.TabIndex = 8;
            btnElegirColor.TextAlignment = StringAlignment.Center;
            btnElegirColor.TextPadding = 12;
            btnElegirColor.TextSpacing = 2;
            // 
            // lblEstado
            // 
            lblEstado.Location = new Point(0, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(100, 23);
            lblEstado.TabIndex = 9;
            // 
            // chkEstado
            // 
            chkEstado.Checked = true;
            chkEstado.CheckedBackground = Color.FromArgb(255, 106, 0);
            chkEstado.CheckedForeground = Color.White;
            chkEstado.CheckedOutlineColor = Color.Empty;
            chkEstado.Location = new Point(24, 326);
            chkEstado.MinimumSize = new Size(12, 8);
            chkEstado.Name = "chkEstado";
            chkEstado.OutlineThickness = 1F;
            chkEstado.ShowSymbols = false;
            chkEstado.Size = new Size(44, 24);
            chkEstado.TabIndex = 10;
            chkEstado.ThumbSizeModifier = new Size(0, 0);
            chkEstado.UncheckedBackground = Color.FromArgb(64, 128, 128, 128);
            chkEstado.UncheckedForeground = Color.White;
            chkEstado.UncheckedOutlineColor = Color.Empty;
            // 
            // lblEstadoTexto
            // 
            lblEstadoTexto.AutoSize = true;
            lblEstadoTexto.Font = new Font("Segoe UI", 10F);
            lblEstadoTexto.Location = new Point(76, 328);
            lblEstadoTexto.Name = "lblEstadoTexto";
            lblEstadoTexto.Size = new Size(46, 19);
            lblEstadoTexto.TabIndex = 11;
            lblEstadoTexto.Text = "Activa";
            // 
            // btnGuardar
            // 
            btnGuardar.CheckButton = false;
            btnGuardar.Checked = false;
            btnGuardar.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnGuardar.CheckedForeColor = Color.White;
            btnGuardar.CheckedImageTint = Color.White;
            btnGuardar.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnGuardar.Content = "Guardar categoría";
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.DialogResult = DialogResult.None;
            btnGuardar.Font = new Font("Segoe UI Semibold", 10F);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.HoverBackground = Color.White;
            btnGuardar.HoverForeColor = Color.White;
            btnGuardar.HoverImageTint = Color.DimGray;
            btnGuardar.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnGuardar.Image = null;
            btnGuardar.ImageExpand = new Point(0, 0);
            btnGuardar.Location = new Point(24, 380);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NormalBackground = Color.White;
            btnGuardar.NormalForeColor = Color.White;
            btnGuardar.NormalImageTint = Color.Black;
            btnGuardar.NormalOutline = Color.Empty;
            btnGuardar.OutlineThickness = 1F;
            btnGuardar.Padding = new Padding(12);
            btnGuardar.PressedBackground = Color.WhiteSmoke;
            btnGuardar.PressedForeColor = Color.White;
            btnGuardar.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnGuardar.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnGuardar.Rounding = new Padding(8);
            btnGuardar.Size = new Size(304, 44);
            btnGuardar.TabIndex = 12;
            btnGuardar.TextAlignment = StringAlignment.Center;
            btnGuardar.TextPadding = 12;
            btnGuardar.TextSpacing = 2;
            // 
            // btnNuevo
            // 
            btnNuevo.CheckButton = false;
            btnNuevo.Checked = false;
            btnNuevo.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnNuevo.CheckedForeColor = Color.White;
            btnNuevo.CheckedImageTint = Color.White;
            btnNuevo.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnNuevo.Content = "Your text here!";
            btnNuevo.DialogResult = DialogResult.None;
            btnNuevo.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnNuevo.ForeColor = Color.Black;
            btnNuevo.HoverBackground = Color.White;
            btnNuevo.HoverForeColor = Color.DimGray;
            btnNuevo.HoverImageTint = Color.DimGray;
            btnNuevo.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnNuevo.Image = null;
            btnNuevo.ImageExpand = new Point(0, 0);
            btnNuevo.Location = new Point(0, 0);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.NormalBackground = Color.White;
            btnNuevo.NormalForeColor = Color.Black;
            btnNuevo.NormalImageTint = Color.Black;
            btnNuevo.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnNuevo.OutlineThickness = 1F;
            btnNuevo.Padding = new Padding(12);
            btnNuevo.PressedBackground = Color.WhiteSmoke;
            btnNuevo.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnNuevo.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnNuevo.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnNuevo.Rounding = new Padding(8);
            btnNuevo.Size = new Size(153, 45);
            btnNuevo.TabIndex = 13;
            btnNuevo.TextAlignment = StringAlignment.Center;
            btnNuevo.TextPadding = 12;
            btnNuevo.TextSpacing = 2;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(pnlKpiTotal);
            Controls.Add(pnlKpiIngresos);
            Controls.Add(pnlKpiGastos);
            Controls.Add(pnlLista);
            Controls.Add(pnlForm);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1100, 680);
            Name = "FrmCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ControlFinanzas - Categorías";
            pnlLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        #region Helpers de estilo
        private void ConfigKpi(CuoreUI.Controls.cuiPanel p, System.Windows.Forms.Label tit, System.Windows.Forms.Label val,
                               string titulo, System.Drawing.Color acento, int x, System.Drawing.Font fT, System.Drawing.Font fV)
        {
            p.Location = new System.Drawing.Point(x, 84);
            p.Size = new System.Drawing.Size(276, 96);
            p.PanelColor = CTarjeta;
            p.PanelOutlineColor = CBorde;
            p.OutlineThickness = 1F;
            p.Rounding = new System.Windows.Forms.Padding(12);
            tit.AutoSize = true; tit.Font = fT; tit.ForeColor = acento == CTexto ? CLabel : acento;
            tit.BackColor = System.Drawing.Color.Transparent;
            tit.Location = new System.Drawing.Point(20, 16); tit.Text = titulo;
            val.AutoSize = true; val.Font = fV; val.ForeColor = CTexto;
            val.BackColor = System.Drawing.Color.Transparent;
            val.Location = new System.Drawing.Point(16, 38); val.Text = "0";
            p.Controls.Add(tit); p.Controls.Add(val);
        }

        private void ConfigLabel(System.Windows.Forms.Label l, string texto, int y, System.Drawing.Font f)
        {
            l.AutoSize = true; l.Font = f; l.ForeColor = CLabel;
            l.BackColor = System.Drawing.Color.Transparent;
            l.Location = new System.Drawing.Point(24, y); l.Text = texto;
        }

        private void ConfigTextBox(CuoreUI.Controls.cuiTextBox t, string placeholder, System.Drawing.Point loc,
                                   System.Drawing.Size size, System.Drawing.Font f)
        {
            t.Location = loc; t.Size = size; t.Font = f;
            t.PlaceholderText = placeholder;
            t.BackgroundColor = CTarjeta;
            t.ForeColor = CTexto;
            t.PlaceholderColor = CLabel;
            t.Rounding = new System.Windows.Forms.Padding(8);
            t.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
        }

        private void ConfigSecundario(CuoreUI.Controls.cuiButton b, string texto, System.Drawing.Point loc, System.Drawing.Size size)
        {
            b.Content = texto; b.Location = loc; b.Size = size;
            b.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            b.Rounding = new System.Windows.Forms.Padding(8);
            b.NormalBackground = CTarjeta; b.HoverBackground = CFondo; b.PressedBackground = CBorde;
            b.NormalForeColor = CTexto; b.HoverForeColor = CTexto; b.PressedForeColor = CTexto;
            b.NormalOutline = CBorde; b.HoverOutline = CLabel; b.PressedOutline = CLabel;
            b.Cursor = System.Windows.Forms.Cursors.Hand;
        }
        #endregion

        private System.Windows.Forms.Label lblTitulo, lblSubtitulo;
        private CuoreUI.Controls.cuiPanel pnlKpiTotal, pnlKpiIngresos, pnlKpiGastos, pnlLista, pnlForm, pnlColorPreview;
        private System.Windows.Forms.Label lblKpiTotalTit, lblKpiTotal, lblKpiIngTit, lblKpiIngresos, lblKpiGasTit, lblKpiGastos;
        private CuoreUI.Controls.cuiTextBox txtBuscar, txtNombre, txtColor;
        private System.Windows.Forms.ComboBox cmbFiltroTipo, cmbTipo;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId, colColor, colNombre, colTipo, colHex, colEstado;
        private System.Windows.Forms.Label lblFormTitulo, lblNombre, lblTipo, lblColor, lblEstado, lblEstadoTexto;
        private CuoreUI.Controls.cuiButton btnElegirColor, btnGuardar, btnNuevo;
        private CuoreUI.Controls.cuiSwitch chkEstado;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}
