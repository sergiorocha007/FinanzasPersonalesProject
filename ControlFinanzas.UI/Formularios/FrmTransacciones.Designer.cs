namespace ControlFinanzas.UI.Formularios
{
    partial class FrmTransacciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransacciones));
            label2 = new Label();
            label1 = new Label();
            cuiPanel5 = new CuoreUI.Controls.cuiPanel();
            cuiPictureBox4 = new CuoreUI.Controls.cuiPictureBox();
            cmbCategoria = new CuoreUI.Controls.cuiComboBox();
            label7 = new Label();
            txtDescripcion = new CuoreUI.Controls.cuiTextBox();
            label10 = new Label();
            cmbCuentaDestino = new CuoreUI.Controls.cuiComboBox();
            label5 = new Label();
            btnLimpiar = new CuoreUI.Controls.cuiButton();
            btnTransferir = new CuoreUI.Controls.cuiButton();
            cmbCuentaOrigen = new CuoreUI.Controls.cuiComboBox();
            label6 = new Label();
            label3 = new Label();
            cuiPanel8 = new CuoreUI.Controls.cuiPanel();
            dgvTransferencias = new DataGridView();
            CuentaOrigen = new DataGridViewTextBoxColumn();
            CuentaDestino = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            label4 = new Label();
            cmbFiltrarCuenta = new CuoreUI.Controls.cuiComboBox();
            label16 = new Label();
            cuiPanel9 = new CuoreUI.Controls.cuiPanel();
            cuiPanel3 = new CuoreUI.Controls.cuiPanel();
            cuiPanel7 = new CuoreUI.Controls.cuiPanel();
            cuiPictureBox3 = new CuoreUI.Controls.cuiPictureBox();
            label13 = new Label();
            lblTotalTransferido = new Label();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            cuiPanel6 = new CuoreUI.Controls.cuiPanel();
            cuiPictureBox2 = new CuoreUI.Controls.cuiPictureBox();
            label11 = new Label();
            lblSaldoDestino = new Label();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            cuiPanel4 = new CuoreUI.Controls.cuiPanel();
            cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            lblTituloCredito = new Label();
            lblSaldoOrigen = new Label();
            dtpFecha = new CuoreUI.Controls.cuiCalendarDatePicker();
            label9 = new Label();
            label8 = new Label();
            txtMonto = new CuoreUI.Controls.cuiTextBox();
            cmbTipoMoviento = new CuoreUI.Controls.cuiComboBox();
            label12 = new Label();
            cuiPanel5.SuspendLayout();
            cuiPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransferencias).BeginInit();
            cuiPanel9.SuspendLayout();
            cuiPanel3.SuspendLayout();
            cuiPanel7.SuspendLayout();
            cuiPanel2.SuspendLayout();
            cuiPanel6.SuspendLayout();
            cuiPanel1.SuspendLayout();
            cuiPanel4.SuspendLayout();
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
            label2.Size = new Size(389, 20);
            label2.TabIndex = 3;
            label2.Text = "Mueve dinero entre tus cuentas de forma rapida y segura.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 25);
            label1.Name = "label1";
            label1.Size = new Size(262, 30);
            label1.TabIndex = 2;
            label1.Text = "Gestion de Transferencias";
            // 
            // cuiPanel5
            // 
            cuiPanel5.Controls.Add(cmbTipoMoviento);
            cuiPanel5.Controls.Add(label12);
            cuiPanel5.Controls.Add(dtpFecha);
            cuiPanel5.Controls.Add(label9);
            cuiPanel5.Controls.Add(label8);
            cuiPanel5.Controls.Add(txtMonto);
            cuiPanel5.Controls.Add(cuiPictureBox4);
            cuiPanel5.Controls.Add(cmbCategoria);
            cuiPanel5.Controls.Add(label7);
            cuiPanel5.Controls.Add(txtDescripcion);
            cuiPanel5.Controls.Add(label10);
            cuiPanel5.Controls.Add(cmbCuentaDestino);
            cuiPanel5.Controls.Add(label5);
            cuiPanel5.Controls.Add(btnLimpiar);
            cuiPanel5.Controls.Add(btnTransferir);
            cuiPanel5.Controls.Add(cmbCuentaOrigen);
            cuiPanel5.Controls.Add(label6);
            cuiPanel5.Controls.Add(label3);
            cuiPanel5.Location = new Point(18, 85);
            cuiPanel5.Name = "cuiPanel5";
            cuiPanel5.OutlineThickness = 1F;
            cuiPanel5.PanelColor = Color.White;
            cuiPanel5.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel5.Rounding = new Padding(15);
            cuiPanel5.Size = new Size(762, 337);
            cuiPanel5.TabIndex = 9;
            // 
            // cuiPictureBox4
            // 
            cuiPictureBox4.BackColor = Color.Transparent;
            cuiPictureBox4.Content = (Image)resources.GetObject("cuiPictureBox4.Content");
            cuiPictureBox4.ImageTint = Color.White;
            cuiPictureBox4.Location = new Point(383, 66);
            cuiPictureBox4.Margin = new Padding(4, 3, 4, 3);
            cuiPictureBox4.Name = "cuiPictureBox4";
            cuiPictureBox4.OutlineThickness = 1F;
            cuiPictureBox4.PanelOutlineColor = Color.Transparent;
            cuiPictureBox4.Rotation = 0;
            cuiPictureBox4.Rounding = new Padding(0);
            cuiPictureBox4.Size = new Size(29, 24);
            cuiPictureBox4.TabIndex = 13;
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.Transparent;
            cmbCategoria.BackgroundColor = Color.FromArgb(255, 255, 255);
            cmbCategoria.DropDownBackgroundColor = Color.White;
            cmbCategoria.DropDownForeColor = Color.FromArgb(27, 27, 27);
            cmbCategoria.ExpandArrowColor = Color.DimGray;
            cmbCategoria.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCategoria.ForeColor = Color.Gray;
            cmbCategoria.Items = new string[]
    {
    "Item 1",
    "Item 2",
    "Item 3"
    };
            cmbCategoria.Location = new Point(5, 131);
            cmbCategoria.Margin = new Padding(5, 4, 5, 4);
            cmbCategoria.MaxDropDownHeight = 240;
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.NoSelectionText = "None";
            cmbCategoria.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cmbCategoria.OutlineThickness = 1F;
            cmbCategoria.Rounding = 8;
            cmbCategoria.SelectedIndex = -1;
            cmbCategoria.SelectedItem = "";
            cmbCategoria.Size = new Size(359, 36);
            cmbCategoria.SortAlphabetically = true;
            cmbCategoria.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(12, 110);
            label7.Name = "label7";
            label7.Size = new Size(66, 17);
            label7.TabIndex = 29;
            label7.Text = "Categoria";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.Transparent;
            txtDescripcion.BackgroundColor = Color.WhiteSmoke;
            txtDescripcion.Content = "";
            txtDescripcion.FocusBackgroundColor = Color.White;
            txtDescripcion.FocusImageTint = Color.White;
            txtDescripcion.FocusOutlineColor = SystemColors.MenuHighlight;
            txtDescripcion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.ForeColor = Color.Black;
            txtDescripcion.Image = null;
            txtDescripcion.ImageExpand = new Point(0, 0);
            txtDescripcion.ImageOffset = new Point(0, 0);
            txtDescripcion.Location = new Point(12, 254);
            txtDescripcion.Margin = new Padding(4);
            txtDescripcion.Multiline = false;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.NormalImageTint = Color.White;
            txtDescripcion.OutlineColor = Color.Gray;
            txtDescripcion.Padding = new Padding(20, 8, 20, 0);
            txtDescripcion.PasswordChar = false;
            txtDescripcion.PlaceholderColor = Color.Gray;
            txtDescripcion.PlaceholderText = "Opcional";
            txtDescripcion.Rounding = new Padding(15);
            txtDescripcion.Size = new Size(745, 36);
            txtDescripcion.TabIndex = 28;
            txtDescripcion.TextOffset = new Size(0, 0);
            txtDescripcion.UnderlinedStyle = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(15, 233);
            label10.Name = "label10";
            label10.Size = new Size(77, 17);
            label10.TabIndex = 27;
            label10.Text = "Descripcion";
            // 
            // cmbCuentaDestino
            // 
            cmbCuentaDestino.BackColor = Color.Transparent;
            cmbCuentaDestino.BackgroundColor = Color.FromArgb(255, 255, 255);
            cmbCuentaDestino.DropDownBackgroundColor = Color.White;
            cmbCuentaDestino.DropDownForeColor = Color.FromArgb(27, 27, 27);
            cmbCuentaDestino.ExpandArrowColor = Color.DimGray;
            cmbCuentaDestino.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCuentaDestino.ForeColor = Color.DimGray;
            cmbCuentaDestino.Items = new string[]
    {
    "Item 1",
    "Item 2",
    "Item 3"
    };
            cmbCuentaDestino.Location = new Point(421, 63);
            cmbCuentaDestino.Margin = new Padding(5, 4, 5, 4);
            cmbCuentaDestino.MaxDropDownHeight = 240;
            cmbCuentaDestino.Name = "cmbCuentaDestino";
            cmbCuentaDestino.NoSelectionText = "None";
            cmbCuentaDestino.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cmbCuentaDestino.OutlineThickness = 1F;
            cmbCuentaDestino.Rounding = 8;
            cmbCuentaDestino.SelectedIndex = -1;
            cmbCuentaDestino.SelectedItem = "";
            cmbCuentaDestino.Size = new Size(336, 36);
            cmbCuentaDestino.SortAlphabetically = true;
            cmbCuentaDestino.TabIndex = 20;
            cmbCuentaDestino.SelectedIndexChanged += cmbCuentaDestino_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(421, 42);
            label5.Name = "label5";
            label5.Size = new Size(101, 17);
            label5.TabIndex = 19;
            label5.Text = "Cuenta Destino";
            // 
            // btnLimpiar
            // 
            btnLimpiar.CheckButton = false;
            btnLimpiar.Checked = false;
            btnLimpiar.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnLimpiar.CheckedForeColor = Color.White;
            btnLimpiar.CheckedImageTint = Color.White;
            btnLimpiar.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnLimpiar.Content = "Limpiar";
            btnLimpiar.DialogResult = DialogResult.None;
            btnLimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.HoverBackground = Color.Transparent;
            btnLimpiar.HoverForeColor = Color.DimGray;
            btnLimpiar.HoverImageTint = Color.DimGray;
            btnLimpiar.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnLimpiar.Image = null;
            btnLimpiar.ImageExpand = new Point(0, 0);
            btnLimpiar.Location = new Point(354, 297);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.NormalBackground = Color.WhiteSmoke;
            btnLimpiar.NormalForeColor = Color.Black;
            btnLimpiar.NormalImageTint = Color.Black;
            btnLimpiar.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnLimpiar.OutlineThickness = 1F;
            btnLimpiar.Padding = new Padding(12);
            btnLimpiar.PressedBackground = Color.WhiteSmoke;
            btnLimpiar.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnLimpiar.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnLimpiar.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnLimpiar.Rounding = new Padding(8);
            btnLimpiar.Size = new Size(182, 32);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.TextAlignment = StringAlignment.Center;
            btnLimpiar.TextPadding = 12;
            btnLimpiar.TextSpacing = 2;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnTransferir
            // 
            btnTransferir.CheckButton = false;
            btnTransferir.Checked = false;
            btnTransferir.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnTransferir.CheckedForeColor = Color.White;
            btnTransferir.CheckedImageTint = Color.White;
            btnTransferir.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnTransferir.Content = "Guardar";
            btnTransferir.DialogResult = DialogResult.None;
            btnTransferir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnTransferir.ForeColor = Color.White;
            btnTransferir.HoverBackground = Color.White;
            btnTransferir.HoverForeColor = Color.DimGray;
            btnTransferir.HoverImageTint = Color.DimGray;
            btnTransferir.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnTransferir.Image = null;
            btnTransferir.ImageExpand = new Point(0, 0);
            btnTransferir.Location = new Point(557, 297);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.NormalBackground = SystemColors.Highlight;
            btnTransferir.NormalForeColor = Color.White;
            btnTransferir.NormalImageTint = Color.Black;
            btnTransferir.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnTransferir.OutlineThickness = 1F;
            btnTransferir.Padding = new Padding(12);
            btnTransferir.PressedBackground = Color.WhiteSmoke;
            btnTransferir.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnTransferir.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnTransferir.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnTransferir.Rounding = new Padding(8);
            btnTransferir.Size = new Size(181, 32);
            btnTransferir.TabIndex = 12;
            btnTransferir.TextAlignment = StringAlignment.Center;
            btnTransferir.TextPadding = 12;
            btnTransferir.TextSpacing = 2;
            btnTransferir.Click += btnTransferir_Click;
            // 
            // cmbCuentaOrigen
            // 
            cmbCuentaOrigen.BackColor = Color.Transparent;
            cmbCuentaOrigen.BackgroundColor = Color.FromArgb(255, 255, 255);
            cmbCuentaOrigen.DropDownBackgroundColor = Color.White;
            cmbCuentaOrigen.DropDownForeColor = Color.FromArgb(27, 27, 27);
            cmbCuentaOrigen.ExpandArrowColor = Color.DimGray;
            cmbCuentaOrigen.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCuentaOrigen.ForeColor = Color.DimGray;
            cmbCuentaOrigen.Items = new string[]
    {
    "Item 1",
    "Item 2",
    "Item 3"
    };
            cmbCuentaOrigen.Location = new Point(5, 63);
            cmbCuentaOrigen.Margin = new Padding(5, 4, 5, 4);
            cmbCuentaOrigen.MaxDropDownHeight = 240;
            cmbCuentaOrigen.Name = "cmbCuentaOrigen";
            cmbCuentaOrigen.NoSelectionText = "None";
            cmbCuentaOrigen.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cmbCuentaOrigen.OutlineThickness = 1F;
            cmbCuentaOrigen.Rounding = 8;
            cmbCuentaOrigen.SelectedIndex = -1;
            cmbCuentaOrigen.SelectedItem = "";
            cmbCuentaOrigen.Size = new Size(369, 36);
            cmbCuentaOrigen.SortAlphabetically = true;
            cmbCuentaOrigen.TabIndex = 6;
            cmbCuentaOrigen.SelectedIndexChanged += cmbCuentaOrigen_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 42);
            label6.Name = "label6";
            label6.Size = new Size(96, 17);
            label6.TabIndex = 5;
            label6.Text = "Cuenta Origen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(166, 21);
            label3.TabIndex = 1;
            label3.Text = "Nueva Transferencia";
            // 
            // cuiPanel8
            // 
            cuiPanel8.Controls.Add(dgvTransferencias);
            cuiPanel8.Controls.Add(label4);
            cuiPanel8.Controls.Add(cmbFiltrarCuenta);
            cuiPanel8.Controls.Add(label16);
            cuiPanel8.Location = new Point(18, 456);
            cuiPanel8.Name = "cuiPanel8";
            cuiPanel8.OutlineThickness = 1F;
            cuiPanel8.PanelColor = Color.White;
            cuiPanel8.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel8.Rounding = new Padding(15);
            cuiPanel8.Size = new Size(1133, 277);
            cuiPanel8.TabIndex = 29;
            // 
            // dgvTransferencias
            // 
            dgvTransferencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransferencias.Columns.AddRange(new DataGridViewColumn[] { CuentaOrigen, CuentaDestino, Monto, Descripcion, Fecha, Categoria });
            dgvTransferencias.Location = new Point(19, 39);
            dgvTransferencias.Name = "dgvTransferencias";
            dgvTransferencias.Size = new Size(1099, 240);
            dgvTransferencias.TabIndex = 30;
            // 
            // CuentaOrigen
            // 
            CuentaOrigen.HeaderText = "Desde";
            CuentaOrigen.Name = "CuentaOrigen";
            // 
            // CuentaDestino
            // 
            CuentaDestino.HeaderText = "Hacia";
            CuentaDestino.Name = "CuentaDestino";
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(790, 12);
            label4.Name = "label4";
            label4.Size = new Size(121, 17);
            label4.TabIndex = 29;
            label4.Text = "Filtrar por Cuentas";
            // 
            // cmbFiltrarCuenta
            // 
            cmbFiltrarCuenta.BackColor = Color.Transparent;
            cmbFiltrarCuenta.BackgroundColor = Color.FromArgb(255, 255, 255);
            cmbFiltrarCuenta.DropDownBackgroundColor = Color.White;
            cmbFiltrarCuenta.DropDownForeColor = Color.FromArgb(27, 27, 27);
            cmbFiltrarCuenta.ExpandArrowColor = Color.DimGray;
            cmbFiltrarCuenta.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbFiltrarCuenta.ForeColor = Color.Gray;
            cmbFiltrarCuenta.Items = new string[]
    {
    "Item 1",
    "Item 2",
    "Item 3"
    };
            cmbFiltrarCuenta.Location = new Point(915, 9);
            cmbFiltrarCuenta.Margin = new Padding(5, 4, 5, 4);
            cmbFiltrarCuenta.MaxDropDownHeight = 240;
            cmbFiltrarCuenta.Name = "cmbFiltrarCuenta";
            cmbFiltrarCuenta.NoSelectionText = "None";
            cmbFiltrarCuenta.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cmbFiltrarCuenta.OutlineThickness = 1F;
            cmbFiltrarCuenta.Rounding = 8;
            cmbFiltrarCuenta.SelectedIndex = -1;
            cmbFiltrarCuenta.SelectedItem = "";
            cmbFiltrarCuenta.Size = new Size(213, 21);
            cmbFiltrarCuenta.SortAlphabetically = true;
            cmbFiltrarCuenta.TabIndex = 7;
            cmbFiltrarCuenta.SelectedIndexChanged += cmbFiltrarCuenta_SelectedIndexChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(12, 9);
            label16.Name = "label16";
            label16.Size = new Size(211, 21);
            label16.TabIndex = 1;
            label16.Text = "Historial de Transferencias";
            // 
            // cuiPanel9
            // 
            cuiPanel9.Controls.Add(cuiPanel3);
            cuiPanel9.Controls.Add(cuiPanel2);
            cuiPanel9.Controls.Add(cuiPanel1);
            cuiPanel9.Location = new Point(792, 85);
            cuiPanel9.Name = "cuiPanel9";
            cuiPanel9.OutlineThickness = 1F;
            cuiPanel9.PanelColor = Color.White;
            cuiPanel9.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel9.Rounding = new Padding(15);
            cuiPanel9.Size = new Size(354, 337);
            cuiPanel9.TabIndex = 13;
            // 
            // cuiPanel3
            // 
            cuiPanel3.Controls.Add(cuiPanel7);
            cuiPanel3.Controls.Add(label13);
            cuiPanel3.Controls.Add(lblTotalTransferido);
            cuiPanel3.Location = new Point(4, 242);
            cuiPanel3.Name = "cuiPanel3";
            cuiPanel3.OutlineThickness = 1F;
            cuiPanel3.PanelColor = Color.FromArgb(250, 224, 255);
            cuiPanel3.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel3.Rounding = new Padding(15);
            cuiPanel3.Size = new Size(345, 90);
            cuiPanel3.TabIndex = 15;
            // 
            // cuiPanel7
            // 
            cuiPanel7.BackColor = Color.Transparent;
            cuiPanel7.Controls.Add(cuiPictureBox3);
            cuiPanel7.Location = new Point(8, 11);
            cuiPanel7.Name = "cuiPanel7";
            cuiPanel7.OutlineThickness = 1F;
            cuiPanel7.PanelColor = Color.DarkOrchid;
            cuiPanel7.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel7.Rounding = new Padding(15);
            cuiPanel7.Size = new Size(36, 33);
            cuiPanel7.TabIndex = 13;
            // 
            // cuiPictureBox3
            // 
            cuiPictureBox3.BackColor = Color.Transparent;
            cuiPictureBox3.Content = (Image)resources.GetObject("cuiPictureBox3.Content");
            cuiPictureBox3.ImageTint = Color.White;
            cuiPictureBox3.Location = new Point(2, 0);
            cuiPictureBox3.Margin = new Padding(4, 3, 4, 3);
            cuiPictureBox3.Name = "cuiPictureBox3";
            cuiPictureBox3.OutlineThickness = 1F;
            cuiPictureBox3.PanelOutlineColor = Color.Transparent;
            cuiPictureBox3.Rotation = 0;
            cuiPictureBox3.Rounding = new Padding(0);
            cuiPictureBox3.Size = new Size(31, 32);
            cuiPictureBox3.TabIndex = 12;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(55, 11);
            label13.Name = "label13";
            label13.Size = new Size(210, 19);
            label13.TabIndex = 11;
            label13.Text = "Total Transferidos este Mes";
            // 
            // lblTotalTransferido
            // 
            lblTotalTransferido.AutoSize = true;
            lblTotalTransferido.BackColor = Color.Transparent;
            lblTotalTransferido.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold);
            lblTotalTransferido.ForeColor = Color.DimGray;
            lblTotalTransferido.Location = new Point(80, 37);
            lblTotalTransferido.Name = "lblTotalTransferido";
            lblTotalTransferido.Size = new Size(61, 26);
            lblTotalTransferido.TabIndex = 8;
            lblTotalTransferido.Text = "$ 0.0";
            // 
            // cuiPanel2
            // 
            cuiPanel2.Controls.Add(cuiPanel6);
            cuiPanel2.Controls.Add(label11);
            cuiPanel2.Controls.Add(lblSaldoDestino);
            cuiPanel2.Location = new Point(4, 119);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.FromArgb(229, 255, 232);
            cuiPanel2.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel2.Rounding = new Padding(15);
            cuiPanel2.Size = new Size(345, 90);
            cuiPanel2.TabIndex = 14;
            // 
            // cuiPanel6
            // 
            cuiPanel6.BackColor = Color.Transparent;
            cuiPanel6.Controls.Add(cuiPictureBox2);
            cuiPanel6.Location = new Point(8, 14);
            cuiPanel6.Name = "cuiPanel6";
            cuiPanel6.OutlineThickness = 1F;
            cuiPanel6.PanelColor = Color.MediumSeaGreen;
            cuiPanel6.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel6.Rounding = new Padding(15);
            cuiPanel6.Size = new Size(36, 34);
            cuiPanel6.TabIndex = 13;
            // 
            // cuiPictureBox2
            // 
            cuiPictureBox2.BackColor = Color.Transparent;
            cuiPictureBox2.Content = (Image)resources.GetObject("cuiPictureBox2.Content");
            cuiPictureBox2.ImageTint = Color.White;
            cuiPictureBox2.Location = new Point(2, 1);
            cuiPictureBox2.Margin = new Padding(4, 3, 4, 3);
            cuiPictureBox2.Name = "cuiPictureBox2";
            cuiPictureBox2.OutlineThickness = 1F;
            cuiPictureBox2.PanelOutlineColor = Color.Transparent;
            cuiPictureBox2.Rotation = 0;
            cuiPictureBox2.Rounding = new Padding(0);
            cuiPictureBox2.Size = new Size(31, 33);
            cuiPictureBox2.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(55, 14);
            label11.Name = "label11";
            label11.Size = new Size(166, 19);
            label11.TabIndex = 11;
            label11.Text = "Saldo Cuenta Destino";
            // 
            // lblSaldoDestino
            // 
            lblSaldoDestino.AutoSize = true;
            lblSaldoDestino.BackColor = Color.Transparent;
            lblSaldoDestino.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold);
            lblSaldoDestino.ForeColor = Color.DimGray;
            lblSaldoDestino.Location = new Point(80, 40);
            lblSaldoDestino.Name = "lblSaldoDestino";
            lblSaldoDestino.Size = new Size(61, 26);
            lblSaldoDestino.TabIndex = 8;
            lblSaldoDestino.Text = "$ 0.0";
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(cuiPanel4);
            cuiPanel1.Controls.Add(lblTituloCredito);
            cuiPanel1.Controls.Add(lblSaldoOrigen);
            cuiPanel1.Location = new Point(4, 5);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.FromArgb(194, 228, 255);
            cuiPanel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel1.Rounding = new Padding(15);
            cuiPanel1.Size = new Size(345, 90);
            cuiPanel1.TabIndex = 13;
            // 
            // cuiPanel4
            // 
            cuiPanel4.BackColor = Color.Transparent;
            cuiPanel4.Controls.Add(cuiPictureBox1);
            cuiPanel4.Location = new Point(8, 16);
            cuiPanel4.Name = "cuiPanel4";
            cuiPanel4.OutlineThickness = 1F;
            cuiPanel4.PanelColor = SystemColors.Highlight;
            cuiPanel4.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel4.Rounding = new Padding(15);
            cuiPanel4.Size = new Size(41, 36);
            cuiPanel4.TabIndex = 12;
            // 
            // cuiPictureBox1
            // 
            cuiPictureBox1.BackColor = Color.Transparent;
            cuiPictureBox1.Content = (Image)resources.GetObject("cuiPictureBox1.Content");
            cuiPictureBox1.ImageTint = Color.White;
            cuiPictureBox1.Location = new Point(5, 1);
            cuiPictureBox1.Margin = new Padding(4, 3, 4, 3);
            cuiPictureBox1.Name = "cuiPictureBox1";
            cuiPictureBox1.OutlineThickness = 1F;
            cuiPictureBox1.PanelOutlineColor = Color.Transparent;
            cuiPictureBox1.Rotation = 0;
            cuiPictureBox1.Rounding = new Padding(0);
            cuiPictureBox1.Size = new Size(31, 33);
            cuiPictureBox1.TabIndex = 12;
            // 
            // lblTituloCredito
            // 
            lblTituloCredito.AutoSize = true;
            lblTituloCredito.BackColor = Color.Transparent;
            lblTituloCredito.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            lblTituloCredito.ForeColor = SystemColors.ActiveCaptionText;
            lblTituloCredito.Location = new Point(55, 16);
            lblTituloCredito.Name = "lblTituloCredito";
            lblTituloCredito.Size = new Size(182, 19);
            lblTituloCredito.TabIndex = 11;
            lblTituloCredito.Text = "Saldo Cuenta de Origen";
            // 
            // lblSaldoOrigen
            // 
            lblSaldoOrigen.AutoSize = true;
            lblSaldoOrigen.BackColor = Color.Transparent;
            lblSaldoOrigen.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold);
            lblSaldoOrigen.ForeColor = Color.DimGray;
            lblSaldoOrigen.Location = new Point(80, 42);
            lblSaldoOrigen.Name = "lblSaldoOrigen";
            lblSaldoOrigen.Size = new Size(61, 26);
            lblSaldoOrigen.TabIndex = 8;
            lblSaldoOrigen.Text = "$ 0.0";
            // 
            // dtpFecha
            // 
            dtpFecha.BackColor = Color.White;
            dtpFecha.Content = new DateTime(2026, 11, 4, 0, 0, 0, 0);
            dtpFecha.EnableThemeChangeButton = true;
            dtpFecha.Font = new Font("Segoe UI", 9.75F);
            dtpFecha.ForeColor = Color.Gray;
            dtpFecha.HoverBackground = Color.FromArgb(50, 128, 128, 128);
            dtpFecha.HoverOutline = Color.FromArgb(180, 128, 128, 128);
            dtpFecha.Icon = (Image)resources.GetObject("dtpFecha.Icon");
            dtpFecha.IconTint = Color.Gray;
            dtpFecha.Location = new Point(398, 191);
            dtpFecha.Margin = new Padding(4, 3, 4, 3);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.NormalBackground = Color.FromArgb(32, 128, 128, 128);
            dtpFecha.NormalOutline = Color.DarkGray;
            dtpFecha.OutlineThickness = 1.5F;
            dtpFecha.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom;
            dtpFecha.PressedBackground = Color.FromArgb(80, 128, 128, 128);
            dtpFecha.PressedOutline = Color.FromArgb(210, 128, 128, 128);
            dtpFecha.Rounding = 8;
            dtpFecha.ShowIcon = true;
            dtpFecha.Size = new Size(359, 36);
            dtpFecha.TabIndex = 34;
            dtpFecha.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(405, 172);
            label9.Name = "label9";
            label9.Size = new Size(145, 17);
            label9.TabIndex = 33;
            label9.Text = "Fecha de Transferencia";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(12, 172);
            label8.Name = "label8";
            label8.Size = new Size(49, 17);
            label8.TabIndex = 32;
            label8.Text = "Monto";
            // 
            // txtMonto
            // 
            txtMonto.BackColor = Color.Transparent;
            txtMonto.BackgroundColor = Color.WhiteSmoke;
            txtMonto.Content = "";
            txtMonto.FocusBackgroundColor = Color.White;
            txtMonto.FocusImageTint = Color.White;
            txtMonto.FocusOutlineColor = SystemColors.MenuHighlight;
            txtMonto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMonto.ForeColor = Color.DimGray;
            txtMonto.Image = null;
            txtMonto.ImageExpand = new Point(0, 0);
            txtMonto.ImageOffset = new Point(0, 0);
            txtMonto.Location = new Point(5, 193);
            txtMonto.Margin = new Padding(4);
            txtMonto.Multiline = false;
            txtMonto.Name = "txtMonto";
            txtMonto.NormalImageTint = Color.White;
            txtMonto.OutlineColor = Color.Gray;
            txtMonto.Padding = new Padding(20, 8, 20, 0);
            txtMonto.PasswordChar = false;
            txtMonto.PlaceholderColor = Color.Gray;
            txtMonto.PlaceholderText = "$";
            txtMonto.Rounding = new Padding(15);
            txtMonto.Size = new Size(384, 36);
            txtMonto.TabIndex = 31;
            txtMonto.TextOffset = new Size(0, 0);
            txtMonto.UnderlinedStyle = true;
            // 
            // cmbTipoMoviento
            // 
            cmbTipoMoviento.BackColor = Color.Transparent;
            cmbTipoMoviento.BackgroundColor = Color.FromArgb(255, 255, 255);
            cmbTipoMoviento.DropDownBackgroundColor = Color.White;
            cmbTipoMoviento.DropDownForeColor = Color.FromArgb(27, 27, 27);
            cmbTipoMoviento.ExpandArrowColor = Color.DimGray;
            cmbTipoMoviento.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbTipoMoviento.ForeColor = Color.Gray;
            cmbTipoMoviento.Items = new string[]
    {
    "Ingreso",
    "Gasto",
    "Transferencia"
    };
            cmbTipoMoviento.Location = new Point(419, 131);
            cmbTipoMoviento.Margin = new Padding(5, 4, 5, 4);
            cmbTipoMoviento.MaxDropDownHeight = 240;
            cmbTipoMoviento.Name = "cmbTipoMoviento";
            cmbTipoMoviento.NoSelectionText = "None";
            cmbTipoMoviento.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cmbTipoMoviento.OutlineThickness = 1F;
            cmbTipoMoviento.Rounding = 8;
            cmbTipoMoviento.SelectedIndex = 0;
            cmbTipoMoviento.SelectedItem = "Ingreso";
            cmbTipoMoviento.Size = new Size(319, 36);
            cmbTipoMoviento.SortAlphabetically = true;
            cmbTipoMoviento.TabIndex = 36;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(426, 110);
            label12.Name = "label12";
            label12.Size = new Size(133, 17);
            label12.TabIndex = 35;
            label12.Text = "Tipo de Movimiento:";
            // 
            // FrmTransacciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1171, 745);
            Controls.Add(cuiPanel9);
            Controls.Add(cuiPanel8);
            Controls.Add(cuiPanel5);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmTransacciones";
            Text = "FrmTransacciones";
            Load += FrmTransferencias_Load;
            cuiPanel5.ResumeLayout(false);
            cuiPanel5.PerformLayout();
            cuiPanel8.ResumeLayout(false);
            cuiPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransferencias).EndInit();
            cuiPanel9.ResumeLayout(false);
            cuiPanel3.ResumeLayout(false);
            cuiPanel3.PerformLayout();
            cuiPanel7.ResumeLayout(false);
            cuiPanel2.ResumeLayout(false);
            cuiPanel2.PerformLayout();
            cuiPanel6.ResumeLayout(false);
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            cuiPanel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private CuoreUI.Controls.cuiPanel cuiPanel5;
        private CuoreUI.Controls.cuiComboBox cmbCuentaDestino;
        private Label label5;
        private CuoreUI.Controls.cuiButton btnLimpiar;
        private CuoreUI.Controls.cuiButton btnTransferir;
        private CuoreUI.Controls.cuiComboBox cmbCuentaOrigen;
        private Label label6;
        private Label label3;
        private CuoreUI.Controls.cuiTextBox txtDescripcion;
        private Label label10;
        private CuoreUI.Controls.cuiPanel cuiPanel8;
        private Label label16;
        private DataGridView dgvTransferencias;
        private Label label4;
        private CuoreUI.Controls.cuiComboBox cmbFiltrarCuenta;
        private CuoreUI.Controls.cuiComboBox cmbCategoria;
        private Label label7;
        private DataGridViewTextBoxColumn CuentaOrigen;
        private DataGridViewTextBoxColumn CuentaDestino;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Categoria;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox4;
        private CuoreUI.Controls.cuiPanel cuiPanel9;
        private CuoreUI.Controls.cuiPanel cuiPanel3;
        private CuoreUI.Controls.cuiPanel cuiPanel7;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox3;
        private Label label13;
        private Label lblTotalTransferido;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiPanel cuiPanel6;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
        private Label label11;
        private Label lblSaldoDestino;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiPanel cuiPanel4;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private Label lblTituloCredito;
        private Label lblSaldoOrigen;
        private CuoreUI.Controls.cuiComboBox cmbTipoMoviento;
        private Label label12;
        private CuoreUI.Controls.cuiCalendarDatePicker dtpFecha;
        private Label label9;
        private Label label8;
        private CuoreUI.Controls.cuiTextBox txtMonto;
    }
}