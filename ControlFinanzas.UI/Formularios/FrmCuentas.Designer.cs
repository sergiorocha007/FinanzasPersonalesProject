namespace ControlFinanzas.UI.Formularios
{
    partial class FrmCuentas
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
            if (disposing)
            {
                // Desuscribir eventos de CuoreUI antes de que los controles mueran
                if (cuiTextBox1 != null)
                    cuiTextBox1.ContentChanged -= txtBuscar_ContentChanged;

                if (cuiComboBox2 != null)
                    cuiComboBox2.SelectedIndexChanged -= cmbTipoCuenta_SelectedItemChanged;

                if (cuiButton3 != null) cuiButton3.Click -= btnGuardar_Click;
                if (cuiButton4 != null) cuiButton4.Click -= btnCancelar_Click;
                if (cuiButton1 != null) cuiButton1.Click -= btnEditar_Click;
                if (cuiButton2 != null) cuiButton2.Click -= btnDesactivarActivar_Click;

                components?.Dispose();
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
            label1 = new Label();
            label2 = new Label();
            pnlCardLiquidez = new CuoreUI.Controls.cuiPanel();
            lblMontoLiquidez = new Label();
            lblTituloLiquidez = new Label();
            pnlCardDeuda = new CuoreUI.Controls.cuiPanel();
            lblMontoDeuda = new Label();
            lblTituloDeuda = new Label();
            pnlCardCredito = new CuoreUI.Controls.cuiPanel();
            lblMontoCredito = new Label();
            lblTituloCredito = new Label();
            cuiPanel4 = new CuoreUI.Controls.cuiPanel();
            cuiButton2 = new CuoreUI.Controls.cuiButton();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            dgvCuentas = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ComboboxBuscarPorTipo = new CuoreUI.Controls.cuiComboBox();
            cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            cuiPanel5 = new CuoreUI.Controls.cuiPanel();
            cuiButton4 = new CuoreUI.Controls.cuiButton();
            cuiButton3 = new CuoreUI.Controls.cuiButton();
            label7 = new Label();
            cuiPanel7 = new CuoreUI.Controls.cuiPanel();
            txtDiaPago = new CuoreUI.Controls.cuiTextBox();
            lblDiaPago = new Label();
            txtDiaCorte = new CuoreUI.Controls.cuiTextBox();
            lblDiaCorte = new Label();
            txtDeudaActual = new CuoreUI.Controls.cuiTextBox();
            lblDeudaActual = new Label();
            txtLimiteCredito = new CuoreUI.Controls.cuiTextBox();
            lblLimiteCredito = new Label();
            lblPanelCredito = new Label();
            cuiPanel6 = new CuoreUI.Controls.cuiPanel();
            cuiTextBox3 = new CuoreUI.Controls.cuiTextBox();
            label8 = new Label();
            cuiCheckbox1 = new CuoreUI.Controls.cuiCheckbox();
            cuiComboBox3 = new CuoreUI.Controls.cuiComboBox();
            cuiComboBox2 = new CuoreUI.Controls.cuiComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            cuiTextBox2 = new CuoreUI.Controls.cuiTextBox();
            label3 = new Label();
            pnlCardLiquidez.SuspendLayout();
            pnlCardDeuda.SuspendLayout();
            pnlCardCredito.SuspendLayout();
            cuiPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).BeginInit();
            cuiPanel5.SuspendLayout();
            cuiPanel7.SuspendLayout();
            cuiPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 25);
            label1.Name = "label1";
            label1.Size = new Size(202, 30);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Cuentas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(18, 52);
            label2.Name = "label2";
            label2.Size = new Size(254, 20);
            label2.TabIndex = 1;
            label2.Text = "Efectivo, Debito y Tarjetas de Credito";
            // 
            // pnlCardLiquidez
            // 
            pnlCardLiquidez.Controls.Add(lblMontoLiquidez);
            pnlCardLiquidez.Controls.Add(lblTituloLiquidez);
            pnlCardLiquidez.Location = new Point(20, 92);
            pnlCardLiquidez.Name = "pnlCardLiquidez";
            pnlCardLiquidez.OutlineThickness = 1F;
            pnlCardLiquidez.PanelColor = Color.White;
            pnlCardLiquidez.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            pnlCardLiquidez.Rounding = new Padding(15);
            pnlCardLiquidez.Size = new Size(358, 90);
            pnlCardLiquidez.TabIndex = 2;
            // 
            // lblMontoLiquidez
            // 
            lblMontoLiquidez.AutoSize = true;
            lblMontoLiquidez.BackColor = Color.Transparent;
            lblMontoLiquidez.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMontoLiquidez.ForeColor = Color.Green;
            lblMontoLiquidez.Location = new Point(33, 42);
            lblMontoLiquidez.Name = "lblMontoLiquidez";
            lblMontoLiquidez.Size = new Size(155, 26);
            lblMontoLiquidez.TabIndex = 1;
            lblMontoLiquidez.Text = "Total Liquidez";
            // 
            // lblTituloLiquidez
            // 
            lblTituloLiquidez.AutoSize = true;
            lblTituloLiquidez.BackColor = Color.Transparent;
            lblTituloLiquidez.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            lblTituloLiquidez.ForeColor = SystemColors.ActiveCaptionText;
            lblTituloLiquidez.Location = new Point(20, 9);
            lblTituloLiquidez.Name = "lblTituloLiquidez";
            lblTituloLiquidez.Size = new Size(111, 19);
            lblTituloLiquidez.TabIndex = 0;
            lblTituloLiquidez.Text = "Total Liquidez";
            // 
            // pnlCardDeuda
            // 
            pnlCardDeuda.Controls.Add(lblMontoDeuda);
            pnlCardDeuda.Controls.Add(lblTituloDeuda);
            pnlCardDeuda.Location = new Point(400, 92);
            pnlCardDeuda.Name = "pnlCardDeuda";
            pnlCardDeuda.OutlineThickness = 1F;
            pnlCardDeuda.PanelColor = Color.White;
            pnlCardDeuda.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            pnlCardDeuda.Rounding = new Padding(15);
            pnlCardDeuda.Size = new Size(358, 90);
            pnlCardDeuda.TabIndex = 3;
            // 
            // lblMontoDeuda
            // 
            lblMontoDeuda.AutoSize = true;
            lblMontoDeuda.BackColor = Color.Transparent;
            lblMontoDeuda.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold);
            lblMontoDeuda.ForeColor = Color.Red;
            lblMontoDeuda.Location = new Point(37, 42);
            lblMontoDeuda.Name = "lblMontoDeuda";
            lblMontoDeuda.Size = new Size(187, 26);
            lblMontoDeuda.TabIndex = 5;
            lblMontoDeuda.Text = "Deuda en credito";
            // 
            // lblTituloDeuda
            // 
            lblTituloDeuda.AutoSize = true;
            lblTituloDeuda.BackColor = Color.Transparent;
            lblTituloDeuda.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            lblTituloDeuda.ForeColor = SystemColors.ActiveCaptionText;
            lblTituloDeuda.Location = new Point(20, 9);
            lblTituloDeuda.Name = "lblTituloDeuda";
            lblTituloDeuda.Size = new Size(137, 19);
            lblTituloDeuda.TabIndex = 2;
            lblTituloDeuda.Text = "Deuda En Credito";
            // 
            // pnlCardCredito
            // 
            pnlCardCredito.Controls.Add(lblMontoCredito);
            pnlCardCredito.Controls.Add(lblTituloCredito);
            pnlCardCredito.Location = new Point(776, 92);
            pnlCardCredito.Name = "pnlCardCredito";
            pnlCardCredito.OutlineThickness = 1F;
            pnlCardCredito.PanelColor = Color.White;
            pnlCardCredito.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            pnlCardCredito.Rounding = new Padding(15);
            pnlCardCredito.Size = new Size(358, 90);
            pnlCardCredito.TabIndex = 3;
            pnlCardCredito.Paint += cuiPanel3_Paint;
            // 
            // lblMontoCredito
            // 
            lblMontoCredito.AutoSize = true;
            lblMontoCredito.BackColor = Color.Transparent;
            lblMontoCredito.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold);
            lblMontoCredito.ForeColor = Color.FromArgb(0, 0, 192);
            lblMontoCredito.Location = new Point(31, 42);
            lblMontoCredito.Name = "lblMontoCredito";
            lblMontoCredito.Size = new Size(204, 26);
            lblMontoCredito.TabIndex = 6;
            lblMontoCredito.Text = "Credito Disponible";
            // 
            // lblTituloCredito
            // 
            lblTituloCredito.AutoSize = true;
            lblTituloCredito.BackColor = Color.Transparent;
            lblTituloCredito.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            lblTituloCredito.ForeColor = SystemColors.ActiveCaptionText;
            lblTituloCredito.Location = new Point(20, 9);
            lblTituloCredito.Name = "lblTituloCredito";
            lblTituloCredito.Size = new Size(147, 19);
            lblTituloCredito.TabIndex = 6;
            lblTituloCredito.Text = "Credito Disponible";
            // 
            // cuiPanel4
            // 
            cuiPanel4.Controls.Add(cuiButton2);
            cuiPanel4.Controls.Add(cuiButton1);
            cuiPanel4.Controls.Add(dgvCuentas);
            cuiPanel4.Controls.Add(ComboboxBuscarPorTipo);
            cuiPanel4.Controls.Add(cuiTextBox1);
            cuiPanel4.Location = new Point(20, 206);
            cuiPanel4.Name = "cuiPanel4";
            cuiPanel4.OutlineThickness = 1F;
            cuiPanel4.PanelColor = Color.White;
            cuiPanel4.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel4.Rounding = new Padding(15);
            cuiPanel4.Size = new Size(698, 486);
            cuiPanel4.TabIndex = 3;
            cuiPanel4.Paint += cuiPanel4_Paint;
            // 
            // cuiButton2
            // 
            cuiButton2.CheckButton = false;
            cuiButton2.Checked = false;
            cuiButton2.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton2.CheckedForeColor = Color.White;
            cuiButton2.CheckedImageTint = Color.White;
            cuiButton2.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton2.Content = "Desactivar/Activar";
            cuiButton2.DialogResult = DialogResult.None;
            cuiButton2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            cuiButton2.ForeColor = Color.Gray;
            cuiButton2.HoverBackground = Color.White;
            cuiButton2.HoverForeColor = Color.DimGray;
            cuiButton2.HoverImageTint = Color.DimGray;
            cuiButton2.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton2.Image = null;
            cuiButton2.ImageExpand = new Point(0, 0);
            cuiButton2.Location = new Point(128, 404);
            cuiButton2.Name = "cuiButton2";
            cuiButton2.NormalBackground = Color.White;
            cuiButton2.NormalForeColor = Color.Gray;
            cuiButton2.NormalImageTint = Color.Black;
            cuiButton2.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton2.OutlineThickness = 1F;
            cuiButton2.Padding = new Padding(12);
            cuiButton2.PressedBackground = Color.WhiteSmoke;
            cuiButton2.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton2.PressedImageTint = Color.FromArgb(32, 32, 32);
            cuiButton2.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton2.Rounding = new Padding(8);
            cuiButton2.Size = new Size(160, 32);
            cuiButton2.TabIndex = 4;
            cuiButton2.TextAlignment = StringAlignment.Center;
            cuiButton2.TextPadding = 12;
            cuiButton2.TextSpacing = 2;
            // 
            // cuiButton1
            // 
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "Editar";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            cuiButton1.ForeColor = Color.Gray;
            cuiButton1.HoverBackground = Color.White;
            cuiButton1.HoverForeColor = Color.DimGray;
            cuiButton1.HoverImageTint = Color.DimGray;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = null;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.Location = new Point(12, 404);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.White;
            cuiButton1.NormalForeColor = Color.Gray;
            cuiButton1.NormalImageTint = Color.Black;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.Padding = new Padding(12);
            cuiButton1.PressedBackground = Color.WhiteSmoke;
            cuiButton1.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedImageTint = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(110, 32);
            cuiButton1.TabIndex = 3;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextPadding = 12;
            cuiButton1.TextSpacing = 2;
            // 
            // dgvCuentas
            // 
            dgvCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuentas.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvCuentas.Location = new Point(12, 118);
            dgvCuentas.Name = "dgvCuentas";
            dgvCuentas.Size = new Size(676, 270);
            dgvCuentas.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Tipo";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Moneda";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Saldo/Deuda";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Estado";
            Column6.Name = "Column6";
            // 
            // ComboboxBuscarPorTipo
            // 
            ComboboxBuscarPorTipo.BackColor = Color.Transparent;
            ComboboxBuscarPorTipo.BackgroundColor = Color.FromArgb(255, 255, 255);
            ComboboxBuscarPorTipo.DropDownBackgroundColor = Color.White;
            ComboboxBuscarPorTipo.DropDownForeColor = Color.FromArgb(27, 27, 27);
            ComboboxBuscarPorTipo.ExpandArrowColor = Color.DimGray;
            ComboboxBuscarPorTipo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComboboxBuscarPorTipo.ForeColor = Color.Gray;
            ComboboxBuscarPorTipo.Items = new string[]
    {
    "Todos",
    "Efectivo",
    "Debito",
    "Credito"
    };
            ComboboxBuscarPorTipo.Location = new Point(12, 61);
            ComboboxBuscarPorTipo.Margin = new Padding(5, 4, 5, 4);
            ComboboxBuscarPorTipo.MaxDropDownHeight = 240;
            ComboboxBuscarPorTipo.Name = "ComboboxBuscarPorTipo";
            ComboboxBuscarPorTipo.NoSelectionText = "None";
            ComboboxBuscarPorTipo.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            ComboboxBuscarPorTipo.OutlineThickness = 1F;
            ComboboxBuscarPorTipo.Rounding = 8;
            ComboboxBuscarPorTipo.SelectedIndex = 0;
            ComboboxBuscarPorTipo.SelectedItem = "Todos";
            ComboboxBuscarPorTipo.Size = new Size(676, 36);
            ComboboxBuscarPorTipo.SortAlphabetically = true;
            ComboboxBuscarPorTipo.TabIndex = 1;
            ComboboxBuscarPorTipo.SelectedIndexChanged += ComboboxBuscarPorTipo_SelectedIndexChanged;
            // 
            // cuiTextBox1
            // 
            cuiTextBox1.BackColor = Color.Transparent;
            cuiTextBox1.BackgroundColor = Color.White;
            cuiTextBox1.Content = "";
            cuiTextBox1.FocusBackgroundColor = Color.White;
            cuiTextBox1.FocusImageTint = Color.White;
            cuiTextBox1.FocusOutlineColor = SystemColors.MenuHighlight;
            cuiTextBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox1.ForeColor = Color.DimGray;
            cuiTextBox1.Image = null;
            cuiTextBox1.ImageExpand = new Point(0, 0);
            cuiTextBox1.ImageOffset = new Point(0, 0);
            cuiTextBox1.Location = new Point(12, 17);
            cuiTextBox1.Margin = new Padding(4);
            cuiTextBox1.Multiline = false;
            cuiTextBox1.Name = "cuiTextBox1";
            cuiTextBox1.NormalImageTint = Color.White;
            cuiTextBox1.OutlineColor = Color.DarkGray;
            cuiTextBox1.Padding = new Padding(20, 8, 20, 0);
            cuiTextBox1.PasswordChar = false;
            cuiTextBox1.PlaceholderColor = Color.Silver;
            cuiTextBox1.PlaceholderText = "Buscar Cuenta por nombre..";
            cuiTextBox1.Rounding = new Padding(15);
            cuiTextBox1.Size = new Size(676, 36);
            cuiTextBox1.TabIndex = 0;
            cuiTextBox1.TextOffset = new Size(0, 0);
            cuiTextBox1.UnderlinedStyle = true;
            // 
            // cuiPanel5
            // 
            cuiPanel5.Controls.Add(cuiButton4);
            cuiPanel5.Controls.Add(cuiButton3);
            cuiPanel5.Controls.Add(label7);
            cuiPanel5.Controls.Add(cuiPanel7);
            cuiPanel5.Controls.Add(cuiPanel6);
            cuiPanel5.Controls.Add(cuiCheckbox1);
            cuiPanel5.Controls.Add(cuiComboBox3);
            cuiPanel5.Controls.Add(cuiComboBox2);
            cuiPanel5.Controls.Add(label6);
            cuiPanel5.Controls.Add(label5);
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
            cuiPanel5.TabIndex = 4;
            // 
            // cuiButton4
            // 
            cuiButton4.CheckButton = false;
            cuiButton4.Checked = false;
            cuiButton4.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton4.CheckedForeColor = Color.White;
            cuiButton4.CheckedImageTint = Color.White;
            cuiButton4.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton4.Content = "Cancelar";
            cuiButton4.DialogResult = DialogResult.None;
            cuiButton4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            cuiButton4.ForeColor = Color.Black;
            cuiButton4.HoverBackground = Color.Transparent;
            cuiButton4.HoverForeColor = Color.DimGray;
            cuiButton4.HoverImageTint = Color.DimGray;
            cuiButton4.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton4.Image = null;
            cuiButton4.ImageExpand = new Point(0, 0);
            cuiButton4.Location = new Point(199, 415);
            cuiButton4.Name = "cuiButton4";
            cuiButton4.NormalBackground = Color.WhiteSmoke;
            cuiButton4.NormalForeColor = Color.Black;
            cuiButton4.NormalImageTint = Color.Black;
            cuiButton4.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton4.OutlineThickness = 1F;
            cuiButton4.Padding = new Padding(12);
            cuiButton4.PressedBackground = Color.WhiteSmoke;
            cuiButton4.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton4.PressedImageTint = Color.FromArgb(32, 32, 32);
            cuiButton4.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton4.Rounding = new Padding(8);
            cuiButton4.Size = new Size(182, 32);
            cuiButton4.TabIndex = 13;
            cuiButton4.TextAlignment = StringAlignment.Center;
            cuiButton4.TextPadding = 12;
            cuiButton4.TextSpacing = 2;
            // 
            // cuiButton3
            // 
            cuiButton3.CheckButton = false;
            cuiButton3.Checked = false;
            cuiButton3.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton3.CheckedForeColor = Color.White;
            cuiButton3.CheckedImageTint = Color.White;
            cuiButton3.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton3.Content = "Guardar";
            cuiButton3.DialogResult = DialogResult.None;
            cuiButton3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            cuiButton3.ForeColor = Color.White;
            cuiButton3.HoverBackground = Color.White;
            cuiButton3.HoverForeColor = Color.DimGray;
            cuiButton3.HoverImageTint = Color.DimGray;
            cuiButton3.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton3.Image = null;
            cuiButton3.ImageExpand = new Point(0, 0);
            cuiButton3.Location = new Point(12, 415);
            cuiButton3.Name = "cuiButton3";
            cuiButton3.NormalBackground = SystemColors.Highlight;
            cuiButton3.NormalForeColor = Color.White;
            cuiButton3.NormalImageTint = Color.Black;
            cuiButton3.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton3.OutlineThickness = 1F;
            cuiButton3.Padding = new Padding(12);
            cuiButton3.PressedBackground = Color.WhiteSmoke;
            cuiButton3.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton3.PressedImageTint = Color.FromArgb(32, 32, 32);
            cuiButton3.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton3.Rounding = new Padding(8);
            cuiButton3.Size = new Size(181, 32);
            cuiButton3.TabIndex = 12;
            cuiButton3.TextAlignment = StringAlignment.Center;
            cuiButton3.TextPadding = 12;
            cuiButton3.TextSpacing = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(36, 248);
            label7.Name = "label7";
            label7.Size = new Size(101, 17);
            label7.TabIndex = 11;
            label7.Text = "Debito/Credito";
            // 
            // cuiPanel7
            // 
            cuiPanel7.Controls.Add(txtDiaPago);
            cuiPanel7.Controls.Add(lblDiaPago);
            cuiPanel7.Controls.Add(txtDiaCorte);
            cuiPanel7.Controls.Add(lblDiaCorte);
            cuiPanel7.Controls.Add(txtDeudaActual);
            cuiPanel7.Controls.Add(lblDeudaActual);
            cuiPanel7.Controls.Add(txtLimiteCredito);
            cuiPanel7.Controls.Add(lblLimiteCredito);
            cuiPanel7.Controls.Add(lblPanelCredito);
            cuiPanel7.Location = new Point(12, 254);
            cuiPanel7.Name = "cuiPanel7";
            cuiPanel7.OutlineThickness = 1F;
            cuiPanel7.PanelColor = Color.White;
            cuiPanel7.PanelOutlineColor = Color.Gray;
            cuiPanel7.Rounding = new Padding(15);
            cuiPanel7.Size = new Size(369, 148);
            cuiPanel7.TabIndex = 14;
            cuiPanel7.Visible = false;
            // 
            // txtDiaPago
            // 
            txtDiaPago.BackColor = Color.Transparent;
            txtDiaPago.BackgroundColor = Color.White;
            txtDiaPago.Content = "";
            txtDiaPago.FocusBackgroundColor = Color.White;
            txtDiaPago.FocusImageTint = Color.White;
            txtDiaPago.FocusOutlineColor = SystemColors.MenuHighlight;
            txtDiaPago.Font = new Font("Segoe UI", 10F);
            txtDiaPago.ForeColor = Color.Black;
            txtDiaPago.Image = null;
            txtDiaPago.ImageExpand = new Point(0, 0);
            txtDiaPago.ImageOffset = new Point(0, 0);
            txtDiaPago.Location = new Point(192, 110);
            txtDiaPago.Margin = new Padding(4);
            txtDiaPago.Multiline = false;
            txtDiaPago.Name = "txtDiaPago";
            txtDiaPago.NormalImageTint = Color.White;
            txtDiaPago.OutlineColor = Color.DarkGray;
            txtDiaPago.Padding = new Padding(18, 7, 18, 0);
            txtDiaPago.PasswordChar = false;
            txtDiaPago.PlaceholderColor = Color.Silver;
            txtDiaPago.PlaceholderText = "Ej: 5";
            txtDiaPago.Rounding = new Padding(15);
            txtDiaPago.Size = new Size(165, 32);
            txtDiaPago.TabIndex = 0;
            txtDiaPago.TextOffset = new Size(0, 0);
            txtDiaPago.UnderlinedStyle = true;
            // 
            // lblDiaPago
            // 
            lblDiaPago.AutoSize = true;
            lblDiaPago.BackColor = Color.Transparent;
            lblDiaPago.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            lblDiaPago.ForeColor = Color.DimGray;
            lblDiaPago.Location = new Point(192, 92);
            lblDiaPago.Name = "lblDiaPago";
            lblDiaPago.Size = new Size(103, 13);
            lblDiaPago.TabIndex = 1;
            lblDiaPago.Text = "Día de Pago (1-31)";
            // 
            // txtDiaCorte
            // 
            txtDiaCorte.BackColor = Color.Transparent;
            txtDiaCorte.BackgroundColor = Color.White;
            txtDiaCorte.Content = "";
            txtDiaCorte.FocusBackgroundColor = Color.White;
            txtDiaCorte.FocusImageTint = Color.White;
            txtDiaCorte.FocusOutlineColor = SystemColors.MenuHighlight;
            txtDiaCorte.Font = new Font("Segoe UI", 10F);
            txtDiaCorte.ForeColor = Color.Black;
            txtDiaCorte.Image = null;
            txtDiaCorte.ImageExpand = new Point(0, 0);
            txtDiaCorte.ImageOffset = new Point(0, 0);
            txtDiaCorte.Location = new Point(12, 110);
            txtDiaCorte.Margin = new Padding(4);
            txtDiaCorte.Multiline = false;
            txtDiaCorte.Name = "txtDiaCorte";
            txtDiaCorte.NormalImageTint = Color.White;
            txtDiaCorte.OutlineColor = Color.DarkGray;
            txtDiaCorte.Padding = new Padding(18, 7, 18, 0);
            txtDiaCorte.PasswordChar = false;
            txtDiaCorte.PlaceholderColor = Color.Silver;
            txtDiaCorte.PlaceholderText = "Ej: 15";
            txtDiaCorte.Rounding = new Padding(15);
            txtDiaCorte.Size = new Size(165, 32);
            txtDiaCorte.TabIndex = 2;
            txtDiaCorte.TextOffset = new Size(0, 0);
            txtDiaCorte.UnderlinedStyle = true;
            // 
            // lblDiaCorte
            // 
            lblDiaCorte.AutoSize = true;
            lblDiaCorte.BackColor = Color.Transparent;
            lblDiaCorte.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            lblDiaCorte.ForeColor = Color.DimGray;
            lblDiaCorte.Location = new Point(12, 92);
            lblDiaCorte.Name = "lblDiaCorte";
            lblDiaCorte.Size = new Size(104, 13);
            lblDiaCorte.TabIndex = 3;
            lblDiaCorte.Text = "Día de Corte (1-31)";
            // 
            // txtDeudaActual
            // 
            txtDeudaActual.BackColor = Color.Transparent;
            txtDeudaActual.BackgroundColor = Color.White;
            txtDeudaActual.Content = "";
            txtDeudaActual.FocusBackgroundColor = Color.White;
            txtDeudaActual.FocusImageTint = Color.White;
            txtDeudaActual.FocusOutlineColor = SystemColors.MenuHighlight;
            txtDeudaActual.Font = new Font("Segoe UI", 10F);
            txtDeudaActual.ForeColor = Color.Black;
            txtDeudaActual.Image = null;
            txtDeudaActual.ImageExpand = new Point(0, 0);
            txtDeudaActual.ImageOffset = new Point(0, 0);
            txtDeudaActual.Location = new Point(192, 48);
            txtDeudaActual.Margin = new Padding(4);
            txtDeudaActual.Multiline = false;
            txtDeudaActual.Name = "txtDeudaActual";
            txtDeudaActual.NormalImageTint = Color.White;
            txtDeudaActual.OutlineColor = Color.DarkGray;
            txtDeudaActual.Padding = new Padding(18, 7, 18, 0);
            txtDeudaActual.PasswordChar = false;
            txtDeudaActual.PlaceholderColor = Color.Silver;
            txtDeudaActual.PlaceholderText = "0.00";
            txtDeudaActual.Rounding = new Padding(15);
            txtDeudaActual.Size = new Size(165, 32);
            txtDeudaActual.TabIndex = 4;
            txtDeudaActual.TextOffset = new Size(0, 0);
            txtDeudaActual.UnderlinedStyle = true;
            // 
            // lblDeudaActual
            // 
            lblDeudaActual.AutoSize = true;
            lblDeudaActual.BackColor = Color.Transparent;
            lblDeudaActual.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            lblDeudaActual.ForeColor = Color.DimGray;
            lblDeudaActual.Location = new Point(192, 30);
            lblDeudaActual.Name = "lblDeudaActual";
            lblDeudaActual.Size = new Size(77, 13);
            lblDeudaActual.TabIndex = 5;
            lblDeudaActual.Text = "Deuda Actual";
            // 
            // txtLimiteCredito
            // 
            txtLimiteCredito.BackColor = Color.Transparent;
            txtLimiteCredito.BackgroundColor = Color.White;
            txtLimiteCredito.Content = "";
            txtLimiteCredito.FocusBackgroundColor = Color.White;
            txtLimiteCredito.FocusImageTint = Color.White;
            txtLimiteCredito.FocusOutlineColor = SystemColors.MenuHighlight;
            txtLimiteCredito.Font = new Font("Segoe UI", 10F);
            txtLimiteCredito.ForeColor = Color.Black;
            txtLimiteCredito.Image = null;
            txtLimiteCredito.ImageExpand = new Point(0, 0);
            txtLimiteCredito.ImageOffset = new Point(0, 0);
            txtLimiteCredito.Location = new Point(12, 48);
            txtLimiteCredito.Margin = new Padding(4);
            txtLimiteCredito.Multiline = false;
            txtLimiteCredito.Name = "txtLimiteCredito";
            txtLimiteCredito.NormalImageTint = Color.White;
            txtLimiteCredito.OutlineColor = Color.DarkGray;
            txtLimiteCredito.Padding = new Padding(18, 7, 18, 0);
            txtLimiteCredito.PasswordChar = false;
            txtLimiteCredito.PlaceholderColor = Color.Silver;
            txtLimiteCredito.PlaceholderText = "0.00";
            txtLimiteCredito.Rounding = new Padding(15);
            txtLimiteCredito.Size = new Size(165, 32);
            txtLimiteCredito.TabIndex = 6;
            txtLimiteCredito.TextOffset = new Size(0, 0);
            txtLimiteCredito.UnderlinedStyle = true;
            // 
            // lblLimiteCredito
            // 
            lblLimiteCredito.AutoSize = true;
            lblLimiteCredito.BackColor = Color.Transparent;
            lblLimiteCredito.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            lblLimiteCredito.ForeColor = Color.DimGray;
            lblLimiteCredito.Location = new Point(12, 30);
            lblLimiteCredito.Name = "lblLimiteCredito";
            lblLimiteCredito.Size = new Size(96, 13);
            lblLimiteCredito.TabIndex = 7;
            lblLimiteCredito.Text = "Límite de Crédito";
            // 
            // lblPanelCredito
            // 
            lblPanelCredito.AutoSize = true;
            lblPanelCredito.BackColor = Color.Transparent;
            lblPanelCredito.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPanelCredito.ForeColor = Color.DimGray;
            lblPanelCredito.Location = new Point(12, 10);
            lblPanelCredito.Name = "lblPanelCredito";
            lblPanelCredito.Size = new Size(109, 15);
            lblPanelCredito.TabIndex = 8;
            lblPanelCredito.Text = "Datos de la Tarjeta";
            // 
            // cuiPanel6
            // 
            cuiPanel6.Controls.Add(cuiTextBox3);
            cuiPanel6.Controls.Add(label8);
            cuiPanel6.Location = new Point(12, 254);
            cuiPanel6.Name = "cuiPanel6";
            cuiPanel6.OutlineThickness = 1F;
            cuiPanel6.PanelColor = Color.White;
            cuiPanel6.PanelOutlineColor = Color.Gray;
            cuiPanel6.Rounding = new Padding(15);
            cuiPanel6.Size = new Size(369, 134);
            cuiPanel6.TabIndex = 10;
            // 
            // cuiTextBox3
            // 
            cuiTextBox3.BackColor = Color.Transparent;
            cuiTextBox3.BackgroundColor = Color.White;
            cuiTextBox3.Content = "";
            cuiTextBox3.FocusBackgroundColor = Color.White;
            cuiTextBox3.FocusImageTint = Color.White;
            cuiTextBox3.FocusOutlineColor = SystemColors.MenuHighlight;
            cuiTextBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox3.ForeColor = Color.Black;
            cuiTextBox3.Image = null;
            cuiTextBox3.ImageExpand = new Point(0, 0);
            cuiTextBox3.ImageOffset = new Point(0, 0);
            cuiTextBox3.Location = new Point(17, 78);
            cuiTextBox3.Margin = new Padding(4);
            cuiTextBox3.Multiline = false;
            cuiTextBox3.Name = "cuiTextBox3";
            cuiTextBox3.NormalImageTint = Color.White;
            cuiTextBox3.OutlineColor = Color.DarkGray;
            cuiTextBox3.Padding = new Padding(20, 8, 20, 0);
            cuiTextBox3.PasswordChar = false;
            cuiTextBox3.PlaceholderColor = Color.Black;
            cuiTextBox3.PlaceholderText = "0";
            cuiTextBox3.Rounding = new Padding(15);
            cuiTextBox3.Size = new Size(340, 36);
            cuiTextBox3.TabIndex = 7;
            cuiTextBox3.TextOffset = new Size(0, 0);
            cuiTextBox3.UnderlinedStyle = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(17, 44);
            label8.Name = "label8";
            label8.Size = new Size(85, 17);
            label8.TabIndex = 6;
            label8.Text = "Saldo Actual";
            // 
            // cuiCheckbox1
            // 
            cuiCheckbox1.BackColor = Color.White;
            cuiCheckbox1.Checked = false;
            cuiCheckbox1.CheckedForeground = Color.FromArgb(255, 106, 0);
            cuiCheckbox1.CheckedOutlineColor = Color.FromArgb(255, 106, 0);
            cuiCheckbox1.CheckedSymbolColor = Color.RoyalBlue;
            cuiCheckbox1.Content = "Cuenta Activa";
            cuiCheckbox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiCheckbox1.ForeColor = Color.Black;
            cuiCheckbox1.Location = new Point(12, 210);
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
            // cuiComboBox3
            // 
            cuiComboBox3.BackColor = Color.Transparent;
            cuiComboBox3.BackgroundColor = Color.FromArgb(255, 255, 255);
            cuiComboBox3.DropDownBackgroundColor = Color.White;
            cuiComboBox3.DropDownForeColor = Color.FromArgb(27, 27, 27);
            cuiComboBox3.ExpandArrowColor = Color.DimGray;
            cuiComboBox3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiComboBox3.ForeColor = Color.Gray;
            cuiComboBox3.Items = new string[]
    {
    "USD",
    "NIO"
    };
            cuiComboBox3.Location = new Point(199, 147);
            cuiComboBox3.Margin = new Padding(5, 4, 5, 4);
            cuiComboBox3.MaxDropDownHeight = 240;
            cuiComboBox3.Name = "cuiComboBox3";
            cuiComboBox3.NoSelectionText = "None";
            cuiComboBox3.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiComboBox3.OutlineThickness = 1F;
            cuiComboBox3.Rounding = 8;
            cuiComboBox3.SelectedIndex = 0;
            cuiComboBox3.SelectedItem = "USD";
            cuiComboBox3.Size = new Size(177, 36);
            cuiComboBox3.SortAlphabetically = true;
            cuiComboBox3.TabIndex = 7;
            // 
            // cuiComboBox2
            // 
            cuiComboBox2.BackColor = Color.Transparent;
            cuiComboBox2.BackgroundColor = Color.FromArgb(255, 255, 255);
            cuiComboBox2.DropDownBackgroundColor = Color.White;
            cuiComboBox2.DropDownForeColor = Color.FromArgb(27, 27, 27);
            cuiComboBox2.ExpandArrowColor = Color.DimGray;
            cuiComboBox2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiComboBox2.ForeColor = Color.Gray;
            cuiComboBox2.Items = new string[]
    {
    "Efectivo",
    "Debito",
    "Credito"
    };
            cuiComboBox2.Location = new Point(12, 147);
            cuiComboBox2.Margin = new Padding(5, 4, 5, 4);
            cuiComboBox2.MaxDropDownHeight = 240;
            cuiComboBox2.Name = "cuiComboBox2";
            cuiComboBox2.NoSelectionText = "None";
            cuiComboBox2.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiComboBox2.OutlineThickness = 1F;
            cuiComboBox2.Rounding = 8;
            cuiComboBox2.SelectedIndex = 0;
            cuiComboBox2.SelectedItem = "Efectivo";
            cuiComboBox2.Size = new Size(177, 36);
            cuiComboBox2.SortAlphabetically = false;
            cuiComboBox2.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(12, 126);
            label6.Name = "label6";
            label6.Size = new Size(102, 17);
            label6.TabIndex = 5;
            label6.Text = "Tipo de Cuenta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(199, 126);
            label5.Name = "label5";
            label5.Size = new Size(58, 17);
            label5.TabIndex = 4;
            label5.Text = "Moneda";
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
            label3.Size = new Size(118, 21);
            label3.TabIndex = 1;
            label3.Text = "Nueva Cuenta";
            // 
            // FrmCuentas
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
            Name = "FrmCuentas";
            Text = "FrmCuentas";
            Load += FrmCuentas_Load;
            pnlCardLiquidez.ResumeLayout(false);
            pnlCardLiquidez.PerformLayout();
            pnlCardDeuda.ResumeLayout(false);
            pnlCardDeuda.PerformLayout();
            pnlCardCredito.ResumeLayout(false);
            pnlCardCredito.PerformLayout();
            cuiPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).EndInit();
            cuiPanel5.ResumeLayout(false);
            cuiPanel5.PerformLayout();
            cuiPanel7.ResumeLayout(false);
            cuiPanel7.PerformLayout();
            cuiPanel6.ResumeLayout(false);
            cuiPanel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CuoreUI.Controls.cuiPanel pnlCardLiquidez;
        private CuoreUI.Controls.cuiPanel pnlCardDeuda;
        private CuoreUI.Controls.cuiPanel pnlCardCredito;
        private CuoreUI.Controls.cuiPanel cuiPanel4;
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private CuoreUI.Controls.cuiPanel cuiPanel5;
        private CuoreUI.Controls.cuiComboBox ComboboxBuscarPorTipo;
        private DataGridView dgvCuentas;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private Label label3;
        private CuoreUI.Controls.cuiComboBox cuiComboBox3;
        private CuoreUI.Controls.cuiComboBox cuiComboBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private CuoreUI.Controls.cuiTextBox cuiTextBox2;
        // Panel Débito/Efectivo
        private CuoreUI.Controls.cuiPanel cuiPanel6;
        private CuoreUI.Controls.cuiCheckbox cuiCheckbox1;
        private CuoreUI.Controls.cuiButton cuiButton3;
        private Label label7;
        private CuoreUI.Controls.cuiTextBox cuiTextBox3;
        private Label label8;
        private CuoreUI.Controls.cuiButton cuiButton4;
        // Panel Crédito (NUEVO)
        private CuoreUI.Controls.cuiPanel cuiPanel7;
        private Label lblPanelCredito;
        private Label lblLimiteCredito;
        private Label lblDeudaActual;
        private Label lblDiaCorte;
        private Label lblDiaPago;
        private CuoreUI.Controls.cuiTextBox txtLimiteCredito;
        private CuoreUI.Controls.cuiTextBox txtDeudaActual;
        private CuoreUI.Controls.cuiTextBox txtDiaCorte;
        private CuoreUI.Controls.cuiTextBox txtDiaPago;
        private Label lblTituloLiquidez;
        private Label lblMontoLiquidez;
        private Label lblTituloDeuda;
        private Label lblMontoDeuda;
        private Label lblMontoCredito;
        private Label lblTituloCredito;
    }
}