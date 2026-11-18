namespace ControlFinanzas.UI.Formularios
{
    partial class FrmCategorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategorias));
            label2 = new Label();
            label1 = new Label();
            pnlCardCredito = new CuoreUI.Controls.cuiPanel();
            lblTotalCategoriasGasto = new Label();
            lbTitulolTotalCategoriasGasto = new Label();
            pnlCardDeuda = new CuoreUI.Controls.cuiPanel();
            lblTotalCategoriasIngreso = new Label();
            lblTituloTotalCategoriasIngreso = new Label();
            pnlCardLiquidez = new CuoreUI.Controls.cuiPanel();
            lblTotalCategoria = new Label();
            lblTituloTotalCategoria = new Label();
            cuiPanel4 = new CuoreUI.Controls.cuiPanel();
            btnActivarDesactivar = new CuoreUI.Controls.cuiButton();
            btnEditarCategoria = new CuoreUI.Controls.cuiButton();
            dgvCuentas = new DataGridView();
            colColor = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            ComboboxBuscarCategoriaPorTipo = new CuoreUI.Controls.cuiComboBox();
            txtBuscarCategoriaPorNombre = new CuoreUI.Controls.cuiTextBox();
            cuiPanel5 = new CuoreUI.Controls.cuiPanel();
            textBox1 = new TextBox();
            pnlColorPreview = new CuoreUI.Controls.cuiPanel();
            btnSeleccinarColor = new CuoreUI.Controls.cuiButton();
            label5 = new Label();
            btnCancelar = new CuoreUI.Controls.cuiButton();
            btnGuardarCategoria = new CuoreUI.Controls.cuiButton();
            cuiCheckbox1 = new CuoreUI.Controls.cuiCheckbox();
            cmbTipoCategoria = new CuoreUI.Controls.cuiComboBox();
            label6 = new Label();
            label4 = new Label();
            cuiTextBox2 = new CuoreUI.Controls.cuiTextBox();
            label3 = new Label();
            pnlCardCredito.SuspendLayout();
            pnlCardDeuda.SuspendLayout();
            pnlCardLiquidez.SuspendLayout();
            cuiPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).BeginInit();
            cuiPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(18, 52);
            label2.Name = "label2";
            label2.Size = new Size(279, 20);
            label2.TabIndex = 3;
            label2.Text = "Organiza tus rubros de ingresos y gastos.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 25);
            label1.Name = "label1";
            label1.Size = new Size(227, 30);
            label1.TabIndex = 2;
            label1.Text = "Gestion de Categorias";
            // 
            // pnlCardCredito
            // 
            pnlCardCredito.BackColor = Color.Transparent;
            pnlCardCredito.Controls.Add(lblTotalCategoriasGasto);
            pnlCardCredito.Controls.Add(lbTitulolTotalCategoriasGasto);
            pnlCardCredito.Location = new Point(776, 92);
            pnlCardCredito.Name = "pnlCardCredito";
            pnlCardCredito.OutlineThickness = 1F;
            pnlCardCredito.PanelColor = Color.White;
            pnlCardCredito.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            pnlCardCredito.Rounding = new Padding(15);
            pnlCardCredito.Size = new Size(358, 90);
            pnlCardCredito.TabIndex = 6;
            // 
            // lblTotalCategoriasGasto
            // 
            lblTotalCategoriasGasto.AutoSize = true;
            lblTotalCategoriasGasto.BackColor = Color.Transparent;
            lblTotalCategoriasGasto.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            lblTotalCategoriasGasto.ForeColor = Color.Red;
            lblTotalCategoriasGasto.Location = new Point(48, 42);
            lblTotalCategoriasGasto.Name = "lblTotalCategoriasGasto";
            lblTotalCategoriasGasto.Size = new Size(36, 37);
            lblTotalCategoriasGasto.TabIndex = 6;
            lblTotalCategoriasGasto.Text = "0";
            // 
            // lbTitulolTotalCategoriasGasto
            // 
            lbTitulolTotalCategoriasGasto.AutoSize = true;
            lbTitulolTotalCategoriasGasto.BackColor = Color.Transparent;
            lbTitulolTotalCategoriasGasto.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            lbTitulolTotalCategoriasGasto.ForeColor = SystemColors.ActiveCaptionText;
            lbTitulolTotalCategoriasGasto.Location = new Point(20, 9);
            lbTitulolTotalCategoriasGasto.Name = "lbTitulolTotalCategoriasGasto";
            lbTitulolTotalCategoriasGasto.Size = new Size(147, 19);
            lbTitulolTotalCategoriasGasto.TabIndex = 6;
            lbTitulolTotalCategoriasGasto.Text = "Total Categorías Gasto";
            // 
            // pnlCardDeuda
            // 
            pnlCardDeuda.BackColor = Color.Transparent;
            pnlCardDeuda.Controls.Add(lblTotalCategoriasIngreso);
            pnlCardDeuda.Controls.Add(lblTituloTotalCategoriasIngreso);
            pnlCardDeuda.Location = new Point(400, 92);
            pnlCardDeuda.Name = "pnlCardDeuda";
            pnlCardDeuda.OutlineThickness = 1F;
            pnlCardDeuda.PanelColor = Color.White;
            pnlCardDeuda.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            pnlCardDeuda.Rounding = new Padding(15);
            pnlCardDeuda.Size = new Size(358, 90);
            pnlCardDeuda.TabIndex = 5;
            // 
            // lblTotalCategoriasIngreso
            // 
            lblTotalCategoriasIngreso.AutoSize = true;
            lblTotalCategoriasIngreso.BackColor = Color.Transparent;
            lblTotalCategoriasIngreso.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            lblTotalCategoriasIngreso.ForeColor = Color.Green;
            lblTotalCategoriasIngreso.Location = new Point(54, 42);
            lblTotalCategoriasIngreso.Name = "lblTotalCategoriasIngreso";
            lblTotalCategoriasIngreso.Size = new Size(36, 37);
            lblTotalCategoriasIngreso.TabIndex = 5;
            lblTotalCategoriasIngreso.Text = "0";
            // 
            // lblTituloTotalCategoriasIngreso
            // 
            lblTituloTotalCategoriasIngreso.AutoSize = true;
            lblTituloTotalCategoriasIngreso.BackColor = Color.Transparent;
            lblTituloTotalCategoriasIngreso.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            lblTituloTotalCategoriasIngreso.ForeColor = SystemColors.ActiveCaptionText;
            lblTituloTotalCategoriasIngreso.Location = new Point(20, 9);
            lblTituloTotalCategoriasIngreso.Name = "lblTituloTotalCategoriasIngreso";
            lblTituloTotalCategoriasIngreso.Size = new Size(137, 19);
            lblTituloTotalCategoriasIngreso.TabIndex = 2;
            lblTituloTotalCategoriasIngreso.Text = "Total Categorías Ingreso";
            // 
            // pnlCardLiquidez
            // 
            pnlCardLiquidez.BackColor = Color.Transparent;
            pnlCardLiquidez.Controls.Add(lblTotalCategoria);
            pnlCardLiquidez.Controls.Add(lblTituloTotalCategoria);
            pnlCardLiquidez.Location = new Point(20, 92);
            pnlCardLiquidez.Name = "pnlCardLiquidez";
            pnlCardLiquidez.OutlineThickness = 1F;
            pnlCardLiquidez.PanelColor = Color.White;
            pnlCardLiquidez.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            pnlCardLiquidez.Rounding = new Padding(15);
            pnlCardLiquidez.Size = new Size(358, 90);
            pnlCardLiquidez.TabIndex = 4;
            // 
            // lblTotalCategoria
            // 
            lblTotalCategoria.AutoSize = true;
            lblTotalCategoria.BackColor = Color.Transparent;
            lblTotalCategoria.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            lblTotalCategoria.ForeColor = Color.FromArgb(0, 0, 192);
            lblTotalCategoria.Location = new Point(50, 42);
            lblTotalCategoria.Name = "lblTotalCategoria";
            lblTotalCategoria.Size = new Size(36, 37);
            lblTotalCategoria.TabIndex = 1;
            lblTotalCategoria.Text = "0";
            // 
            // lblTituloTotalCategoria
            // 
            lblTituloTotalCategoria.AutoSize = true;
            lblTituloTotalCategoria.BackColor = Color.Transparent;
            lblTituloTotalCategoria.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            lblTituloTotalCategoria.ForeColor = SystemColors.ActiveCaptionText;
            lblTituloTotalCategoria.Location = new Point(20, 9);
            lblTituloTotalCategoria.Name = "lblTituloTotalCategoria";
            lblTituloTotalCategoria.Size = new Size(111, 19);
            lblTituloTotalCategoria.TabIndex = 0;
            lblTituloTotalCategoria.Text = "Total Categorías";
            // 
            // cuiPanel4
            // 
            cuiPanel4.Controls.Add(btnActivarDesactivar);
            cuiPanel4.Controls.Add(btnEditarCategoria);
            cuiPanel4.Controls.Add(dgvCuentas);
            cuiPanel4.Controls.Add(ComboboxBuscarCategoriaPorTipo);
            cuiPanel4.Controls.Add(txtBuscarCategoriaPorNombre);
            cuiPanel4.Location = new Point(20, 206);
            cuiPanel4.Name = "cuiPanel4";
            cuiPanel4.OutlineThickness = 1F;
            cuiPanel4.PanelColor = Color.White;
            cuiPanel4.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel4.Rounding = new Padding(15);
            cuiPanel4.Size = new Size(698, 486);
            cuiPanel4.TabIndex = 7;
            // 
            // btnActivarDesactivar
            // 
            btnActivarDesactivar.CheckButton = false;
            btnActivarDesactivar.Checked = false;
            btnActivarDesactivar.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnActivarDesactivar.CheckedForeColor = Color.White;
            btnActivarDesactivar.CheckedImageTint = Color.White;
            btnActivarDesactivar.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnActivarDesactivar.Content = "Desactivar/Activar";
            btnActivarDesactivar.DialogResult = DialogResult.None;
            btnActivarDesactivar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnActivarDesactivar.ForeColor = Color.Gray;
            btnActivarDesactivar.HoverBackground = Color.White;
            btnActivarDesactivar.HoverForeColor = Color.DimGray;
            btnActivarDesactivar.HoverImageTint = Color.DimGray;
            btnActivarDesactivar.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnActivarDesactivar.Image = null;
            btnActivarDesactivar.ImageExpand = new Point(0, 0);
            btnActivarDesactivar.Location = new Point(128, 404);
            btnActivarDesactivar.Name = "btnActivarDesactivar";
            btnActivarDesactivar.NormalBackground = Color.White;
            btnActivarDesactivar.NormalForeColor = Color.Gray;
            btnActivarDesactivar.NormalImageTint = Color.Black;
            btnActivarDesactivar.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnActivarDesactivar.OutlineThickness = 1F;
            btnActivarDesactivar.Padding = new Padding(12);
            btnActivarDesactivar.PressedBackground = Color.WhiteSmoke;
            btnActivarDesactivar.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnActivarDesactivar.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnActivarDesactivar.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnActivarDesactivar.Rounding = new Padding(8);
            btnActivarDesactivar.Size = new Size(160, 32);
            btnActivarDesactivar.TabIndex = 4;
            btnActivarDesactivar.TextAlignment = StringAlignment.Center;
            btnActivarDesactivar.TextPadding = 12;
            btnActivarDesactivar.TextSpacing = 2;
            btnActivarDesactivar.Click += btnActivarDesactivar_Click;
            // 
            // btnEditarCategoria
            // 
            btnEditarCategoria.CheckButton = false;
            btnEditarCategoria.Checked = false;
            btnEditarCategoria.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnEditarCategoria.CheckedForeColor = Color.White;
            btnEditarCategoria.CheckedImageTint = Color.White;
            btnEditarCategoria.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnEditarCategoria.Content = "Editar";
            btnEditarCategoria.DialogResult = DialogResult.None;
            btnEditarCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEditarCategoria.ForeColor = Color.Gray;
            btnEditarCategoria.HoverBackground = Color.White;
            btnEditarCategoria.HoverForeColor = Color.DimGray;
            btnEditarCategoria.HoverImageTint = Color.DimGray;
            btnEditarCategoria.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnEditarCategoria.Image = null;
            btnEditarCategoria.ImageExpand = new Point(0, 0);
            btnEditarCategoria.Location = new Point(12, 404);
            btnEditarCategoria.Name = "btnEditarCategoria";
            btnEditarCategoria.NormalBackground = Color.White;
            btnEditarCategoria.NormalForeColor = Color.Gray;
            btnEditarCategoria.NormalImageTint = Color.Black;
            btnEditarCategoria.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnEditarCategoria.OutlineThickness = 1F;
            btnEditarCategoria.Padding = new Padding(12);
            btnEditarCategoria.PressedBackground = Color.WhiteSmoke;
            btnEditarCategoria.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnEditarCategoria.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnEditarCategoria.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnEditarCategoria.Rounding = new Padding(8);
            btnEditarCategoria.Size = new Size(110, 32);
            btnEditarCategoria.TabIndex = 3;
            btnEditarCategoria.TextAlignment = StringAlignment.Center;
            btnEditarCategoria.TextPadding = 12;
            btnEditarCategoria.TextSpacing = 2;
            btnEditarCategoria.Click += btnEditarCategoria_Click;
            // 
            // dgvCuentas
            // 
            dgvCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuentas.Columns.AddRange(new DataGridViewColumn[] { colColor, colNombre, colTipo, colEstado });
            dgvCuentas.Location = new Point(12, 118);
            dgvCuentas.Name = "dgvCuentas";
            dgvCuentas.Size = new Size(676, 270);
            dgvCuentas.TabIndex = 2;
            // 
            // colColor
            // 
            colColor.HeaderText = "Color";
            colColor.Name = "colColor";
            colColor.Width = 65;
            colColor.Resizable = DataGridViewTriState.False;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo";
            colTipo.Name = "colTipo";
            colTipo.Width = 110;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.Width = 110;
            // 
            // ComboboxBuscarCategoriaPorTipo
            // 
            ComboboxBuscarCategoriaPorTipo.BackColor = Color.Transparent;
            ComboboxBuscarCategoriaPorTipo.BackgroundColor = Color.FromArgb(255, 255, 255);
            ComboboxBuscarCategoriaPorTipo.DropDownBackgroundColor = Color.White;
            ComboboxBuscarCategoriaPorTipo.DropDownForeColor = Color.FromArgb(27, 27, 27);
            ComboboxBuscarCategoriaPorTipo.ExpandArrowColor = Color.DimGray;
            ComboboxBuscarCategoriaPorTipo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComboboxBuscarCategoriaPorTipo.ForeColor = Color.Gray;
            ComboboxBuscarCategoriaPorTipo.Items = new string[]
            {
                "Todas",
                "Ingreso",
                "Gasto"
            };
            ComboboxBuscarCategoriaPorTipo.Location = new Point(12, 61);
            ComboboxBuscarCategoriaPorTipo.Margin = new Padding(5, 4, 5, 4);
            ComboboxBuscarCategoriaPorTipo.MaxDropDownHeight = 240;
            ComboboxBuscarCategoriaPorTipo.Name = "ComboboxBuscarCategoriaPorTipo";
            ComboboxBuscarCategoriaPorTipo.NoSelectionText = "None";
            ComboboxBuscarCategoriaPorTipo.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            ComboboxBuscarCategoriaPorTipo.OutlineThickness = 1F;
            ComboboxBuscarCategoriaPorTipo.Rounding = 8;
            ComboboxBuscarCategoriaPorTipo.SelectedIndex = 0;
            ComboboxBuscarCategoriaPorTipo.SelectedItem = "Todas";
            ComboboxBuscarCategoriaPorTipo.Size = new Size(676, 36);
            ComboboxBuscarCategoriaPorTipo.SortAlphabetically = false;
            ComboboxBuscarCategoriaPorTipo.TabIndex = 1;
            ComboboxBuscarCategoriaPorTipo.SelectedIndexChanged += ComboboxBuscarCategoriaPorTipo_SelectedIndexChanged;
            // 
            // txtBuscarCategoriaPorNombre
            // 
            txtBuscarCategoriaPorNombre.BackColor = Color.Transparent;
            txtBuscarCategoriaPorNombre.BackgroundColor = Color.White;
            txtBuscarCategoriaPorNombre.Content = "";
            txtBuscarCategoriaPorNombre.FocusBackgroundColor = Color.White;
            txtBuscarCategoriaPorNombre.FocusImageTint = Color.White;
            txtBuscarCategoriaPorNombre.FocusOutlineColor = SystemColors.MenuHighlight;
            txtBuscarCategoriaPorNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarCategoriaPorNombre.ForeColor = Color.DimGray;
            txtBuscarCategoriaPorNombre.Image = null;
            txtBuscarCategoriaPorNombre.ImageExpand = new Point(0, 0);
            txtBuscarCategoriaPorNombre.ImageOffset = new Point(0, 0);
            txtBuscarCategoriaPorNombre.Location = new Point(12, 17);
            txtBuscarCategoriaPorNombre.Margin = new Padding(4);
            txtBuscarCategoriaPorNombre.Multiline = false;
            txtBuscarCategoriaPorNombre.Name = "txtBuscarCategoriaPorNombre";
            txtBuscarCategoriaPorNombre.NormalImageTint = Color.White;
            txtBuscarCategoriaPorNombre.OutlineColor = Color.DarkGray;
            txtBuscarCategoriaPorNombre.Padding = new Padding(20, 8, 20, 0);
            txtBuscarCategoriaPorNombre.PasswordChar = false;
            txtBuscarCategoriaPorNombre.PlaceholderColor = Color.Silver;
            txtBuscarCategoriaPorNombre.PlaceholderText = "Buscar categoría por nombre...";
            txtBuscarCategoriaPorNombre.Rounding = new Padding(15);
            txtBuscarCategoriaPorNombre.Size = new Size(676, 36);
            txtBuscarCategoriaPorNombre.TabIndex = 0;
            txtBuscarCategoriaPorNombre.TextOffset = new Size(0, 0);
            txtBuscarCategoriaPorNombre.UnderlinedStyle = true;
            txtBuscarCategoriaPorNombre.ContentChanged += txtBuscarCategoriaPorNombre_ContentChanged;
            // 
            // cuiPanel5
            // 
            cuiPanel5.Controls.Add(textBox1);
            cuiPanel5.Controls.Add(pnlColorPreview);
            cuiPanel5.Controls.Add(btnSeleccinarColor);
            cuiPanel5.Controls.Add(label5);
            cuiPanel5.Controls.Add(btnCancelar);
            cuiPanel5.Controls.Add(btnGuardarCategoria);
            cuiPanel5.Controls.Add(cuiCheckbox1);
            cuiPanel5.Controls.Add(cmbTipoCategoria);
            cuiPanel5.Controls.Add(label6);
            cuiPanel5.Controls.Add(label4);
            cuiPanel5.Controls.Add(cuiTextBox2);
            cuiPanel5.Controls.Add(label3);
            cuiPanel5.Location = new Point(738, 206);
            cuiPanel5.Name = "cuiPanel5";
            cuiPanel5.OutlineThickness = 1F;
            cuiPanel5.PanelColor = Color.White;
            cuiPanel5.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel5.Rounding = new Padding(15);
            cuiPanel5.Size = new Size(396, 486);
            cuiPanel5.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(64, 64, 64);
            textBox1.Location = new Point(283, 268);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 18);
            textBox1.TabIndex = 17;
            textBox1.Text = "#808080";
            // 
            // pnlColorPreview
            // 
            pnlColorPreview.BackColor = Color.Transparent;
            pnlColorPreview.Location = new Point(227, 257);
            pnlColorPreview.Name = "pnlColorPreview";
            pnlColorPreview.OutlineThickness = 1F;
            pnlColorPreview.PanelColor = Color.Gray;
            pnlColorPreview.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            pnlColorPreview.Rounding = new Padding(8);
            pnlColorPreview.Size = new Size(50, 40);
            pnlColorPreview.TabIndex = 16;
            // 
            // btnSeleccinarColor
            // 
            btnSeleccinarColor.BackColor = Color.Transparent;
            btnSeleccinarColor.CheckButton = false;
            btnSeleccinarColor.Checked = false;
            btnSeleccinarColor.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnSeleccinarColor.CheckedForeColor = Color.White;
            btnSeleccinarColor.CheckedImageTint = Color.White;
            btnSeleccinarColor.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnSeleccinarColor.Content = "Seleccionar Color";
            btnSeleccinarColor.DialogResult = DialogResult.None;
            btnSeleccinarColor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSeleccinarColor.ForeColor = Color.DimGray;
            btnSeleccinarColor.HoverBackground = Color.Transparent;
            btnSeleccinarColor.HoverForeColor = Color.DimGray;
            btnSeleccinarColor.HoverImageTint = Color.IndianRed;
            btnSeleccinarColor.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnSeleccinarColor.Image = (Image)resources.GetObject("btnSeleccinarColor.Image");
            btnSeleccinarColor.ImageExpand = new Point(0, 0);
            btnSeleccinarColor.Location = new Point(12, 260);
            btnSeleccinarColor.Name = "btnSeleccinarColor";
            btnSeleccinarColor.NormalBackground = Color.White;
            btnSeleccinarColor.NormalForeColor = Color.DimGray;
            btnSeleccinarColor.NormalImageTint = Color.White;
            btnSeleccinarColor.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnSeleccinarColor.OutlineThickness = 1F;
            btnSeleccinarColor.Padding = new Padding(12);
            btnSeleccinarColor.PressedBackground = Color.WhiteSmoke;
            btnSeleccinarColor.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnSeleccinarColor.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnSeleccinarColor.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnSeleccinarColor.Rounding = new Padding(8);
            btnSeleccinarColor.Size = new Size(193, 39);
            btnSeleccinarColor.TabIndex = 15;
            btnSeleccinarColor.TextAlignment = StringAlignment.Center;
            btnSeleccinarColor.TextPadding = 12;
            btnSeleccinarColor.TextSpacing = 2;
            btnSeleccinarColor.Click += btnSeleccinarColor_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(12, 218);
            label5.Name = "label5";
            label5.Size = new Size(41, 17);
            label5.TabIndex = 14;
            label5.Text = "Color";
            // 
            // btnCancelar
            // 
            btnCancelar.CheckButton = false;
            btnCancelar.Checked = false;
            btnCancelar.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnCancelar.CheckedForeColor = Color.White;
            btnCancelar.CheckedImageTint = Color.White;
            btnCancelar.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnCancelar.Content = "Cancelar";
            btnCancelar.DialogResult = DialogResult.None;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.HoverBackground = Color.Transparent;
            btnCancelar.HoverForeColor = Color.DimGray;
            btnCancelar.HoverImageTint = Color.DimGray;
            btnCancelar.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnCancelar.Image = null;
            btnCancelar.ImageExpand = new Point(0, 0);
            btnCancelar.Location = new Point(199, 404);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NormalBackground = Color.WhiteSmoke;
            btnCancelar.NormalForeColor = Color.Black;
            btnCancelar.NormalImageTint = Color.Black;
            btnCancelar.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnCancelar.OutlineThickness = 1F;
            btnCancelar.Padding = new Padding(12);
            btnCancelar.PressedBackground = Color.WhiteSmoke;
            btnCancelar.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnCancelar.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnCancelar.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnCancelar.Rounding = new Padding(8);
            btnCancelar.Size = new Size(182, 32);
            btnCancelar.TabIndex = 13;
            btnCancelar.TextAlignment = StringAlignment.Center;
            btnCancelar.TextPadding = 12;
            btnCancelar.TextSpacing = 2;
            btnCancelar.Click += cuiButton4_Click;
            // 
            // btnGuardarCategoria
            // 
            btnGuardarCategoria.CheckButton = false;
            btnGuardarCategoria.Checked = false;
            btnGuardarCategoria.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnGuardarCategoria.CheckedForeColor = Color.White;
            btnGuardarCategoria.CheckedImageTint = Color.White;
            btnGuardarCategoria.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnGuardarCategoria.Content = "Guardar";
            btnGuardarCategoria.DialogResult = DialogResult.None;
            btnGuardarCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGuardarCategoria.ForeColor = Color.White;
            btnGuardarCategoria.HoverBackground = Color.White;
            btnGuardarCategoria.HoverForeColor = Color.DimGray;
            btnGuardarCategoria.HoverImageTint = Color.DimGray;
            btnGuardarCategoria.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnGuardarCategoria.Image = null;
            btnGuardarCategoria.ImageExpand = new Point(0, 0);
            btnGuardarCategoria.Location = new Point(12, 404);
            btnGuardarCategoria.Name = "btnGuardarCategoria";
            btnGuardarCategoria.NormalBackground = SystemColors.Highlight;
            btnGuardarCategoria.NormalForeColor = Color.White;
            btnGuardarCategoria.NormalImageTint = Color.Black;
            btnGuardarCategoria.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnGuardarCategoria.OutlineThickness = 1F;
            btnGuardarCategoria.Padding = new Padding(12);
            btnGuardarCategoria.PressedBackground = Color.WhiteSmoke;
            btnGuardarCategoria.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnGuardarCategoria.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnGuardarCategoria.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnGuardarCategoria.Rounding = new Padding(8);
            btnGuardarCategoria.Size = new Size(181, 32);
            btnGuardarCategoria.TabIndex = 12;
            btnGuardarCategoria.TextAlignment = StringAlignment.Center;
            btnGuardarCategoria.TextPadding = 12;
            btnGuardarCategoria.TextSpacing = 2;
            btnGuardarCategoria.Click += cuiButton3_Click;
            // 
            // cuiCheckbox1
            // 
            cuiCheckbox1.BackColor = Color.White;
            cuiCheckbox1.Checked = true;
            cuiCheckbox1.CheckedForeground = Color.FromArgb(255, 106, 0);
            cuiCheckbox1.CheckedOutlineColor = Color.FromArgb(255, 106, 0);
            cuiCheckbox1.CheckedSymbolColor = Color.RoyalBlue;
            cuiCheckbox1.Content = "Categoría Activa";
            cuiCheckbox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiCheckbox1.ForeColor = Color.Black;
            cuiCheckbox1.Location = new Point(12, 346);
            cuiCheckbox1.MinimumSize = new Size(16, 16);
            cuiCheckbox1.Name = "cuiCheckbox1";
            cuiCheckbox1.OutlineThickness = 1F;
            cuiCheckbox1.Rounding = 4;
            cuiCheckbox1.ShowSymbols = true;
            cuiCheckbox1.Size = new Size(163, 24);
            cuiCheckbox1.TabIndex = 9;
            cuiCheckbox1.UncheckedForeground = Color.Empty;
            cuiCheckbox1.UncheckedOutlineColor = Color.Gray;
            cuiCheckbox1.UncheckedSymbolColor = Color.Empty;
            // 
            // cmbTipoCategoria
            // 
            cmbTipoCategoria.BackColor = Color.Transparent;
            cmbTipoCategoria.BackgroundColor = Color.FromArgb(255, 255, 255);
            cmbTipoCategoria.DropDownBackgroundColor = Color.White;
            cmbTipoCategoria.DropDownForeColor = Color.FromArgb(27, 27, 27);
            cmbTipoCategoria.ExpandArrowColor = Color.DimGray;
            cmbTipoCategoria.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbTipoCategoria.ForeColor = Color.Gray;
            cmbTipoCategoria.Items = new string[]
            {
                "Ingreso",
                "Gasto"
            };
            cmbTipoCategoria.Location = new Point(12, 159);
            cmbTipoCategoria.Margin = new Padding(5, 4, 5, 4);
            cmbTipoCategoria.MaxDropDownHeight = 240;
            cmbTipoCategoria.Name = "cmbTipoCategoria";
            cmbTipoCategoria.NoSelectionText = "None";
            cmbTipoCategoria.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cmbTipoCategoria.OutlineThickness = 1F;
            cmbTipoCategoria.Rounding = 8;
            cmbTipoCategoria.SelectedIndex = 0;
            cmbTipoCategoria.SelectedItem = "Ingreso";
            cmbTipoCategoria.Size = new Size(177, 36);
            cmbTipoCategoria.SortAlphabetically = false;
            cmbTipoCategoria.TabIndex = 6;
            cmbTipoCategoria.SelectedIndexChanged += cuiComboBox2_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(12, 138);
            label6.Name = "label6";
            label6.Size = new Size(118, 17);
            label6.TabIndex = 5;
            label6.Text = "Tipo de Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(12, 61);
            label4.Name = "label4";
            label4.Size = new Size(58, 17);
            label4.TabIndex = 3;
            label4.Text = "Nombre";
            // 
            // cuiTextBox2
            // 
            cuiTextBox2.BackColor = Color.Transparent;
            cuiTextBox2.BackgroundColor = Color.White;
            cuiTextBox2.Content = "";
            cuiTextBox2.FocusBackgroundColor = Color.White;
            cuiTextBox2.FocusImageTint = Color.White;
            cuiTextBox2.FocusOutlineColor = SystemColors.MenuHighlight;
            cuiTextBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox2.ForeColor = Color.DimGray;
            cuiTextBox2.Image = null;
            cuiTextBox2.ImageExpand = new Point(0, 0);
            cuiTextBox2.ImageOffset = new Point(0, 0);
            cuiTextBox2.Location = new Point(12, 76);
            cuiTextBox2.Margin = new Padding(4);
            cuiTextBox2.Multiline = false;
            cuiTextBox2.Name = "cuiTextBox2";
            cuiTextBox2.NormalImageTint = Color.White;
            cuiTextBox2.OutlineColor = Color.DarkGray;
            cuiTextBox2.Padding = new Padding(20, 8, 20, 0);
            cuiTextBox2.PasswordChar = false;
            cuiTextBox2.PlaceholderColor = Color.Silver;
            cuiTextBox2.PlaceholderText = "";
            cuiTextBox2.Rounding = new Padding(15);
            cuiTextBox2.Size = new Size(369, 36);
            cuiTextBox2.TabIndex = 2;
            cuiTextBox2.TextOffset = new Size(0, 0);
            cuiTextBox2.UnderlinedStyle = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(138, 21);
            label3.TabIndex = 1;
            label3.Text = "Nueva Categoria";
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1171, 716);
            Controls.Add(cuiPanel5);
            Controls.Add(cuiPanel4);
            Controls.Add(pnlCardCredito);
            Controls.Add(pnlCardDeuda);
            Controls.Add(pnlCardLiquidez);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCategorias";
            Text = "FrmCategorias";
            pnlCardCredito.ResumeLayout(false);
            pnlCardCredito.PerformLayout();
            pnlCardDeuda.ResumeLayout(false);
            pnlCardDeuda.PerformLayout();
            pnlCardLiquidez.ResumeLayout(false);
            pnlCardLiquidez.PerformLayout();
            cuiPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).EndInit();
            cuiPanel5.ResumeLayout(false);
            cuiPanel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private CuoreUI.Controls.cuiPanel pnlCardCredito;
        private Label lblTotalCategoriasGasto;
        private Label lbTitulolTotalCategoriasGasto;
        private CuoreUI.Controls.cuiPanel pnlCardDeuda;
        private Label lblTotalCategoriasIngreso;
        private Label lblTituloTotalCategoriasIngreso;
        private CuoreUI.Controls.cuiPanel pnlCardLiquidez;
        private Label lblTotalCategoria;
        private Label lblTituloTotalCategoria;
        private CuoreUI.Controls.cuiPanel cuiPanel4;
        private CuoreUI.Controls.cuiButton btnActivarDesactivar;
        private CuoreUI.Controls.cuiButton btnEditarCategoria;
        private DataGridView dgvCuentas;
        private CuoreUI.Controls.cuiComboBox ComboboxBuscarCategoriaPorTipo;
        private CuoreUI.Controls.cuiTextBox txtBuscarCategoriaPorNombre;
        private DataGridViewTextBoxColumn colColor;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colEstado;
        private CuoreUI.Controls.cuiPanel cuiPanel5;
        private CuoreUI.Controls.cuiButton btnCancelar;
        private CuoreUI.Controls.cuiButton btnGuardarCategoria;
        private CuoreUI.Controls.cuiCheckbox cuiCheckbox1;
        private CuoreUI.Controls.cuiComboBox cmbTipoCategoria;
        private Label label6;
        private Label label4;
        private CuoreUI.Controls.cuiTextBox cuiTextBox2;
        private Label label3;
        private CuoreUI.Controls.cuiPanel pnlColorPreview;
        private CuoreUI.Controls.cuiButton btnSeleccinarColor;
        private Label label5;
        private TextBox textBox1;
    }
}