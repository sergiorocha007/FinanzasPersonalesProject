namespace ControlFinanzas.UI.Formularios
{
    partial class FrmMetasAhorro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMetasAhorro));
            label2 = new Label();
            label3 = new Label();
            cuiPanel5 = new CuoreUI.Controls.cuiPanel();
            label6 = new Label();
            dtpFechaLimite = new DateTimePicker();
            txtNombreMeta = new CuoreUI.Controls.cuiTextBox();
            numMontoObjetivo = new NumericUpDown();
            label5 = new Label();
            btnCancelar = new CuoreUI.Controls.cuiButton();
            btnGuardarMeta = new CuoreUI.Controls.cuiButton();
            label4 = new Label();
            label1 = new Label();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            cmbSeleccionarTipo = new CuoreUI.Controls.cuiComboBox();
            btnFiltrar = new CuoreUI.Controls.cuiButton();
            label9 = new Label();
            label10 = new Label();
            flpContenedordeTrajetas = new FlowLayoutPanel();
            pnlCardLiquidez = new CuoreUI.Controls.cuiPanel();
            cuiPanel4 = new CuoreUI.Controls.cuiPanel();
            cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            lblTotalMetasActivas = new Label();
            lblTituloLiquidez = new Label();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            cuiPanel6 = new CuoreUI.Controls.cuiPanel();
            cuiPictureBox2 = new CuoreUI.Controls.cuiPictureBox();
            lblTotalDineroAhorrado = new Label();
            label8 = new Label();
            cuiPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMontoObjetivo).BeginInit();
            cuiPanel1.SuspendLayout();
            pnlCardLiquidez.SuspendLayout();
            cuiPanel4.SuspendLayout();
            cuiPanel2.SuspendLayout();
            cuiPanel6.SuspendLayout();
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
            label2.Size = new Size(359, 20);
            label2.TabIndex = 5;
            label2.Text = "Planifica y da seguimiento a tus objetivos financieros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 25);
            label3.Name = "label3";
            label3.Size = new Size(178, 30);
            label3.TabIndex = 4;
            label3.Text = "Metas de Ahorro";
            // 
            // cuiPanel5
            // 
            cuiPanel5.Controls.Add(label6);
            cuiPanel5.Controls.Add(dtpFechaLimite);
            cuiPanel5.Controls.Add(txtNombreMeta);
            cuiPanel5.Controls.Add(numMontoObjetivo);
            cuiPanel5.Controls.Add(label5);
            cuiPanel5.Controls.Add(btnCancelar);
            cuiPanel5.Controls.Add(btnGuardarMeta);
            cuiPanel5.Controls.Add(label4);
            cuiPanel5.Controls.Add(label1);
            cuiPanel5.Location = new Point(18, 107);
            cuiPanel5.Name = "cuiPanel5";
            cuiPanel5.OutlineThickness = 1F;
            cuiPanel5.PanelColor = Color.White;
            cuiPanel5.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel5.Rounding = new Padding(15);
            cuiPanel5.Size = new Size(481, 246);
            cuiPanel5.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(240, 116);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 22;
            label6.Text = "Fecha Limite";
            // 
            // dtpFechaLimite
            // 
            dtpFechaLimite.Location = new Point(240, 145);
            dtpFechaLimite.Name = "dtpFechaLimite";
            dtpFechaLimite.Size = new Size(229, 23);
            dtpFechaLimite.TabIndex = 21;
            dtpFechaLimite.ValueChanged += dtpFechaLimite_ValueChanged;
            // 
            // txtNombreMeta
            // 
            txtNombreMeta.BackColor = Color.Transparent;
            txtNombreMeta.BackgroundColor = Color.White;
            txtNombreMeta.Content = "";
            txtNombreMeta.FocusBackgroundColor = Color.White;
            txtNombreMeta.FocusImageTint = Color.White;
            txtNombreMeta.FocusOutlineColor = SystemColors.MenuHighlight;
            txtNombreMeta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreMeta.ForeColor = Color.DimGray;
            txtNombreMeta.Image = null;
            txtNombreMeta.ImageExpand = new Point(0, 0);
            txtNombreMeta.ImageOffset = new Point(0, 0);
            txtNombreMeta.Location = new Point(17, 71);
            txtNombreMeta.Margin = new Padding(4);
            txtNombreMeta.Multiline = false;
            txtNombreMeta.Name = "txtNombreMeta";
            txtNombreMeta.NormalImageTint = Color.White;
            txtNombreMeta.OutlineColor = Color.DarkGray;
            txtNombreMeta.Padding = new Padding(20, 8, 20, 0);
            txtNombreMeta.PasswordChar = false;
            txtNombreMeta.PlaceholderColor = Color.Silver;
            txtNombreMeta.PlaceholderText = "ej: Comprar Carro, Fondos Extras";
            txtNombreMeta.Rounding = new Padding(15);
            txtNombreMeta.Size = new Size(452, 36);
            txtNombreMeta.TabIndex = 20;
            txtNombreMeta.TextOffset = new Size(0, 0);
            txtNombreMeta.UnderlinedStyle = true;
            txtNombreMeta.ContentChanged += txtNombreMeta_ContentChanged;
            // 
            // numMontoObjetivo
            // 
            numMontoObjetivo.BorderStyle = BorderStyle.FixedSingle;
            numMontoObjetivo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numMontoObjetivo.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            numMontoObjetivo.Location = new Point(17, 139);
            numMontoObjetivo.Name = "numMontoObjetivo";
            numMontoObjetivo.Size = new Size(202, 29);
            numMontoObjetivo.TabIndex = 15;
            numMontoObjetivo.TextAlign = HorizontalAlignment.Center;
            numMontoObjetivo.ValueChanged += numMontoObjetivo_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(12, 116);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 14;
            label5.Text = "Monto Objetivo";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.CheckButton = false;
            btnCancelar.Checked = false;
            btnCancelar.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnCancelar.CheckedForeColor = Color.White;
            btnCancelar.CheckedImageTint = Color.White;
            btnCancelar.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnCancelar.Content = "Cancelar";
            btnCancelar.DialogResult = DialogResult.None;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.HoverBackground = Color.Transparent;
            btnCancelar.HoverForeColor = Color.DimGray;
            btnCancelar.HoverImageTint = Color.DimGray;
            btnCancelar.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnCancelar.Image = null;
            btnCancelar.ImageExpand = new Point(0, 0);
            btnCancelar.Location = new Point(191, 188);
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
            btnCancelar.Size = new Size(168, 34);
            btnCancelar.TabIndex = 13;
            btnCancelar.TextAlignment = StringAlignment.Center;
            btnCancelar.TextPadding = 12;
            btnCancelar.TextSpacing = 2;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardarMeta
            // 
            btnGuardarMeta.BackColor = Color.Transparent;
            btnGuardarMeta.CheckButton = false;
            btnGuardarMeta.Checked = false;
            btnGuardarMeta.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnGuardarMeta.CheckedForeColor = Color.White;
            btnGuardarMeta.CheckedImageTint = Color.White;
            btnGuardarMeta.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnGuardarMeta.Content = "Guardar Meta";
            btnGuardarMeta.DialogResult = DialogResult.None;
            btnGuardarMeta.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnGuardarMeta.ForeColor = Color.White;
            btnGuardarMeta.HoverBackground = Color.White;
            btnGuardarMeta.HoverForeColor = Color.DimGray;
            btnGuardarMeta.HoverImageTint = Color.DimGray;
            btnGuardarMeta.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnGuardarMeta.Image = (Image)resources.GetObject("btnGuardarMeta.Image");
            btnGuardarMeta.ImageExpand = new Point(0, 0);
            btnGuardarMeta.Location = new Point(17, 188);
            btnGuardarMeta.Name = "btnGuardarMeta";
            btnGuardarMeta.NormalBackground = SystemColors.Highlight;
            btnGuardarMeta.NormalForeColor = Color.White;
            btnGuardarMeta.NormalImageTint = Color.White;
            btnGuardarMeta.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnGuardarMeta.OutlineThickness = 1F;
            btnGuardarMeta.Padding = new Padding(12);
            btnGuardarMeta.PressedBackground = Color.WhiteSmoke;
            btnGuardarMeta.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnGuardarMeta.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnGuardarMeta.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnGuardarMeta.Rounding = new Padding(8);
            btnGuardarMeta.Size = new Size(168, 34);
            btnGuardarMeta.TabIndex = 12;
            btnGuardarMeta.TextAlignment = StringAlignment.Center;
            btnGuardarMeta.TextPadding = 12;
            btnGuardarMeta.TextSpacing = 2;
            btnGuardarMeta.Click += btnGuardarMeta_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(12, 47);
            label4.Name = "label4";
            label4.Size = new Size(148, 20);
            label4.TabIndex = 3;
            label4.Text = "Nombre de la Meta ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(183, 21);
            label1.TabIndex = 1;
            label1.Text = "Nueva Meta de Ahorro";
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(cmbSeleccionarTipo);
            cuiPanel1.Controls.Add(btnFiltrar);
            cuiPanel1.Controls.Add(label9);
            cuiPanel1.Controls.Add(label10);
            cuiPanel1.Location = new Point(519, 107);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel1.Rounding = new Padding(15);
            cuiPanel1.Size = new Size(360, 246);
            cuiPanel1.TabIndex = 7;
            // 
            // cmbSeleccionarTipo
            // 
            cmbSeleccionarTipo.BackColor = Color.Transparent;
            cmbSeleccionarTipo.BackgroundColor = Color.FromArgb(255, 255, 255);
            cmbSeleccionarTipo.DropDownBackgroundColor = Color.White;
            cmbSeleccionarTipo.DropDownForeColor = Color.FromArgb(27, 27, 27);
            cmbSeleccionarTipo.ExpandArrowColor = Color.DimGray;
            cmbSeleccionarTipo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbSeleccionarTipo.ForeColor = Color.Gray;
            cmbSeleccionarTipo.Items = new string[]
    {
    "Item 1",
    "Item 2",
    "Item 3"
    };
            cmbSeleccionarTipo.Location = new Point(13, 100);
            cmbSeleccionarTipo.Margin = new Padding(5, 4, 5, 4);
            cmbSeleccionarTipo.MaxDropDownHeight = 240;
            cmbSeleccionarTipo.Name = "cmbSeleccionarTipo";
            cmbSeleccionarTipo.NoSelectionText = "Seleccione Tipo";
            cmbSeleccionarTipo.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cmbSeleccionarTipo.OutlineThickness = 1F;
            cmbSeleccionarTipo.Rounding = 8;
            cmbSeleccionarTipo.SelectedIndex = -1;
            cmbSeleccionarTipo.SelectedItem = "";
            cmbSeleccionarTipo.Size = new Size(338, 36);
            cmbSeleccionarTipo.SortAlphabetically = false;
            cmbSeleccionarTipo.TabIndex = 13;
            cmbSeleccionarTipo.SelectedIndexChanged += cmbSeleccionarTipo_SelectedIndexChanged;
            // 
            // btnFiltrar
            // 
            btnFiltrar.CheckButton = false;
            btnFiltrar.Checked = false;
            btnFiltrar.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnFiltrar.CheckedForeColor = Color.White;
            btnFiltrar.CheckedImageTint = Color.White;
            btnFiltrar.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnFiltrar.Content = "Filtrar";
            btnFiltrar.DialogResult = DialogResult.None;
            btnFiltrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnFiltrar.ForeColor = Color.White;
            btnFiltrar.HoverBackground = Color.White;
            btnFiltrar.HoverForeColor = Color.DimGray;
            btnFiltrar.HoverImageTint = Color.DimGray;
            btnFiltrar.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnFiltrar.Image = (Image)resources.GetObject("btnFiltrar.Image");
            btnFiltrar.ImageExpand = new Point(0, 0);
            btnFiltrar.Location = new Point(13, 145);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.NormalBackground = SystemColors.Highlight;
            btnFiltrar.NormalForeColor = Color.White;
            btnFiltrar.NormalImageTint = Color.White;
            btnFiltrar.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnFiltrar.OutlineThickness = 1F;
            btnFiltrar.Padding = new Padding(12);
            btnFiltrar.PressedBackground = Color.WhiteSmoke;
            btnFiltrar.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnFiltrar.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnFiltrar.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnFiltrar.Rounding = new Padding(8);
            btnFiltrar.Size = new Size(338, 34);
            btnFiltrar.TabIndex = 12;
            btnFiltrar.TextAlignment = StringAlignment.Center;
            btnFiltrar.TextPadding = 12;
            btnFiltrar.TextSpacing = 2;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(8, 71);
            label9.Name = "label9";
            label9.Size = new Size(133, 20);
            label9.TabIndex = 3;
            label9.Text = "Estado de la Meta";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(13, 18);
            label10.Name = "label10";
            label10.Size = new Size(184, 21);
            label10.TabIndex = 1;
            label10.Text = "Filtrar Todas Mis Metas";
            // 
            // flpContenedordeTrajetas
            // 
            flpContenedordeTrajetas.Location = new Point(20, 364);
            flpContenedordeTrajetas.Name = "flpContenedordeTrajetas";
            flpContenedordeTrajetas.Size = new Size(1139, 340);
            flpContenedordeTrajetas.TabIndex = 8;
            // 
            // pnlCardLiquidez
            // 
            pnlCardLiquidez.BackColor = Color.Transparent;
            pnlCardLiquidez.Controls.Add(cuiPanel4);
            pnlCardLiquidez.Controls.Add(lblTotalMetasActivas);
            pnlCardLiquidez.Controls.Add(lblTituloLiquidez);
            pnlCardLiquidez.Location = new Point(891, 125);
            pnlCardLiquidez.Name = "pnlCardLiquidez";
            pnlCardLiquidez.OutlineThickness = 1F;
            pnlCardLiquidez.PanelColor = Color.White;
            pnlCardLiquidez.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            pnlCardLiquidez.Rounding = new Padding(15);
            pnlCardLiquidez.Size = new Size(268, 90);
            pnlCardLiquidez.TabIndex = 9;
            // 
            // cuiPanel4
            // 
            cuiPanel4.BackColor = Color.Transparent;
            cuiPanel4.Controls.Add(cuiPictureBox1);
            cuiPanel4.Location = new Point(15, 29);
            cuiPanel4.Name = "cuiPanel4";
            cuiPanel4.OutlineThickness = 1F;
            cuiPanel4.PanelColor = SystemColors.Highlight;
            cuiPanel4.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel4.Rounding = new Padding(15);
            cuiPanel4.Size = new Size(41, 36);
            cuiPanel4.TabIndex = 14;
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
            // lblTotalMetasActivas
            // 
            lblTotalMetasActivas.AutoSize = true;
            lblTotalMetasActivas.BackColor = Color.Transparent;
            lblTotalMetasActivas.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalMetasActivas.ForeColor = Color.FromArgb(0, 0, 192);
            lblTotalMetasActivas.Location = new Point(118, 39);
            lblTotalMetasActivas.Name = "lblTotalMetasActivas";
            lblTotalMetasActivas.Size = new Size(25, 26);
            lblTotalMetasActivas.TabIndex = 1;
            lblTotalMetasActivas.Text = "4";
            // 
            // lblTituloLiquidez
            // 
            lblTituloLiquidez.AutoSize = true;
            lblTituloLiquidez.BackColor = Color.Transparent;
            lblTituloLiquidez.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            lblTituloLiquidez.ForeColor = SystemColors.ActiveCaptionText;
            lblTituloLiquidez.Location = new Point(52, 9);
            lblTituloLiquidez.Name = "lblTituloLiquidez";
            lblTituloLiquidez.Size = new Size(151, 19);
            lblTituloLiquidez.TabIndex = 0;
            lblTituloLiquidez.Text = "Total Metas Activas";
            // 
            // cuiPanel2
            // 
            cuiPanel2.BackColor = Color.Transparent;
            cuiPanel2.Controls.Add(cuiPanel6);
            cuiPanel2.Controls.Add(lblTotalDineroAhorrado);
            cuiPanel2.Controls.Add(label8);
            cuiPanel2.Location = new Point(891, 239);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.White;
            cuiPanel2.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel2.Rounding = new Padding(15);
            cuiPanel2.Size = new Size(268, 90);
            cuiPanel2.TabIndex = 10;
            // 
            // cuiPanel6
            // 
            cuiPanel6.BackColor = Color.Transparent;
            cuiPanel6.Controls.Add(cuiPictureBox2);
            cuiPanel6.Location = new Point(12, 34);
            cuiPanel6.Name = "cuiPanel6";
            cuiPanel6.OutlineThickness = 1F;
            cuiPanel6.PanelColor = Color.MediumSeaGreen;
            cuiPanel6.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel6.Rounding = new Padding(15);
            cuiPanel6.Size = new Size(36, 34);
            cuiPanel6.TabIndex = 15;
            // 
            // cuiPictureBox2
            // 
            cuiPictureBox2.BackColor = Color.Transparent;
            cuiPictureBox2.Content = (Image)resources.GetObject("cuiPictureBox2.Content");
            cuiPictureBox2.ImageTint = Color.White;
            cuiPictureBox2.Location = new Point(1, -2);
            cuiPictureBox2.Margin = new Padding(4, 3, 4, 3);
            cuiPictureBox2.Name = "cuiPictureBox2";
            cuiPictureBox2.OutlineThickness = 1F;
            cuiPictureBox2.PanelOutlineColor = Color.Transparent;
            cuiPictureBox2.Rotation = 0;
            cuiPictureBox2.Rounding = new Padding(0);
            cuiPictureBox2.Size = new Size(31, 33);
            cuiPictureBox2.TabIndex = 12;
            // 
            // lblTotalDineroAhorrado
            // 
            lblTotalDineroAhorrado.AutoSize = true;
            lblTotalDineroAhorrado.BackColor = Color.Transparent;
            lblTotalDineroAhorrado.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDineroAhorrado.ForeColor = Color.Green;
            lblTotalDineroAhorrado.Location = new Point(89, 39);
            lblTotalDineroAhorrado.Name = "lblTotalDineroAhorrado";
            lblTotalDineroAhorrado.Size = new Size(100, 26);
            lblTotalDineroAhorrado.TabIndex = 1;
            lblTotalDineroAhorrado.Text = "$ 100.00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(52, 9);
            label8.Name = "label8";
            label8.Size = new Size(174, 19);
            label8.TabIndex = 0;
            label8.Text = "Total Dinero Ahorrado";
            // 
            // FrmMetasAhorro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 716);
            Controls.Add(cuiPanel2);
            Controls.Add(pnlCardLiquidez);
            Controls.Add(flpContenedordeTrajetas);
            Controls.Add(cuiPanel1);
            Controls.Add(cuiPanel5);
            Controls.Add(label2);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMetasAhorro";
            Text = "FrmMetasAhorro";
            cuiPanel5.ResumeLayout(false);
            cuiPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMontoObjetivo).EndInit();
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            pnlCardLiquidez.ResumeLayout(false);
            pnlCardLiquidez.PerformLayout();
            cuiPanel4.ResumeLayout(false);
            cuiPanel2.ResumeLayout(false);
            cuiPanel2.PerformLayout();
            cuiPanel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private CuoreUI.Controls.cuiPanel cuiPanel5;
        private NumericUpDown numMontoObjetivo;
        private Label label5;
        private CuoreUI.Controls.cuiButton btnCancelar;
        private CuoreUI.Controls.cuiButton btnGuardarMeta;
        private Label label4;
        private Label label1;
        private CuoreUI.Controls.cuiTextBox txtNombreMeta;
        private Label label6;
        private DateTimePicker dtpFechaLimite;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiButton btnFiltrar;
        private Label label9;
        private Label label10;
        private CuoreUI.Controls.cuiComboBox cmbSeleccionarTipo;
        private FlowLayoutPanel flpContenedordeTrajetas;
        private CuoreUI.Controls.cuiPanel pnlCardLiquidez;
        private Label lblTotalMetasActivas;
        private Label lblTituloLiquidez;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private Label lblTotalDineroAhorrado;
        private Label label8;
        private CuoreUI.Controls.cuiPanel cuiPanel4;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiPanel cuiPanel6;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
    }
}