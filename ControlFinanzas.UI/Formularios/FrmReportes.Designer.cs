namespace ControlFinanzas.UI.Formularios
{
    partial class FrmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            label2 = new Label();
            label1 = new Label();
            tbcHistorialMovimientos = new TabControl();
            tabMovimientos = new TabPage();
            dgvReporteMovimientos = new DataGridView();
            colFecha = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colOrigen = new DataGridViewTextBoxColumn();
            colDestino = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colMonto = new DataGridViewTextBoxColumn();
            cuiPanel11 = new CuoreUI.Controls.cuiPanel();
            label10 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            cuiPanel5 = new CuoreUI.Controls.cuiPanel();
            lblTotalIngresosRep = new Label();
            label9 = new Label();
            cuiPanel6 = new CuoreUI.Controls.cuiPanel();
            pictureBox1 = new PictureBox();
            cuiPanel3 = new CuoreUI.Controls.cuiPanel();
            lblTotalGastosRep = new Label();
            label8 = new Label();
            cuiPanel7 = new CuoreUI.Controls.cuiPanel();
            pictureBox2 = new PictureBox();
            cuiPanel9 = new CuoreUI.Controls.cuiPanel();
            lblTotalTransferidoRep = new Label();
            lblTituloLiquidez = new Label();
            cuiPanel10 = new CuoreUI.Controls.cuiPanel();
            pictureBox3 = new PictureBox();
            cuiPanel4 = new CuoreUI.Controls.cuiPanel();
            lblFlujoNetoRep = new Label();
            label7 = new Label();
            cuiPanel8 = new CuoreUI.Controls.cuiPanel();
            pictureBox4 = new PictureBox();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            btnExportarMovimientos = new CuoreUI.Controls.cuiButton();
            btnFiltrarMovimientos = new CuoreUI.Controls.cuiButton();
            cmbCuentasMovimientos = new CuoreUI.Controls.cuiComboBox();
            label5 = new Label();
            cmbTipoMovimiento = new CuoreUI.Controls.cuiComboBox();
            label4 = new Label();
            dtpHastaMovimientos = new CuoreUI.Controls.cuiCalendarDatePicker();
            label3 = new Label();
            dtpDesdeMovimientos = new CuoreUI.Controls.cuiCalendarDatePicker();
            label6 = new Label();
            tabCategorias = new TabPage();
            dgvReporteCategorias = new DataGridView();
            colCatNombre = new DataGridViewTextBoxColumn();
            colCatTotal = new DataGridViewTextBoxColumn();
            colCatPorcentaje = new DataGridViewTextBoxColumn();
            colCatCantidad = new DataGridViewTextBoxColumn();
            colCatPromedio = new DataGridViewTextBoxColumn();
            cuiPanel19 = new CuoreUI.Controls.cuiPanel();
            label24 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            cuiPanel13 = new CuoreUI.Controls.cuiPanel();
            label16 = new Label();
            lblTotalGastoCatRep = new Label();
            label15 = new Label();
            cuiPanel14 = new CuoreUI.Controls.cuiPanel();
            pictureBox5 = new PictureBox();
            cuiPanel15 = new CuoreUI.Controls.cuiPanel();
            lblTopCategoriaRep = new Label();
            label18 = new Label();
            cuiPanel16 = new CuoreUI.Controls.cuiPanel();
            pictureBox6 = new PictureBox();
            cuiPanel17 = new CuoreUI.Controls.cuiPanel();
            label21 = new Label();
            lblNumTransaccionesCatRep = new Label();
            label23 = new Label();
            cuiPanel18 = new CuoreUI.Controls.cuiPanel();
            pictureBox7 = new PictureBox();
            cuiPanel12 = new CuoreUI.Controls.cuiPanel();
            btnExportarCat = new CuoreUI.Controls.cuiButton();
            btnFiltrarCat = new CuoreUI.Controls.cuiButton();
            cmbCuentasCat = new CuoreUI.Controls.cuiComboBox();
            label11 = new Label();
            dtpHastaCat = new CuoreUI.Controls.cuiCalendarDatePicker();
            label13 = new Label();
            dtpDesdeCat = new CuoreUI.Controls.cuiCalendarDatePicker();
            label14 = new Label();
            tabCuentas = new TabPage();
            dgvReporteCuentas = new DataGridView();
            colCuentaNombre = new DataGridViewTextBoxColumn();
            colCuentaTipo = new DataGridViewTextBoxColumn();
            colCuentaMoneda = new DataGridViewTextBoxColumn();
            colCuentaSaldo = new DataGridViewTextBoxColumn();
            colCuentaLimite = new DataGridViewTextBoxColumn();
            colCuentaDeuda = new DataGridViewTextBoxColumn();
            colCuentaDisponible = new DataGridViewTextBoxColumn();
            tableLayoutPanel3 = new TableLayoutPanel();
            cuiPanel22 = new CuoreUI.Controls.cuiPanel();
            label22 = new Label();
            lblLiquidezTotalRep = new Label();
            label20 = new Label();
            cuiPanel23 = new CuoreUI.Controls.cuiPanel();
            pictureBox8 = new PictureBox();
            cuiPanel24 = new CuoreUI.Controls.cuiPanel();
            label27 = new Label();
            lblDeudaTotalRep = new Label();
            label26 = new Label();
            cuiPanel25 = new CuoreUI.Controls.cuiPanel();
            pictureBox9 = new PictureBox();
            cuiPanel26 = new CuoreUI.Controls.cuiPanel();
            label30 = new Label();
            label29 = new Label();
            lblPatrimonioNetoRep = new Label();
            cuiPanel27 = new CuoreUI.Controls.cuiPanel();
            pictureBox10 = new PictureBox();
            cuiPanel21 = new CuoreUI.Controls.cuiPanel();
            label12 = new Label();
            cuiPanel20 = new CuoreUI.Controls.cuiPanel();
            btnExportarCuentas = new CuoreUI.Controls.cuiButton();
            btnRefrescarCuentas = new CuoreUI.Controls.cuiButton();
            label19 = new Label();
            lblTotalGastadoCategoriaTo = new Label();
            cuiPanel1.SuspendLayout();
            tbcHistorialMovimientos.SuspendLayout();
            tabMovimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteMovimientos).BeginInit();
            cuiPanel11.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            cuiPanel5.SuspendLayout();
            cuiPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            cuiPanel3.SuspendLayout();
            cuiPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            cuiPanel9.SuspendLayout();
            cuiPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            cuiPanel4.SuspendLayout();
            cuiPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            cuiPanel2.SuspendLayout();
            tabCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteCategorias).BeginInit();
            cuiPanel19.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            cuiPanel13.SuspendLayout();
            cuiPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            cuiPanel15.SuspendLayout();
            cuiPanel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            cuiPanel17.SuspendLayout();
            cuiPanel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            cuiPanel12.SuspendLayout();
            tabCuentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteCuentas).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            cuiPanel22.SuspendLayout();
            cuiPanel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            cuiPanel24.SuspendLayout();
            cuiPanel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            cuiPanel26.SuspendLayout();
            cuiPanel27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            cuiPanel21.SuspendLayout();
            cuiPanel20.SuspendLayout();
            SuspendLayout();
            // 
            // cuiPanel1
            // 
            cuiPanel1.BackColor = Color.Transparent;
            cuiPanel1.Controls.Add(label2);
            cuiPanel1.Controls.Add(label1);
            cuiPanel1.Dock = DockStyle.Top;
            cuiPanel1.Location = new Point(0, 0);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = SystemColors.Control;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel1.Rounding = new Padding(0);
            cuiPanel1.Size = new Size(1171, 63);
            cuiPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(26, 39);
            label2.Name = "label2";
            label2.Size = new Size(826, 20);
            label2.TabIndex = 2;
            label2.Text = "Audita tus movimientos históricos, analiza tus hábitos de consumo por categoría y Analiza el estado general de tus cuentas.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(319, 30);
            label1.TabIndex = 0;
            label1.Text = "Centro de Reportes Financieros";
            // 
            // tbcHistorialMovimientos
            // 
            tbcHistorialMovimientos.Controls.Add(tabMovimientos);
            tbcHistorialMovimientos.Controls.Add(tabCategorias);
            tbcHistorialMovimientos.Controls.Add(tabCuentas);
            tbcHistorialMovimientos.Dock = DockStyle.Fill;
            tbcHistorialMovimientos.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbcHistorialMovimientos.ItemSize = new Size(250, 25);
            tbcHistorialMovimientos.Location = new Point(0, 63);
            tbcHistorialMovimientos.Multiline = true;
            tbcHistorialMovimientos.Name = "tbcHistorialMovimientos";
            tbcHistorialMovimientos.SelectedIndex = 0;
            tbcHistorialMovimientos.Size = new Size(1171, 653);
            tbcHistorialMovimientos.SizeMode = TabSizeMode.Fixed;
            tbcHistorialMovimientos.TabIndex = 2;
            tbcHistorialMovimientos.Tag = "";
            // 
            // tabMovimientos
            // 
            tabMovimientos.BackColor = SystemColors.Control;
            tabMovimientos.Controls.Add(dgvReporteMovimientos);
            tabMovimientos.Controls.Add(cuiPanel11);
            tabMovimientos.Controls.Add(tableLayoutPanel1);
            tabMovimientos.Controls.Add(cuiPanel2);
            tabMovimientos.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabMovimientos.Location = new Point(4, 29);
            tabMovimientos.Name = "tabMovimientos";
            tabMovimientos.Padding = new Padding(3);
            tabMovimientos.Size = new Size(1163, 620);
            tabMovimientos.TabIndex = 0;
            tabMovimientos.Text = "Historial de Movimientos";
            // 
            // dgvReporteMovimientos
            // 
            dgvReporteMovimientos.AllowUserToAddRows = false;
            dgvReporteMovimientos.AllowUserToDeleteRows = false;
            dgvReporteMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteMovimientos.Columns.AddRange(new DataGridViewColumn[] { colFecha, colTipo, colOrigen, colDestino, colDescripcion, colMonto });
            dgvReporteMovimientos.Location = new Point(8, 325);
            dgvReporteMovimientos.Name = "dgvReporteMovimientos";
            dgvReporteMovimientos.ReadOnly = true;
            dgvReporteMovimientos.Size = new Size(1147, 287);
            dgvReporteMovimientos.TabIndex = 7;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha de Movimiento";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo";
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // colOrigen
            // 
            colOrigen.HeaderText = "Cuenta Origen";
            colOrigen.Name = "colOrigen";
            colOrigen.ReadOnly = true;
            // 
            // colDestino
            // 
            colDestino.HeaderText = "Cuenta Destino";
            colDestino.Name = "colDestino";
            colDestino.ReadOnly = true;
            // 
            // colDescripcion
            // 
            colDescripcion.HeaderText = "Descripcion";
            colDescripcion.Name = "colDescripcion";
            colDescripcion.ReadOnly = true;
            // 
            // colMonto
            // 
            colMonto.HeaderText = "Monto";
            colMonto.Name = "colMonto";
            colMonto.ReadOnly = true;
            // 
            // cuiPanel11
            // 
            cuiPanel11.Controls.Add(label10);
            cuiPanel11.Location = new Point(8, 277);
            cuiPanel11.Name = "cuiPanel11";
            cuiPanel11.OutlineThickness = 1F;
            cuiPanel11.PanelColor = Color.White;
            cuiPanel11.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel11.Rounding = new Padding(8);
            cuiPanel11.Size = new Size(1147, 48);
            cuiPanel11.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(14, 14);
            label10.Name = "label10";
            label10.Size = new Size(203, 21);
            label10.TabIndex = 3;
            label10.Text = "Historial de Movimientos";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(cuiPanel5, 0, 0);
            tableLayoutPanel1.Controls.Add(cuiPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(cuiPanel9, 3, 0);
            tableLayoutPanel1.Controls.Add(cuiPanel4, 2, 0);
            tableLayoutPanel1.Location = new Point(8, 127);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1147, 141);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // cuiPanel5
            // 
            cuiPanel5.Controls.Add(lblTotalIngresosRep);
            cuiPanel5.Controls.Add(label9);
            cuiPanel5.Controls.Add(cuiPanel6);
            cuiPanel5.Location = new Point(3, 3);
            cuiPanel5.Name = "cuiPanel5";
            cuiPanel5.OutlineThickness = 1F;
            cuiPanel5.PanelColor = Color.White;
            cuiPanel5.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel5.Rounding = new Padding(8);
            cuiPanel5.Size = new Size(275, 135);
            cuiPanel5.TabIndex = 5;
            // 
            // lblTotalIngresosRep
            // 
            lblTotalIngresosRep.AutoSize = true;
            lblTotalIngresosRep.BackColor = Color.Transparent;
            lblTotalIngresosRep.Font = new Font("Candara", 21.75F, FontStyle.Bold | FontStyle.Italic);
            lblTotalIngresosRep.ForeColor = Color.Green;
            lblTotalIngresosRep.Location = new Point(48, 80);
            lblTotalIngresosRep.Name = "lblTotalIngresosRep";
            lblTotalIngresosRep.Size = new Size(150, 36);
            lblTotalIngresosRep.TabIndex = 8;
            lblTotalIngresosRep.Text = "+ $7000.00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(24, 61);
            label9.Name = "label9";
            label9.Size = new Size(113, 19);
            label9.TabIndex = 2;
            label9.Text = "Total Ingresos";
            // 
            // cuiPanel6
            // 
            cuiPanel6.BackColor = Color.Transparent;
            cuiPanel6.Controls.Add(pictureBox1);
            cuiPanel6.Location = new Point(20, 10);
            cuiPanel6.Name = "cuiPanel6";
            cuiPanel6.OutlineThickness = 1F;
            cuiPanel6.PanelColor = Color.FromArgb(220, 250, 230);
            cuiPanel6.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel6.Rounding = new Padding(8);
            cuiPanel6.Size = new Size(42, 39);
            cuiPanel6.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 31);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cuiPanel3
            // 
            cuiPanel3.Controls.Add(lblTotalGastosRep);
            cuiPanel3.Controls.Add(label8);
            cuiPanel3.Controls.Add(cuiPanel7);
            cuiPanel3.Location = new Point(289, 3);
            cuiPanel3.Name = "cuiPanel3";
            cuiPanel3.OutlineThickness = 1F;
            cuiPanel3.PanelColor = Color.White;
            cuiPanel3.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel3.Rounding = new Padding(8);
            cuiPanel3.Size = new Size(275, 135);
            cuiPanel3.TabIndex = 6;
            // 
            // lblTotalGastosRep
            // 
            lblTotalGastosRep.AutoSize = true;
            lblTotalGastosRep.BackColor = Color.Transparent;
            lblTotalGastosRep.Font = new Font("Candara", 21.75F, FontStyle.Bold | FontStyle.Italic);
            lblTotalGastosRep.ForeColor = Color.Red;
            lblTotalGastosRep.Location = new Point(38, 80);
            lblTotalGastosRep.Name = "lblTotalGastosRep";
            lblTotalGastosRep.Size = new Size(142, 36);
            lblTotalGastosRep.TabIndex = 8;
            lblTotalGastosRep.Text = "- $7000.00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(24, 61);
            label8.Name = "label8";
            label8.Size = new Size(99, 19);
            label8.TabIndex = 2;
            label8.Text = "Total Gastos";
            // 
            // cuiPanel7
            // 
            cuiPanel7.BackColor = Color.Transparent;
            cuiPanel7.Controls.Add(pictureBox2);
            cuiPanel7.Location = new Point(20, 10);
            cuiPanel7.Name = "cuiPanel7";
            cuiPanel7.OutlineThickness = 1F;
            cuiPanel7.PanelColor = Color.FromArgb(250, 227, 229);
            cuiPanel7.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel7.Rounding = new Padding(8);
            cuiPanel7.Size = new Size(42, 39);
            cuiPanel7.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 31);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // cuiPanel9
            // 
            cuiPanel9.Controls.Add(lblTotalTransferidoRep);
            cuiPanel9.Controls.Add(lblTituloLiquidez);
            cuiPanel9.Controls.Add(cuiPanel10);
            cuiPanel9.Location = new Point(861, 3);
            cuiPanel9.Name = "cuiPanel9";
            cuiPanel9.OutlineThickness = 1F;
            cuiPanel9.PanelColor = Color.White;
            cuiPanel9.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel9.Rounding = new Padding(8);
            cuiPanel9.Size = new Size(275, 135);
            cuiPanel9.TabIndex = 4;
            // 
            // lblTotalTransferidoRep
            // 
            lblTotalTransferidoRep.AutoSize = true;
            lblTotalTransferidoRep.BackColor = Color.Transparent;
            lblTotalTransferidoRep.Font = new Font("Candara", 21.75F, FontStyle.Bold | FontStyle.Italic);
            lblTotalTransferidoRep.ForeColor = Color.FromArgb(0, 0, 192);
            lblTotalTransferidoRep.Location = new Point(68, 80);
            lblTotalTransferidoRep.Name = "lblTotalTransferidoRep";
            lblTotalTransferidoRep.Size = new Size(129, 36);
            lblTotalTransferidoRep.TabIndex = 7;
            lblTotalTransferidoRep.Text = "$7000.00";
            // 
            // lblTituloLiquidez
            // 
            lblTituloLiquidez.AutoSize = true;
            lblTituloLiquidez.BackColor = Color.Transparent;
            lblTituloLiquidez.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            lblTituloLiquidez.ForeColor = Color.DimGray;
            lblTituloLiquidez.Location = new Point(16, 61);
            lblTituloLiquidez.Name = "lblTituloLiquidez";
            lblTituloLiquidez.Size = new Size(133, 19);
            lblTituloLiquidez.TabIndex = 1;
            lblTituloLiquidez.Text = "Total Transferido";
            // 
            // cuiPanel10
            // 
            cuiPanel10.BackColor = Color.Transparent;
            cuiPanel10.Controls.Add(pictureBox3);
            cuiPanel10.ForeColor = SystemColors.ControlText;
            cuiPanel10.Location = new Point(10, 10);
            cuiPanel10.Name = "cuiPanel10";
            cuiPanel10.OutlineThickness = 1F;
            cuiPanel10.PanelColor = Color.FromArgb(202, 218, 227);
            cuiPanel10.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel10.Rounding = new Padding(8);
            cuiPanel10.Size = new Size(42, 39);
            cuiPanel10.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(6, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // cuiPanel4
            // 
            cuiPanel4.Controls.Add(lblFlujoNetoRep);
            cuiPanel4.Controls.Add(label7);
            cuiPanel4.Controls.Add(cuiPanel8);
            cuiPanel4.Location = new Point(575, 3);
            cuiPanel4.Name = "cuiPanel4";
            cuiPanel4.OutlineThickness = 1F;
            cuiPanel4.PanelColor = Color.White;
            cuiPanel4.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel4.Rounding = new Padding(8);
            cuiPanel4.Size = new Size(276, 135);
            cuiPanel4.TabIndex = 7;
            // 
            // lblFlujoNetoRep
            // 
            lblFlujoNetoRep.AutoSize = true;
            lblFlujoNetoRep.BackColor = Color.Transparent;
            lblFlujoNetoRep.Font = new Font("Candara", 21.75F, FontStyle.Bold | FontStyle.Italic);
            lblFlujoNetoRep.ForeColor = Color.Green;
            lblFlujoNetoRep.Location = new Point(46, 80);
            lblFlujoNetoRep.Name = "lblFlujoNetoRep";
            lblFlujoNetoRep.Size = new Size(129, 36);
            lblFlujoNetoRep.TabIndex = 8;
            lblFlujoNetoRep.Text = "$7000.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(24, 61);
            label7.Name = "label7";
            label7.Size = new Size(106, 19);
            label7.TabIndex = 2;
            label7.Text = "Balance Neto";
            // 
            // cuiPanel8
            // 
            cuiPanel8.BackColor = Color.Transparent;
            cuiPanel8.Controls.Add(pictureBox4);
            cuiPanel8.Location = new Point(20, 10);
            cuiPanel8.Name = "cuiPanel8";
            cuiPanel8.OutlineThickness = 1F;
            cuiPanel8.PanelColor = Color.FromArgb(220, 250, 230);
            cuiPanel8.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel8.Rounding = new Padding(8);
            cuiPanel8.Size = new Size(42, 39);
            cuiPanel8.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(4, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // cuiPanel2
            // 
            cuiPanel2.Controls.Add(btnExportarMovimientos);
            cuiPanel2.Controls.Add(btnFiltrarMovimientos);
            cuiPanel2.Controls.Add(cmbCuentasMovimientos);
            cuiPanel2.Controls.Add(label5);
            cuiPanel2.Controls.Add(cmbTipoMovimiento);
            cuiPanel2.Controls.Add(label4);
            cuiPanel2.Controls.Add(dtpHastaMovimientos);
            cuiPanel2.Controls.Add(label3);
            cuiPanel2.Controls.Add(dtpDesdeMovimientos);
            cuiPanel2.Controls.Add(label6);
            cuiPanel2.Location = new Point(8, 13);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.White;
            cuiPanel2.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel2.Rounding = new Padding(8);
            cuiPanel2.Size = new Size(1147, 105);
            cuiPanel2.TabIndex = 0;
            // 
            // btnExportarMovimientos
            // 
            btnExportarMovimientos.BackColor = Color.Transparent;
            btnExportarMovimientos.CheckButton = false;
            btnExportarMovimientos.Checked = false;
            btnExportarMovimientos.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnExportarMovimientos.CheckedForeColor = Color.White;
            btnExportarMovimientos.CheckedImageTint = Color.White;
            btnExportarMovimientos.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnExportarMovimientos.Content = "Exportar PDF";
            btnExportarMovimientos.DialogResult = DialogResult.None;
            btnExportarMovimientos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnExportarMovimientos.ForeColor = Color.Black;
            btnExportarMovimientos.HoverBackground = Color.WhiteSmoke;
            btnExportarMovimientos.HoverForeColor = Color.DimGray;
            btnExportarMovimientos.HoverImageTint = Color.DimGray;
            btnExportarMovimientos.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnExportarMovimientos.Image = (Image)resources.GetObject("btnExportarMovimientos.Image");
            btnExportarMovimientos.ImageExpand = new Point(0, 0);
            btnExportarMovimientos.Location = new Point(959, 41);
            btnExportarMovimientos.Name = "btnExportarMovimientos";
            btnExportarMovimientos.NormalBackground = Color.White;
            btnExportarMovimientos.NormalForeColor = Color.Black;
            btnExportarMovimientos.NormalImageTint = Color.White;
            btnExportarMovimientos.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnExportarMovimientos.OutlineThickness = 1F;
            btnExportarMovimientos.Padding = new Padding(12);
            btnExportarMovimientos.PressedBackground = Color.WhiteSmoke;
            btnExportarMovimientos.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnExportarMovimientos.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnExportarMovimientos.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnExportarMovimientos.Rounding = new Padding(8);
            btnExportarMovimientos.Size = new Size(163, 47);
            btnExportarMovimientos.TabIndex = 15;
            btnExportarMovimientos.TextAlignment = StringAlignment.Center;
            btnExportarMovimientos.TextPadding = 12;
            btnExportarMovimientos.TextSpacing = 2;
            // 
            // btnFiltrarMovimientos
            // 
            btnFiltrarMovimientos.CheckButton = false;
            btnFiltrarMovimientos.Checked = false;
            btnFiltrarMovimientos.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnFiltrarMovimientos.CheckedForeColor = Color.White;
            btnFiltrarMovimientos.CheckedImageTint = Color.White;
            btnFiltrarMovimientos.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnFiltrarMovimientos.Content = "Generar Reporte";
            btnFiltrarMovimientos.DialogResult = DialogResult.None;
            btnFiltrarMovimientos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnFiltrarMovimientos.ForeColor = Color.White;
            btnFiltrarMovimientos.HoverBackground = Color.White;
            btnFiltrarMovimientos.HoverForeColor = Color.DimGray;
            btnFiltrarMovimientos.HoverImageTint = Color.DimGray;
            btnFiltrarMovimientos.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnFiltrarMovimientos.Image = (Image)resources.GetObject("btnFiltrarMovimientos.Image");
            btnFiltrarMovimientos.ImageExpand = new Point(0, 0);
            btnFiltrarMovimientos.Location = new Point(787, 41);
            btnFiltrarMovimientos.Name = "btnFiltrarMovimientos";
            btnFiltrarMovimientos.NormalBackground = SystemColors.Highlight;
            btnFiltrarMovimientos.NormalForeColor = Color.White;
            btnFiltrarMovimientos.NormalImageTint = Color.White;
            btnFiltrarMovimientos.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnFiltrarMovimientos.OutlineThickness = 1F;
            btnFiltrarMovimientos.Padding = new Padding(12);
            btnFiltrarMovimientos.PressedBackground = Color.WhiteSmoke;
            btnFiltrarMovimientos.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnFiltrarMovimientos.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnFiltrarMovimientos.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnFiltrarMovimientos.Rounding = new Padding(8);
            btnFiltrarMovimientos.Size = new Size(163, 47);
            btnFiltrarMovimientos.TabIndex = 14;
            btnFiltrarMovimientos.TextAlignment = StringAlignment.Center;
            btnFiltrarMovimientos.TextPadding = 12;
            btnFiltrarMovimientos.TextSpacing = 2;
            // 
            // cmbCuentasMovimientos
            // 
            cmbCuentasMovimientos.BackColor = Color.Transparent;
            cmbCuentasMovimientos.BackgroundColor = Color.White;
            cmbCuentasMovimientos.DropDownBackgroundColor = SystemColors.Control;
            cmbCuentasMovimientos.DropDownForeColor = Color.FromArgb(64, 64, 64);
            cmbCuentasMovimientos.ExpandArrowColor = Color.Black;
            cmbCuentasMovimientos.ForeColor = Color.Black;
            cmbCuentasMovimientos.Items = new string[]
    {
    "Item 1",
    "Item 2",
    "Item 3"
    };
            cmbCuentasMovimientos.Location = new Point(595, 41);
            cmbCuentasMovimientos.Margin = new Padding(4, 3, 4, 3);
            cmbCuentasMovimientos.MaxDropDownHeight = 240;
            cmbCuentasMovimientos.Name = "cmbCuentasMovimientos";
            cmbCuentasMovimientos.NoSelectionText = "None";
            cmbCuentasMovimientos.OutlineColor = Color.Gray;
            cmbCuentasMovimientos.OutlineThickness = 1F;
            cmbCuentasMovimientos.Rounding = 8;
            cmbCuentasMovimientos.SelectedIndex = -1;
            cmbCuentasMovimientos.SelectedItem = "";
            cmbCuentasMovimientos.Size = new Size(182, 47);
            cmbCuentasMovimientos.SortAlphabetically = true;
            cmbCuentasMovimientos.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(595, 21);
            label5.Name = "label5";
            label5.Size = new Size(51, 17);
            label5.TabIndex = 12;
            label5.Text = "Cuenta";
            // 
            // cmbTipoMovimiento
            // 
            cmbTipoMovimiento.BackColor = Color.Transparent;
            cmbTipoMovimiento.BackgroundColor = Color.White;
            cmbTipoMovimiento.DropDownBackgroundColor = SystemColors.Control;
            cmbTipoMovimiento.DropDownForeColor = Color.FromArgb(64, 64, 64);
            cmbTipoMovimiento.ExpandArrowColor = Color.Black;
            cmbTipoMovimiento.ForeColor = Color.Black;
            cmbTipoMovimiento.Items = new string[]
    {
    "Item 1",
    "Item 2",
    "Item 3"
    };
            cmbTipoMovimiento.Location = new Point(402, 41);
            cmbTipoMovimiento.Margin = new Padding(4, 3, 4, 3);
            cmbTipoMovimiento.MaxDropDownHeight = 240;
            cmbTipoMovimiento.Name = "cmbTipoMovimiento";
            cmbTipoMovimiento.NoSelectionText = "None";
            cmbTipoMovimiento.OutlineColor = Color.Gray;
            cmbTipoMovimiento.OutlineThickness = 1F;
            cmbTipoMovimiento.Rounding = 8;
            cmbTipoMovimiento.SelectedIndex = -1;
            cmbTipoMovimiento.SelectedItem = "";
            cmbTipoMovimiento.Size = new Size(182, 47);
            cmbTipoMovimiento.SortAlphabetically = true;
            cmbTipoMovimiento.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(402, 21);
            label4.Name = "label4";
            label4.Size = new Size(134, 17);
            label4.TabIndex = 10;
            label4.Text = "Tipo de Movimiento";
            // 
            // dtpHastaMovimientos
            // 
            dtpHastaMovimientos.BackColor = Color.Transparent;
            dtpHastaMovimientos.Content = new DateTime(2026, 11, 18, 0, 0, 0, 0);
            dtpHastaMovimientos.EnableThemeChangeButton = true;
            dtpHastaMovimientos.Font = new Font("Segoe UI", 9.75F);
            dtpHastaMovimientos.ForeColor = Color.Black;
            dtpHastaMovimientos.HoverBackground = Color.FromArgb(50, 128, 128, 128);
            dtpHastaMovimientos.HoverOutline = Color.FromArgb(0, 0, 192);
            dtpHastaMovimientos.Icon = (Image)resources.GetObject("dtpHastaMovimientos.Icon");
            dtpHastaMovimientos.IconTint = Color.Black;
            dtpHastaMovimientos.Location = new Point(209, 41);
            dtpHastaMovimientos.Margin = new Padding(4, 3, 4, 3);
            dtpHastaMovimientos.Name = "dtpHastaMovimientos";
            dtpHastaMovimientos.NormalBackground = Color.FromArgb(32, 128, 128, 128);
            dtpHastaMovimientos.NormalOutline = Color.Gray;
            dtpHastaMovimientos.OutlineThickness = 1.5F;
            dtpHastaMovimientos.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom;
            dtpHastaMovimientos.PressedBackground = Color.FromArgb(80, 128, 128, 128);
            dtpHastaMovimientos.PressedOutline = Color.FromArgb(0, 0, 192);
            dtpHastaMovimientos.Rounding = 8;
            dtpHastaMovimientos.ShowIcon = true;
            dtpHastaMovimientos.Size = new Size(182, 47);
            dtpHastaMovimientos.TabIndex = 9;
            dtpHastaMovimientos.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(209, 21);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 8;
            label3.Text = "Fecha Hasta";
            // 
            // dtpDesdeMovimientos
            // 
            dtpDesdeMovimientos.BackColor = SystemColors.ControlLightLight;
            dtpDesdeMovimientos.Content = new DateTime(2026, 11, 18, 0, 0, 0, 0);
            dtpDesdeMovimientos.EnableThemeChangeButton = true;
            dtpDesdeMovimientos.Font = new Font("Segoe UI", 9.75F);
            dtpDesdeMovimientos.ForeColor = Color.Black;
            dtpDesdeMovimientos.HoverBackground = Color.FromArgb(50, 128, 128, 128);
            dtpDesdeMovimientos.HoverOutline = Color.Gray;
            dtpDesdeMovimientos.Icon = (Image)resources.GetObject("dtpDesdeMovimientos.Icon");
            dtpDesdeMovimientos.IconTint = Color.Black;
            dtpDesdeMovimientos.Location = new Point(16, 41);
            dtpDesdeMovimientos.Margin = new Padding(4, 3, 4, 3);
            dtpDesdeMovimientos.Name = "dtpDesdeMovimientos";
            dtpDesdeMovimientos.NormalBackground = Color.FromArgb(32, 128, 128, 128);
            dtpDesdeMovimientos.NormalOutline = Color.Gray;
            dtpDesdeMovimientos.OutlineThickness = 1.5F;
            dtpDesdeMovimientos.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom;
            dtpDesdeMovimientos.PressedBackground = Color.FromArgb(80, 128, 128, 128);
            dtpDesdeMovimientos.PressedOutline = Color.FromArgb(0, 0, 192);
            dtpDesdeMovimientos.Rounding = 8;
            dtpDesdeMovimientos.ShowIcon = true;
            dtpDesdeMovimientos.Size = new Size(182, 47);
            dtpDesdeMovimientos.TabIndex = 7;
            dtpDesdeMovimientos.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(16, 21);
            label6.Name = "label6";
            label6.Size = new Size(85, 17);
            label6.TabIndex = 6;
            label6.Text = "Fecha Desde";
            // 
            // tabCategorias
            // 
            tabCategorias.BackColor = SystemColors.Control;
            tabCategorias.Controls.Add(dgvReporteCategorias);
            tabCategorias.Controls.Add(cuiPanel19);
            tabCategorias.Controls.Add(tableLayoutPanel2);
            tabCategorias.Controls.Add(cuiPanel12);
            tabCategorias.Location = new Point(4, 29);
            tabCategorias.Name = "tabCategorias";
            tabCategorias.Padding = new Padding(3);
            tabCategorias.Size = new Size(1163, 620);
            tabCategorias.TabIndex = 1;
            tabCategorias.Text = "Gastos por Categoría";
            // 
            // dgvReporteCategorias
            // 
            dgvReporteCategorias.AllowUserToAddRows = false;
            dgvReporteCategorias.AllowUserToDeleteRows = false;
            dgvReporteCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteCategorias.Columns.AddRange(new DataGridViewColumn[] { colCatNombre, colCatTotal, colCatPorcentaje, colCatCantidad, colCatPromedio });
            dgvReporteCategorias.Location = new Point(6, 320);
            dgvReporteCategorias.Name = "dgvReporteCategorias";
            dgvReporteCategorias.ReadOnly = true;
            dgvReporteCategorias.Size = new Size(1147, 294);
            dgvReporteCategorias.TabIndex = 8;
            // 
            // colCatNombre
            // 
            colCatNombre.HeaderText = "Categoria";
            colCatNombre.Name = "colCatNombre";
            colCatNombre.ReadOnly = true;
            // 
            // colCatTotal
            // 
            colCatTotal.HeaderText = "Total Gastado";
            colCatTotal.Name = "colCatTotal";
            colCatTotal.ReadOnly = true;
            // 
            // colCatPorcentaje
            // 
            colCatPorcentaje.HeaderText = "Porcentaje del Gasto";
            colCatPorcentaje.Name = "colCatPorcentaje";
            colCatPorcentaje.ReadOnly = true;
            // 
            // colCatCantidad
            // 
            colCatCantidad.HeaderText = "No. Transferencias";
            colCatCantidad.Name = "colCatCantidad";
            colCatCantidad.ReadOnly = true;
            // 
            // colCatPromedio
            // 
            colCatPromedio.HeaderText = "Promedio Gastado";
            colCatPromedio.Name = "colCatPromedio";
            colCatPromedio.ReadOnly = true;
            // 
            // cuiPanel19
            // 
            cuiPanel19.Controls.Add(label24);
            cuiPanel19.Location = new Point(8, 271);
            cuiPanel19.Name = "cuiPanel19";
            cuiPanel19.OutlineThickness = 1F;
            cuiPanel19.PanelColor = Color.White;
            cuiPanel19.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel19.Rounding = new Padding(8);
            cuiPanel19.Size = new Size(1147, 48);
            cuiPanel19.TabIndex = 7;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.Black;
            label24.Location = new Point(14, 14);
            label24.Name = "label24";
            label24.Size = new Size(171, 21);
            label24.TabIndex = 3;
            label24.Text = "Detalle por categoría";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(cuiPanel13, 0, 0);
            tableLayoutPanel2.Controls.Add(cuiPanel15, 2, 0);
            tableLayoutPanel2.Controls.Add(cuiPanel17, 4, 0);
            tableLayoutPanel2.Location = new Point(8, 127);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1147, 135);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // cuiPanel13
            // 
            cuiPanel13.Controls.Add(label16);
            cuiPanel13.Controls.Add(lblTotalGastoCatRep);
            cuiPanel13.Controls.Add(label15);
            cuiPanel13.Controls.Add(cuiPanel14);
            cuiPanel13.Dock = DockStyle.Fill;
            cuiPanel13.Location = new Point(3, 3);
            cuiPanel13.Name = "cuiPanel13";
            cuiPanel13.OutlineThickness = 1F;
            cuiPanel13.PanelColor = Color.White;
            cuiPanel13.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel13.Rounding = new Padding(8);
            cuiPanel13.Size = new Size(363, 129);
            cuiPanel13.TabIndex = 7;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.DimGray;
            label16.Location = new Point(13, 97);
            label16.Name = "label16";
            label16.Size = new Size(215, 16);
            label16.TabIndex = 9;
            label16.Text = "Suma de gastos del rango filtradoo";
            // 
            // lblTotalGastoCatRep
            // 
            lblTotalGastoCatRep.AutoSize = true;
            lblTotalGastoCatRep.BackColor = Color.Transparent;
            lblTotalGastoCatRep.Font = new Font("Candara", 21.75F, FontStyle.Bold | FontStyle.Italic);
            lblTotalGastoCatRep.ForeColor = Color.Red;
            lblTotalGastoCatRep.Location = new Point(13, 52);
            lblTotalGastoCatRep.Name = "lblTotalGastoCatRep";
            lblTotalGastoCatRep.Size = new Size(142, 36);
            lblTotalGastoCatRep.TabIndex = 8;
            lblTotalGastoCatRep.Text = "- $7000.00";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            label15.ForeColor = Color.DimGray;
            label15.Location = new Point(13, 22);
            label15.Name = "label15";
            label15.Size = new Size(212, 19);
            label15.TabIndex = 2;
            label15.Text = "Total Gastado en el periodo";
            // 
            // cuiPanel14
            // 
            cuiPanel14.BackColor = Color.Transparent;
            cuiPanel14.Controls.Add(pictureBox5);
            cuiPanel14.Location = new Point(315, 6);
            cuiPanel14.Name = "cuiPanel14";
            cuiPanel14.OutlineThickness = 1F;
            cuiPanel14.PanelColor = Color.FromArgb(250, 227, 229);
            cuiPanel14.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel14.Rounding = new Padding(8);
            cuiPanel14.Size = new Size(42, 39);
            cuiPanel14.TabIndex = 1;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(4, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 31);
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // cuiPanel15
            // 
            cuiPanel15.Controls.Add(lblTotalGastadoCategoriaTo);
            cuiPanel15.Controls.Add(label19);
            cuiPanel15.Controls.Add(lblTopCategoriaRep);
            cuiPanel15.Controls.Add(label18);
            cuiPanel15.Controls.Add(cuiPanel16);
            cuiPanel15.Dock = DockStyle.Fill;
            cuiPanel15.Location = new Point(392, 3);
            cuiPanel15.Name = "cuiPanel15";
            cuiPanel15.OutlineThickness = 1F;
            cuiPanel15.PanelColor = Color.White;
            cuiPanel15.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel15.Rounding = new Padding(8);
            cuiPanel15.Size = new Size(363, 129);
            cuiPanel15.TabIndex = 8;
            // 
            // lblTopCategoriaRep
            // 
            lblTopCategoriaRep.AutoSize = true;
            lblTopCategoriaRep.BackColor = Color.Transparent;
            lblTopCategoriaRep.Font = new Font("Candara", 21.75F, FontStyle.Bold | FontStyle.Italic);
            lblTopCategoriaRep.ForeColor = Color.FromArgb(64, 64, 64);
            lblTopCategoriaRep.Location = new Point(10, 52);
            lblTopCategoriaRep.Name = "lblTopCategoriaRep";
            lblTopCategoriaRep.Size = new Size(194, 36);
            lblTopCategoriaRep.TabIndex = 7;
            lblTopCategoriaRep.Text = "Supermercado";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            label18.ForeColor = Color.DimGray;
            label18.Location = new Point(10, 22);
            label18.Name = "label18";
            label18.Size = new Size(233, 19);
            label18.TabIndex = 1;
            label18.Text = "Categoria Mayor Gasto (Top 1)";
            // 
            // cuiPanel16
            // 
            cuiPanel16.BackColor = Color.Transparent;
            cuiPanel16.Controls.Add(pictureBox6);
            cuiPanel16.ForeColor = SystemColors.ControlText;
            cuiPanel16.Location = new Point(315, 6);
            cuiPanel16.Name = "cuiPanel16";
            cuiPanel16.OutlineThickness = 1F;
            cuiPanel16.PanelColor = Color.FromArgb(202, 218, 227);
            cuiPanel16.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel16.Rounding = new Padding(8);
            cuiPanel16.Size = new Size(42, 39);
            cuiPanel16.TabIndex = 0;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(6, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // cuiPanel17
            // 
            cuiPanel17.Controls.Add(label21);
            cuiPanel17.Controls.Add(lblNumTransaccionesCatRep);
            cuiPanel17.Controls.Add(label23);
            cuiPanel17.Controls.Add(cuiPanel18);
            cuiPanel17.Dock = DockStyle.Fill;
            cuiPanel17.Location = new Point(781, 3);
            cuiPanel17.Name = "cuiPanel17";
            cuiPanel17.OutlineThickness = 1F;
            cuiPanel17.PanelColor = Color.White;
            cuiPanel17.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel17.Rounding = new Padding(8);
            cuiPanel17.Size = new Size(363, 129);
            cuiPanel17.TabIndex = 9;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.DimGray;
            label21.Location = new Point(10, 97);
            label21.Name = "label21";
            label21.Size = new Size(223, 16);
            label21.TabIndex = 10;
            label21.Text = "Movimientos de gasto considerados";
            // 
            // lblNumTransaccionesCatRep
            // 
            lblNumTransaccionesCatRep.AutoSize = true;
            lblNumTransaccionesCatRep.BackColor = Color.Transparent;
            lblNumTransaccionesCatRep.Font = new Font("Candara", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNumTransaccionesCatRep.ForeColor = Color.FromArgb(64, 64, 64);
            lblNumTransaccionesCatRep.Location = new Point(12, 49);
            lblNumTransaccionesCatRep.Name = "lblNumTransaccionesCatRep";
            lblNumTransaccionesCatRep.Size = new Size(44, 42);
            lblNumTransaccionesCatRep.TabIndex = 7;
            lblNumTransaccionesCatRep.Text = "11";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            label23.ForeColor = Color.DimGray;
            label23.Location = new Point(10, 22);
            label23.Name = "label23";
            label23.Size = new Size(232, 19);
            label23.TabIndex = 1;
            label23.Text = "Total Transacciones Analizadas";
            // 
            // cuiPanel18
            // 
            cuiPanel18.BackColor = Color.Transparent;
            cuiPanel18.Controls.Add(pictureBox7);
            cuiPanel18.ForeColor = SystemColors.ControlText;
            cuiPanel18.Location = new Point(315, 6);
            cuiPanel18.Name = "cuiPanel18";
            cuiPanel18.OutlineThickness = 1F;
            cuiPanel18.PanelColor = Color.FromArgb(202, 218, 227);
            cuiPanel18.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel18.Rounding = new Padding(8);
            cuiPanel18.Size = new Size(42, 39);
            cuiPanel18.TabIndex = 0;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(6, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(32, 30);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            // 
            // cuiPanel12
            // 
            cuiPanel12.Controls.Add(btnExportarCat);
            cuiPanel12.Controls.Add(btnFiltrarCat);
            cuiPanel12.Controls.Add(cmbCuentasCat);
            cuiPanel12.Controls.Add(label11);
            cuiPanel12.Controls.Add(dtpHastaCat);
            cuiPanel12.Controls.Add(label13);
            cuiPanel12.Controls.Add(dtpDesdeCat);
            cuiPanel12.Controls.Add(label14);
            cuiPanel12.Location = new Point(8, 13);
            cuiPanel12.Name = "cuiPanel12";
            cuiPanel12.OutlineThickness = 1F;
            cuiPanel12.PanelColor = Color.White;
            cuiPanel12.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel12.Rounding = new Padding(8);
            cuiPanel12.Size = new Size(1147, 105);
            cuiPanel12.TabIndex = 1;
            // 
            // btnExportarCat
            // 
            btnExportarCat.BackColor = Color.Transparent;
            btnExportarCat.CheckButton = false;
            btnExportarCat.Checked = false;
            btnExportarCat.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnExportarCat.CheckedForeColor = Color.White;
            btnExportarCat.CheckedImageTint = Color.White;
            btnExportarCat.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnExportarCat.Content = "Exportar PDF";
            btnExportarCat.DialogResult = DialogResult.None;
            btnExportarCat.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnExportarCat.ForeColor = Color.Black;
            btnExportarCat.HoverBackground = Color.WhiteSmoke;
            btnExportarCat.HoverForeColor = Color.DimGray;
            btnExportarCat.HoverImageTint = Color.DimGray;
            btnExportarCat.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnExportarCat.Image = (Image)resources.GetObject("btnExportarCat.Image");
            btnExportarCat.ImageExpand = new Point(0, 0);
            btnExportarCat.Location = new Point(959, 41);
            btnExportarCat.Name = "btnExportarCat";
            btnExportarCat.NormalBackground = Color.White;
            btnExportarCat.NormalForeColor = Color.Black;
            btnExportarCat.NormalImageTint = Color.White;
            btnExportarCat.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnExportarCat.OutlineThickness = 1F;
            btnExportarCat.Padding = new Padding(12);
            btnExportarCat.PressedBackground = Color.WhiteSmoke;
            btnExportarCat.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnExportarCat.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnExportarCat.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnExportarCat.Rounding = new Padding(8);
            btnExportarCat.Size = new Size(163, 47);
            btnExportarCat.TabIndex = 15;
            btnExportarCat.TextAlignment = StringAlignment.Center;
            btnExportarCat.TextPadding = 12;
            btnExportarCat.TextSpacing = 2;
            // 
            // btnFiltrarCat
            // 
            btnFiltrarCat.CheckButton = false;
            btnFiltrarCat.Checked = false;
            btnFiltrarCat.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnFiltrarCat.CheckedForeColor = Color.White;
            btnFiltrarCat.CheckedImageTint = Color.White;
            btnFiltrarCat.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnFiltrarCat.Content = "Generar Reporte";
            btnFiltrarCat.DialogResult = DialogResult.None;
            btnFiltrarCat.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnFiltrarCat.ForeColor = Color.White;
            btnFiltrarCat.HoverBackground = Color.White;
            btnFiltrarCat.HoverForeColor = Color.DimGray;
            btnFiltrarCat.HoverImageTint = Color.DimGray;
            btnFiltrarCat.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnFiltrarCat.Image = (Image)resources.GetObject("btnFiltrarCat.Image");
            btnFiltrarCat.ImageExpand = new Point(0, 0);
            btnFiltrarCat.Location = new Point(787, 41);
            btnFiltrarCat.Name = "btnFiltrarCat";
            btnFiltrarCat.NormalBackground = SystemColors.Highlight;
            btnFiltrarCat.NormalForeColor = Color.White;
            btnFiltrarCat.NormalImageTint = Color.White;
            btnFiltrarCat.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnFiltrarCat.OutlineThickness = 1F;
            btnFiltrarCat.Padding = new Padding(12);
            btnFiltrarCat.PressedBackground = Color.WhiteSmoke;
            btnFiltrarCat.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnFiltrarCat.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnFiltrarCat.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnFiltrarCat.Rounding = new Padding(8);
            btnFiltrarCat.Size = new Size(163, 47);
            btnFiltrarCat.TabIndex = 14;
            btnFiltrarCat.TextAlignment = StringAlignment.Center;
            btnFiltrarCat.TextPadding = 12;
            btnFiltrarCat.TextSpacing = 2;
            // 
            // cmbCuentasCat
            // 
            cmbCuentasCat.BackColor = Color.Transparent;
            cmbCuentasCat.BackgroundColor = Color.White;
            cmbCuentasCat.DropDownBackgroundColor = SystemColors.Control;
            cmbCuentasCat.DropDownForeColor = Color.FromArgb(64, 64, 64);
            cmbCuentasCat.ExpandArrowColor = Color.Black;
            cmbCuentasCat.ForeColor = Color.Black;
            cmbCuentasCat.Items = new string[]
    {
    "Item 1",
    "Item 2",
    "Item 3"
    };
            cmbCuentasCat.Location = new Point(402, 41);
            cmbCuentasCat.Margin = new Padding(4, 3, 4, 3);
            cmbCuentasCat.MaxDropDownHeight = 240;
            cmbCuentasCat.Name = "cmbCuentasCat";
            cmbCuentasCat.NoSelectionText = "None";
            cmbCuentasCat.OutlineColor = Color.Gray;
            cmbCuentasCat.OutlineThickness = 1F;
            cmbCuentasCat.Rounding = 8;
            cmbCuentasCat.SelectedIndex = -1;
            cmbCuentasCat.SelectedItem = "";
            cmbCuentasCat.Size = new Size(182, 47);
            cmbCuentasCat.SortAlphabetically = true;
            cmbCuentasCat.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(402, 21);
            label11.Name = "label11";
            label11.Size = new Size(51, 17);
            label11.TabIndex = 12;
            label11.Text = "Cuenta";
            // 
            // dtpHastaCat
            // 
            dtpHastaCat.BackColor = Color.Transparent;
            dtpHastaCat.Content = new DateTime(2026, 11, 18, 0, 0, 0, 0);
            dtpHastaCat.EnableThemeChangeButton = true;
            dtpHastaCat.Font = new Font("Segoe UI", 9.75F);
            dtpHastaCat.ForeColor = Color.Black;
            dtpHastaCat.HoverBackground = Color.FromArgb(50, 128, 128, 128);
            dtpHastaCat.HoverOutline = Color.FromArgb(0, 0, 192);
            dtpHastaCat.Icon = (Image)resources.GetObject("dtpHastaCat.Icon");
            dtpHastaCat.IconTint = Color.Black;
            dtpHastaCat.Location = new Point(209, 41);
            dtpHastaCat.Margin = new Padding(4, 3, 4, 3);
            dtpHastaCat.Name = "dtpHastaCat";
            dtpHastaCat.NormalBackground = Color.FromArgb(32, 128, 128, 128);
            dtpHastaCat.NormalOutline = Color.Gray;
            dtpHastaCat.OutlineThickness = 1.5F;
            dtpHastaCat.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom;
            dtpHastaCat.PressedBackground = Color.FromArgb(80, 128, 128, 128);
            dtpHastaCat.PressedOutline = Color.FromArgb(0, 0, 192);
            dtpHastaCat.Rounding = 8;
            dtpHastaCat.ShowIcon = true;
            dtpHastaCat.Size = new Size(182, 47);
            dtpHastaCat.TabIndex = 9;
            dtpHastaCat.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label13.ForeColor = Color.DimGray;
            label13.Location = new Point(209, 21);
            label13.Name = "label13";
            label13.Size = new Size(82, 17);
            label13.TabIndex = 8;
            label13.Text = "Fecha Hasta";
            // 
            // dtpDesdeCat
            // 
            dtpDesdeCat.BackColor = SystemColors.ControlLightLight;
            dtpDesdeCat.Content = new DateTime(2026, 11, 18, 0, 0, 0, 0);
            dtpDesdeCat.EnableThemeChangeButton = true;
            dtpDesdeCat.Font = new Font("Segoe UI", 9.75F);
            dtpDesdeCat.ForeColor = Color.Black;
            dtpDesdeCat.HoverBackground = Color.FromArgb(50, 128, 128, 128);
            dtpDesdeCat.HoverOutline = Color.Gray;
            dtpDesdeCat.Icon = (Image)resources.GetObject("dtpDesdeCat.Icon");
            dtpDesdeCat.IconTint = Color.Black;
            dtpDesdeCat.Location = new Point(16, 41);
            dtpDesdeCat.Margin = new Padding(4, 3, 4, 3);
            dtpDesdeCat.Name = "dtpDesdeCat";
            dtpDesdeCat.NormalBackground = Color.FromArgb(32, 128, 128, 128);
            dtpDesdeCat.NormalOutline = Color.Gray;
            dtpDesdeCat.OutlineThickness = 1.5F;
            dtpDesdeCat.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom;
            dtpDesdeCat.PressedBackground = Color.FromArgb(80, 128, 128, 128);
            dtpDesdeCat.PressedOutline = Color.FromArgb(0, 0, 192);
            dtpDesdeCat.Rounding = 8;
            dtpDesdeCat.ShowIcon = true;
            dtpDesdeCat.Size = new Size(182, 47);
            dtpDesdeCat.TabIndex = 7;
            dtpDesdeCat.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label14.ForeColor = Color.DimGray;
            label14.Location = new Point(16, 21);
            label14.Name = "label14";
            label14.Size = new Size(85, 17);
            label14.TabIndex = 6;
            label14.Text = "Fecha Desde";
            // 
            // tabCuentas
            // 
            tabCuentas.BackColor = SystemColors.Control;
            tabCuentas.Controls.Add(dgvReporteCuentas);
            tabCuentas.Controls.Add(tableLayoutPanel3);
            tabCuentas.Controls.Add(cuiPanel21);
            tabCuentas.Controls.Add(cuiPanel20);
            tabCuentas.Location = new Point(4, 29);
            tabCuentas.Name = "tabCuentas";
            tabCuentas.Padding = new Padding(3);
            tabCuentas.Size = new Size(1163, 620);
            tabCuentas.TabIndex = 2;
            tabCuentas.Text = "Estado General de Cuentas y Deudas";
            // 
            // dgvReporteCuentas
            // 
            dgvReporteCuentas.AllowUserToAddRows = false;
            dgvReporteCuentas.AllowUserToDeleteRows = false;
            dgvReporteCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteCuentas.Columns.AddRange(new DataGridViewColumn[] { colCuentaNombre, colCuentaTipo, colCuentaMoneda, colCuentaSaldo, colCuentaLimite, colCuentaDeuda, colCuentaDisponible });
            dgvReporteCuentas.Location = new Point(6, 320);
            dgvReporteCuentas.Name = "dgvReporteCuentas";
            dgvReporteCuentas.ReadOnly = true;
            dgvReporteCuentas.Size = new Size(1147, 292);
            dgvReporteCuentas.TabIndex = 10;
            // 
            // colCuentaNombre
            // 
            colCuentaNombre.HeaderText = "Nombre";
            colCuentaNombre.Name = "colCuentaNombre";
            colCuentaNombre.ReadOnly = true;
            // 
            // colCuentaTipo
            // 
            colCuentaTipo.HeaderText = "Tipo";
            colCuentaTipo.Name = "colCuentaTipo";
            colCuentaTipo.ReadOnly = true;
            // 
            // colCuentaMoneda
            // 
            colCuentaMoneda.HeaderText = "Moneda";
            colCuentaMoneda.Name = "colCuentaMoneda";
            colCuentaMoneda.ReadOnly = true;
            // 
            // colCuentaSaldo
            // 
            colCuentaSaldo.HeaderText = "Saldo Actual";
            colCuentaSaldo.Name = "colCuentaSaldo";
            colCuentaSaldo.ReadOnly = true;
            // 
            // colCuentaLimite
            // 
            colCuentaLimite.HeaderText = "Limite de Credito";
            colCuentaLimite.Name = "colCuentaLimite";
            colCuentaLimite.ReadOnly = true;
            // 
            // colCuentaDeuda
            // 
            colCuentaDeuda.HeaderText = "Deuda";
            colCuentaDeuda.Name = "colCuentaDeuda";
            colCuentaDeuda.ReadOnly = true;
            // 
            // colCuentaDisponible
            // 
            colCuentaDisponible.HeaderText = "Credito Disponible";
            colCuentaDisponible.Name = "colCuentaDisponible";
            colCuentaDisponible.ReadOnly = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(cuiPanel22, 0, 0);
            tableLayoutPanel3.Controls.Add(cuiPanel24, 2, 0);
            tableLayoutPanel3.Controls.Add(cuiPanel26, 4, 0);
            tableLayoutPanel3.Location = new Point(8, 127);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1147, 135);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // cuiPanel22
            // 
            cuiPanel22.Controls.Add(label22);
            cuiPanel22.Controls.Add(lblLiquidezTotalRep);
            cuiPanel22.Controls.Add(label20);
            cuiPanel22.Controls.Add(cuiPanel23);
            cuiPanel22.Dock = DockStyle.Fill;
            cuiPanel22.Location = new Point(3, 3);
            cuiPanel22.Name = "cuiPanel22";
            cuiPanel22.OutlineThickness = 1F;
            cuiPanel22.PanelColor = Color.White;
            cuiPanel22.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel22.Rounding = new Padding(8);
            cuiPanel22.Size = new Size(363, 129);
            cuiPanel22.TabIndex = 6;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.DimGray;
            label22.Location = new Point(20, 99);
            label22.Name = "label22";
            label22.Size = new Size(174, 16);
            label22.TabIndex = 10;
            label22.Text = "Efectivo y cuentas bancarias";
            // 
            // lblLiquidezTotalRep
            // 
            lblLiquidezTotalRep.AutoSize = true;
            lblLiquidezTotalRep.BackColor = Color.Transparent;
            lblLiquidezTotalRep.Font = new Font("Candara", 21.75F, FontStyle.Bold | FontStyle.Italic);
            lblLiquidezTotalRep.ForeColor = Color.Green;
            lblLiquidezTotalRep.Location = new Point(20, 46);
            lblLiquidezTotalRep.Name = "lblLiquidezTotalRep";
            lblLiquidezTotalRep.Size = new Size(129, 36);
            lblLiquidezTotalRep.TabIndex = 8;
            lblLiquidezTotalRep.Text = "$7000.00";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            label20.ForeColor = Color.DimGray;
            label20.Location = new Point(20, 24);
            label20.Name = "label20";
            label20.Size = new Size(113, 19);
            label20.TabIndex = 2;
            label20.Text = "Total Ingresos";
            // 
            // cuiPanel23
            // 
            cuiPanel23.BackColor = Color.Transparent;
            cuiPanel23.Controls.Add(pictureBox8);
            cuiPanel23.Location = new Point(313, 8);
            cuiPanel23.Name = "cuiPanel23";
            cuiPanel23.OutlineThickness = 1F;
            cuiPanel23.PanelColor = Color.FromArgb(220, 250, 230);
            cuiPanel23.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel23.Rounding = new Padding(8);
            cuiPanel23.Size = new Size(42, 39);
            cuiPanel23.TabIndex = 1;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(4, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(35, 31);
            pictureBox8.TabIndex = 0;
            pictureBox8.TabStop = false;
            // 
            // cuiPanel24
            // 
            cuiPanel24.Controls.Add(label27);
            cuiPanel24.Controls.Add(lblDeudaTotalRep);
            cuiPanel24.Controls.Add(label26);
            cuiPanel24.Controls.Add(cuiPanel25);
            cuiPanel24.Dock = DockStyle.Fill;
            cuiPanel24.Location = new Point(392, 3);
            cuiPanel24.Name = "cuiPanel24";
            cuiPanel24.OutlineThickness = 1F;
            cuiPanel24.PanelColor = Color.White;
            cuiPanel24.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel24.Rounding = new Padding(8);
            cuiPanel24.Size = new Size(363, 129);
            cuiPanel24.TabIndex = 7;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = Color.Transparent;
            label27.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.ForeColor = Color.DimGray;
            label27.Location = new Point(18, 99);
            label27.Name = "label27";
            label27.Size = new Size(156, 16);
            label27.TabIndex = 11;
            label27.Text = "Saldo pendiente de pago";
            // 
            // lblDeudaTotalRep
            // 
            lblDeudaTotalRep.AutoSize = true;
            lblDeudaTotalRep.BackColor = Color.Transparent;
            lblDeudaTotalRep.Font = new Font("Candara", 21.75F, FontStyle.Bold | FontStyle.Italic);
            lblDeudaTotalRep.ForeColor = Color.Red;
            lblDeudaTotalRep.Location = new Point(18, 46);
            lblDeudaTotalRep.Name = "lblDeudaTotalRep";
            lblDeudaTotalRep.Size = new Size(129, 36);
            lblDeudaTotalRep.TabIndex = 8;
            lblDeudaTotalRep.Text = "$7000.00";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Transparent;
            label26.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            label26.ForeColor = Color.DimGray;
            label26.Location = new Point(18, 24);
            label26.Name = "label26";
            label26.Size = new Size(181, 19);
            label26.TabIndex = 2;
            label26.Text = "Total Deuda en Tarjetas";
            // 
            // cuiPanel25
            // 
            cuiPanel25.BackColor = Color.Transparent;
            cuiPanel25.Controls.Add(pictureBox9);
            cuiPanel25.Location = new Point(313, 8);
            cuiPanel25.Name = "cuiPanel25";
            cuiPanel25.OutlineThickness = 1F;
            cuiPanel25.PanelColor = Color.FromArgb(250, 227, 229);
            cuiPanel25.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel25.Rounding = new Padding(8);
            cuiPanel25.Size = new Size(42, 39);
            cuiPanel25.TabIndex = 1;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(4, 4);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(35, 31);
            pictureBox9.TabIndex = 1;
            pictureBox9.TabStop = false;
            // 
            // cuiPanel26
            // 
            cuiPanel26.Controls.Add(label30);
            cuiPanel26.Controls.Add(label29);
            cuiPanel26.Controls.Add(lblPatrimonioNetoRep);
            cuiPanel26.Controls.Add(cuiPanel27);
            cuiPanel26.Dock = DockStyle.Fill;
            cuiPanel26.Location = new Point(781, 3);
            cuiPanel26.Name = "cuiPanel26";
            cuiPanel26.OutlineThickness = 1F;
            cuiPanel26.PanelColor = Color.White;
            cuiPanel26.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel26.Rounding = new Padding(8);
            cuiPanel26.Size = new Size(363, 129);
            cuiPanel26.TabIndex = 8;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = Color.Transparent;
            label30.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.ForeColor = Color.DimGray;
            label30.Location = new Point(19, 99);
            label30.Name = "label30";
            label30.Size = new Size(206, 16);
            label30.TabIndex = 12;
            label30.Text = "Liquidez menos deuda en tarjetas";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BackColor = Color.Transparent;
            label29.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            label29.ForeColor = Color.DimGray;
            label29.Location = new Point(19, 24);
            label29.Name = "label29";
            label29.Size = new Size(211, 19);
            label29.TabIndex = 8;
            label29.Text = "Patrimonio Neto disponible";
            // 
            // lblPatrimonioNetoRep
            // 
            lblPatrimonioNetoRep.AutoSize = true;
            lblPatrimonioNetoRep.BackColor = Color.Transparent;
            lblPatrimonioNetoRep.Font = new Font("Candara", 21.75F, FontStyle.Bold | FontStyle.Italic);
            lblPatrimonioNetoRep.ForeColor = Color.FromArgb(0, 0, 192);
            lblPatrimonioNetoRep.Location = new Point(19, 46);
            lblPatrimonioNetoRep.Name = "lblPatrimonioNetoRep";
            lblPatrimonioNetoRep.Size = new Size(129, 36);
            lblPatrimonioNetoRep.TabIndex = 7;
            lblPatrimonioNetoRep.Text = "$7000.00";
            // 
            // cuiPanel27
            // 
            cuiPanel27.BackColor = Color.Transparent;
            cuiPanel27.Controls.Add(pictureBox10);
            cuiPanel27.ForeColor = SystemColors.ControlText;
            cuiPanel27.Location = new Point(313, 8);
            cuiPanel27.Name = "cuiPanel27";
            cuiPanel27.OutlineThickness = 1F;
            cuiPanel27.PanelColor = Color.FromArgb(202, 218, 227);
            cuiPanel27.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel27.Rounding = new Padding(8);
            cuiPanel27.Size = new Size(42, 39);
            cuiPanel27.TabIndex = 0;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(6, 3);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(32, 30);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 1;
            pictureBox10.TabStop = false;
            // 
            // cuiPanel21
            // 
            cuiPanel21.Controls.Add(label12);
            cuiPanel21.Location = new Point(6, 271);
            cuiPanel21.Name = "cuiPanel21";
            cuiPanel21.OutlineThickness = 1F;
            cuiPanel21.PanelColor = Color.White;
            cuiPanel21.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel21.Rounding = new Padding(8);
            cuiPanel21.Size = new Size(1147, 48);
            cuiPanel21.TabIndex = 8;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(14, 14);
            label12.Name = "label12";
            label12.Size = new Size(286, 21);
            label12.TabIndex = 3;
            label12.Text = "Estado General de Cuentas y Deudas";
            // 
            // cuiPanel20
            // 
            cuiPanel20.Controls.Add(btnExportarCuentas);
            cuiPanel20.Controls.Add(btnRefrescarCuentas);
            cuiPanel20.Location = new Point(8, 13);
            cuiPanel20.Name = "cuiPanel20";
            cuiPanel20.OutlineThickness = 1F;
            cuiPanel20.PanelColor = Color.White;
            cuiPanel20.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel20.Rounding = new Padding(8);
            cuiPanel20.Size = new Size(1147, 105);
            cuiPanel20.TabIndex = 1;
            // 
            // btnExportarCuentas
            // 
            btnExportarCuentas.BackColor = Color.Transparent;
            btnExportarCuentas.CheckButton = false;
            btnExportarCuentas.Checked = false;
            btnExportarCuentas.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnExportarCuentas.CheckedForeColor = Color.White;
            btnExportarCuentas.CheckedImageTint = Color.White;
            btnExportarCuentas.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnExportarCuentas.Content = "Exportar PDF";
            btnExportarCuentas.DialogResult = DialogResult.None;
            btnExportarCuentas.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnExportarCuentas.ForeColor = Color.Black;
            btnExportarCuentas.HoverBackground = Color.WhiteSmoke;
            btnExportarCuentas.HoverForeColor = Color.DimGray;
            btnExportarCuentas.HoverImageTint = Color.DimGray;
            btnExportarCuentas.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnExportarCuentas.Image = (Image)resources.GetObject("btnExportarCuentas.Image");
            btnExportarCuentas.ImageExpand = new Point(0, 0);
            btnExportarCuentas.Location = new Point(926, 33);
            btnExportarCuentas.Name = "btnExportarCuentas";
            btnExportarCuentas.NormalBackground = Color.White;
            btnExportarCuentas.NormalForeColor = Color.Black;
            btnExportarCuentas.NormalImageTint = Color.White;
            btnExportarCuentas.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnExportarCuentas.OutlineThickness = 1F;
            btnExportarCuentas.Padding = new Padding(12);
            btnExportarCuentas.PressedBackground = Color.WhiteSmoke;
            btnExportarCuentas.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnExportarCuentas.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnExportarCuentas.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnExportarCuentas.Rounding = new Padding(8);
            btnExportarCuentas.Size = new Size(196, 47);
            btnExportarCuentas.TabIndex = 15;
            btnExportarCuentas.TextAlignment = StringAlignment.Center;
            btnExportarCuentas.TextPadding = 12;
            btnExportarCuentas.TextSpacing = 2;
            // 
            // btnRefrescarCuentas
            // 
            btnRefrescarCuentas.CheckButton = false;
            btnRefrescarCuentas.Checked = false;
            btnRefrescarCuentas.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnRefrescarCuentas.CheckedForeColor = Color.White;
            btnRefrescarCuentas.CheckedImageTint = Color.White;
            btnRefrescarCuentas.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnRefrescarCuentas.Content = "Refrescar Cuentas";
            btnRefrescarCuentas.DialogResult = DialogResult.None;
            btnRefrescarCuentas.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnRefrescarCuentas.ForeColor = Color.White;
            btnRefrescarCuentas.HoverBackground = Color.White;
            btnRefrescarCuentas.HoverForeColor = Color.DimGray;
            btnRefrescarCuentas.HoverImageTint = Color.DimGray;
            btnRefrescarCuentas.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnRefrescarCuentas.Image = (Image)resources.GetObject("btnRefrescarCuentas.Image");
            btnRefrescarCuentas.ImageExpand = new Point(0, 0);
            btnRefrescarCuentas.Location = new Point(714, 33);
            btnRefrescarCuentas.Name = "btnRefrescarCuentas";
            btnRefrescarCuentas.NormalBackground = SystemColors.Highlight;
            btnRefrescarCuentas.NormalForeColor = Color.White;
            btnRefrescarCuentas.NormalImageTint = Color.White;
            btnRefrescarCuentas.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnRefrescarCuentas.OutlineThickness = 1F;
            btnRefrescarCuentas.Padding = new Padding(12);
            btnRefrescarCuentas.PressedBackground = Color.WhiteSmoke;
            btnRefrescarCuentas.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnRefrescarCuentas.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnRefrescarCuentas.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnRefrescarCuentas.Rounding = new Padding(8);
            btnRefrescarCuentas.Size = new Size(194, 47);
            btnRefrescarCuentas.TabIndex = 14;
            btnRefrescarCuentas.TextAlignment = StringAlignment.Center;
            btnRefrescarCuentas.TextPadding = 12;
            btnRefrescarCuentas.TextSpacing = 2;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.DimGray;
            label19.Location = new Point(10, 97);
            label19.Name = "label19";
            label19.Size = new Size(93, 16);
            label19.TabIndex = 10;
            label19.Text = "Total Gastado:";
            // 
            // lblTotalGastadoCategoriaTo
            // 
            lblTotalGastadoCategoriaTo.AutoSize = true;
            lblTotalGastadoCategoriaTo.BackColor = Color.Transparent;
            lblTotalGastadoCategoriaTo.Font = new Font("Candara", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotalGastadoCategoriaTo.ForeColor = Color.Red;
            lblTotalGastadoCategoriaTo.Location = new Point(105, 91);
            lblTotalGastadoCategoriaTo.Name = "lblTotalGastadoCategoriaTo";
            lblTotalGastadoCategoriaTo.Size = new Size(82, 23);
            lblTotalGastadoCategoriaTo.TabIndex = 11;
            lblTotalGastadoCategoriaTo.Text = "$7000.00";
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 716);
            Controls.Add(tbcHistorialMovimientos);
            Controls.Add(cuiPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReportes";
            Text = "FrmReportes";
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            tbcHistorialMovimientos.ResumeLayout(false);
            tabMovimientos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReporteMovimientos).EndInit();
            cuiPanel11.ResumeLayout(false);
            cuiPanel11.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            cuiPanel5.ResumeLayout(false);
            cuiPanel5.PerformLayout();
            cuiPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            cuiPanel3.ResumeLayout(false);
            cuiPanel3.PerformLayout();
            cuiPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            cuiPanel9.ResumeLayout(false);
            cuiPanel9.PerformLayout();
            cuiPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            cuiPanel4.ResumeLayout(false);
            cuiPanel4.PerformLayout();
            cuiPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            cuiPanel2.ResumeLayout(false);
            cuiPanel2.PerformLayout();
            tabCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReporteCategorias).EndInit();
            cuiPanel19.ResumeLayout(false);
            cuiPanel19.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            cuiPanel13.ResumeLayout(false);
            cuiPanel13.PerformLayout();
            cuiPanel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            cuiPanel15.ResumeLayout(false);
            cuiPanel15.PerformLayout();
            cuiPanel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            cuiPanel17.ResumeLayout(false);
            cuiPanel17.PerformLayout();
            cuiPanel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            cuiPanel12.ResumeLayout(false);
            cuiPanel12.PerformLayout();
            tabCuentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReporteCuentas).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            cuiPanel22.ResumeLayout(false);
            cuiPanel22.PerformLayout();
            cuiPanel23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            cuiPanel24.ResumeLayout(false);
            cuiPanel24.PerformLayout();
            cuiPanel25.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            cuiPanel26.ResumeLayout(false);
            cuiPanel26.PerformLayout();
            cuiPanel27.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            cuiPanel21.ResumeLayout(false);
            cuiPanel21.PerformLayout();
            cuiPanel20.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private Label label1;
        private TabControl tbcHistorialMovimientos;
        private TabPage tabMovimientos;
        private TabPage tabCategorias;
        private TabPage tabCuentas;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private Label label2;
        private Label label6;
        private Label label4;
        private CuoreUI.Controls.cuiCalendarDatePicker dtpHastaMovimientos;
        private Label label3;
        private CuoreUI.Controls.cuiCalendarDatePicker dtpDesdeMovimientos;
        private CuoreUI.Controls.cuiComboBox cmbTipoMovimiento;
        private CuoreUI.Controls.cuiComboBox cmbCuentasMovimientos;
        private Label label5;
        private CuoreUI.Controls.cuiButton btnFiltrarMovimientos;
        private CuoreUI.Controls.cuiButton btnExportarMovimientos;
        private TableLayoutPanel tableLayoutPanel1;
        private CuoreUI.Controls.cuiPanel cuiPanel4;
        private Label lblFlujoNetoRep;
        private Label label7;
        private CuoreUI.Controls.cuiPanel cuiPanel8;
        private PictureBox pictureBox4;
        private CuoreUI.Controls.cuiPanel cuiPanel5;
        private Label lblTotalIngresosRep;
        private Label label9;
        private CuoreUI.Controls.cuiPanel cuiPanel6;
        private PictureBox pictureBox1;
        private CuoreUI.Controls.cuiPanel cuiPanel3;
        private Label lblTotalGastosRep;
        private Label label8;
        private CuoreUI.Controls.cuiPanel cuiPanel7;
        private PictureBox pictureBox2;
        private CuoreUI.Controls.cuiPanel cuiPanel9;
        private Label lblTotalTransferidoRep;
        private Label lblTituloLiquidez;
        private CuoreUI.Controls.cuiPanel cuiPanel10;
        private PictureBox pictureBox3;
        private CuoreUI.Controls.cuiPanel cuiPanel11;
        private Label label10;
        private DataGridView dgvReporteMovimientos;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colOrigen;
        private DataGridViewTextBoxColumn colDestino;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colMonto;
        private CuoreUI.Controls.cuiPanel cuiPanel12;
        private CuoreUI.Controls.cuiButton btnExportarCat;
        private CuoreUI.Controls.cuiButton btnFiltrarCat;
        private CuoreUI.Controls.cuiComboBox cmbCuentasCat;
        private Label label11;
        private CuoreUI.Controls.cuiCalendarDatePicker dtpHastaCat;
        private Label label13;
        private CuoreUI.Controls.cuiCalendarDatePicker dtpDesdeCat;
        private Label label14;
        private TableLayoutPanel tableLayoutPanel2;
        private CuoreUI.Controls.cuiPanel cuiPanel13;
        private Label label16;
        private Label lblTotalGastoCatRep;
        private Label label15;
        private CuoreUI.Controls.cuiPanel cuiPanel14;
        private PictureBox pictureBox5;
        private CuoreUI.Controls.cuiPanel cuiPanel15;
        private Label lblTopCategoriaRep;
        private Label label18;
        private CuoreUI.Controls.cuiPanel cuiPanel16;
        private PictureBox pictureBox6;
        private CuoreUI.Controls.cuiPanel cuiPanel17;
        private Label label21;
        private Label lblNumTransaccionesCatRep;
        private Label label23;
        private CuoreUI.Controls.cuiPanel cuiPanel18;
        private PictureBox pictureBox7;
        private DataGridView dgvReporteCategorias;
        private CuoreUI.Controls.cuiPanel cuiPanel19;
        private Label label24;
        private DataGridViewTextBoxColumn colCatNombre;
        private DataGridViewTextBoxColumn colCatTotal;
        private DataGridViewTextBoxColumn colCatPorcentaje;
        private DataGridViewTextBoxColumn colCatCantidad;
        private DataGridViewTextBoxColumn colCatPromedio;
        private CuoreUI.Controls.cuiPanel cuiPanel21;
        private Label label12;
        private CuoreUI.Controls.cuiPanel cuiPanel20;
        private CuoreUI.Controls.cuiButton btnExportarCuentas;
        private CuoreUI.Controls.cuiButton btnRefrescarCuentas;
        private TableLayoutPanel tableLayoutPanel3;
        private CuoreUI.Controls.cuiPanel cuiPanel22;
        private Label label22;
        private Label lblLiquidezTotalRep;
        private Label label20;
        private CuoreUI.Controls.cuiPanel cuiPanel23;
        private PictureBox pictureBox8;
        private CuoreUI.Controls.cuiPanel cuiPanel24;
        private Label lblDeudaTotalRep;
        private Label label26;
        private CuoreUI.Controls.cuiPanel cuiPanel25;
        private PictureBox pictureBox9;
        private Label label27;
        private CuoreUI.Controls.cuiPanel cuiPanel26;
        private Label lblPatrimonioNetoRep;
        private CuoreUI.Controls.cuiPanel cuiPanel27;
        private PictureBox pictureBox10;
        private Label label30;
        private Label label29;
        private DataGridView dgvReporteCuentas;
        private DataGridViewTextBoxColumn colCuentaNombre;
        private DataGridViewTextBoxColumn colCuentaTipo;
        private DataGridViewTextBoxColumn colCuentaMoneda;
        private DataGridViewTextBoxColumn colCuentaSaldo;
        private DataGridViewTextBoxColumn colCuentaLimite;
        private DataGridViewTextBoxColumn colCuentaDeuda;
        private DataGridViewTextBoxColumn colCuentaDisponible;
        private Label lblTotalGastadoCategoriaTo;
        private Label label19;
    }
}