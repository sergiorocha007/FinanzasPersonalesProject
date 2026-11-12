namespace ControlFinanzas.UI.Formularios.Seguridad
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            btnPresupuesto = new CuoreUI.Controls.cuiButton();
            btnCerrarSesion = new CuoreUI.Controls.cuiButton();
            btnSalir = new CuoreUI.Controls.cuiButton();
            label2 = new Label();
            label1 = new Label();
            btnReportes = new CuoreUI.Controls.cuiButton();
            btnMetasAhorro = new CuoreUI.Controls.cuiButton();
            btnCategorias = new CuoreUI.Controls.cuiButton();
            btnTransacciones = new CuoreUI.Controls.cuiButton();
            BtnCuentas = new CuoreUI.Controls.cuiButton();
            btnDashboard = new CuoreUI.Controls.cuiButton();
            pictureBox1 = new PictureBox();
            pnlContenedor = new CuoreUI.Controls.cuiPanel();
            cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cuiPanel1
            // 
            cuiPanel1.BackColor = SystemColors.ButtonFace;
            cuiPanel1.Controls.Add(btnPresupuesto);
            cuiPanel1.Controls.Add(btnCerrarSesion);
            cuiPanel1.Controls.Add(btnSalir);
            cuiPanel1.Controls.Add(label2);
            cuiPanel1.Controls.Add(label1);
            cuiPanel1.Controls.Add(btnReportes);
            cuiPanel1.Controls.Add(btnMetasAhorro);
            cuiPanel1.Controls.Add(btnCategorias);
            cuiPanel1.Controls.Add(btnTransacciones);
            cuiPanel1.Controls.Add(BtnCuentas);
            cuiPanel1.Controls.Add(btnDashboard);
            cuiPanel1.Controls.Add(pictureBox1);
            cuiPanel1.Dock = DockStyle.Left;
            cuiPanel1.Location = new Point(0, 0);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(179, 674);
            cuiPanel1.TabIndex = 0;
            // 
            // btnPresupuesto
            // 
            btnPresupuesto.BackColor = Color.Transparent;
            btnPresupuesto.CheckButton = false;
            btnPresupuesto.Checked = false;
            btnPresupuesto.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnPresupuesto.CheckedForeColor = Color.White;
            btnPresupuesto.CheckedImageTint = Color.White;
            btnPresupuesto.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnPresupuesto.Content = "Presupuestos";
            btnPresupuesto.DialogResult = DialogResult.None;
            btnPresupuesto.Font = new Font("Segoe UI", 11.25F);
            btnPresupuesto.ForeColor = Color.Black;
            btnPresupuesto.HoverBackground = Color.PowderBlue;
            btnPresupuesto.HoverForeColor = Color.DimGray;
            btnPresupuesto.HoverImageTint = Color.DimGray;
            btnPresupuesto.HoverOutline = Color.Transparent;
            btnPresupuesto.Image = (Image)resources.GetObject("btnPresupuesto.Image");
            btnPresupuesto.ImageExpand = new Point(2, 2);
            btnPresupuesto.Location = new Point(12, 443);
            btnPresupuesto.Name = "btnPresupuesto";
            btnPresupuesto.NormalBackground = Color.White;
            btnPresupuesto.NormalForeColor = Color.Black;
            btnPresupuesto.NormalImageTint = Color.Black;
            btnPresupuesto.NormalOutline = Color.Transparent;
            btnPresupuesto.OutlineThickness = 1F;
            btnPresupuesto.Padding = new Padding(12);
            btnPresupuesto.PressedBackground = Color.WhiteSmoke;
            btnPresupuesto.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnPresupuesto.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnPresupuesto.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnPresupuesto.Rounding = new Padding(8);
            btnPresupuesto.Size = new Size(153, 45);
            btnPresupuesto.TabIndex = 11;
            btnPresupuesto.TextAlignment = StringAlignment.Near;
            btnPresupuesto.TextPadding = 12;
            btnPresupuesto.TextSpacing = 2;
            btnPresupuesto.Click += btnPresupuesto_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Transparent;
            btnCerrarSesion.CheckButton = false;
            btnCerrarSesion.Checked = false;
            btnCerrarSesion.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnCerrarSesion.CheckedForeColor = Color.White;
            btnCerrarSesion.CheckedImageTint = Color.White;
            btnCerrarSesion.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnCerrarSesion.Content = "Cerrar Sesion ";
            btnCerrarSesion.DialogResult = DialogResult.None;
            btnCerrarSesion.Font = new Font("Segoe UI", 11.25F);
            btnCerrarSesion.ForeColor = Color.Black;
            btnCerrarSesion.HoverBackground = Color.PowderBlue;
            btnCerrarSesion.HoverForeColor = Color.DimGray;
            btnCerrarSesion.HoverImageTint = Color.DimGray;
            btnCerrarSesion.HoverOutline = Color.Transparent;
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.ImageExpand = new Point(2, 2);
            btnCerrarSesion.Location = new Point(12, 572);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.NormalBackground = Color.White;
            btnCerrarSesion.NormalForeColor = Color.Black;
            btnCerrarSesion.NormalImageTint = Color.Black;
            btnCerrarSesion.NormalOutline = Color.Transparent;
            btnCerrarSesion.OutlineThickness = 1F;
            btnCerrarSesion.Padding = new Padding(12);
            btnCerrarSesion.PressedBackground = Color.WhiteSmoke;
            btnCerrarSesion.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnCerrarSesion.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnCerrarSesion.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnCerrarSesion.Rounding = new Padding(8);
            btnCerrarSesion.Size = new Size(153, 45);
            btnCerrarSesion.TabIndex = 10;
            btnCerrarSesion.TextAlignment = StringAlignment.Near;
            btnCerrarSesion.TextPadding = 12;
            btnCerrarSesion.TextSpacing = 2;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.CheckButton = false;
            btnSalir.Checked = false;
            btnSalir.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnSalir.CheckedForeColor = Color.White;
            btnSalir.CheckedImageTint = Color.White;
            btnSalir.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnSalir.Content = "Salir";
            btnSalir.DialogResult = DialogResult.None;
            btnSalir.Font = new Font("Segoe UI", 11.25F);
            btnSalir.ForeColor = Color.Black;
            btnSalir.HoverBackground = Color.PowderBlue;
            btnSalir.HoverForeColor = Color.DimGray;
            btnSalir.HoverImageTint = Color.DimGray;
            btnSalir.HoverOutline = Color.Transparent;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageExpand = new Point(0, 0);
            btnSalir.Location = new Point(12, 623);
            btnSalir.Name = "btnSalir";
            btnSalir.NormalBackground = Color.White;
            btnSalir.NormalForeColor = Color.Black;
            btnSalir.NormalImageTint = Color.Black;
            btnSalir.NormalOutline = Color.Transparent;
            btnSalir.OutlineThickness = 1F;
            btnSalir.Padding = new Padding(12);
            btnSalir.PressedBackground = Color.WhiteSmoke;
            btnSalir.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnSalir.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnSalir.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnSalir.Rounding = new Padding(8);
            btnSalir.Size = new Size(153, 45);
            btnSalir.TabIndex = 9;
            btnSalir.TextAlignment = StringAlignment.Near;
            btnSalir.TextPadding = 12;
            btnSalir.TextSpacing = 2;
            btnSalir.Click += cuiButton7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(76, 82);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 8;
            label2.Text = "Finanzas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(18, 82);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 7;
            label1.Text = "Control";
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.Transparent;
            btnReportes.CheckButton = false;
            btnReportes.Checked = false;
            btnReportes.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnReportes.CheckedForeColor = Color.White;
            btnReportes.CheckedImageTint = Color.White;
            btnReportes.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnReportes.Content = "Reportes";
            btnReportes.DialogResult = DialogResult.None;
            btnReportes.Font = new Font("Segoe UI", 11.25F);
            btnReportes.ForeColor = Color.Black;
            btnReportes.HoverBackground = Color.PowderBlue;
            btnReportes.HoverForeColor = Color.DimGray;
            btnReportes.HoverImageTint = Color.DimGray;
            btnReportes.HoverOutline = Color.Transparent;
            btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
            btnReportes.ImageExpand = new Point(1, 1);
            btnReportes.Location = new Point(12, 507);
            btnReportes.Name = "btnReportes";
            btnReportes.NormalBackground = Color.White;
            btnReportes.NormalForeColor = Color.Black;
            btnReportes.NormalImageTint = Color.Black;
            btnReportes.NormalOutline = Color.Transparent;
            btnReportes.OutlineThickness = 1F;
            btnReportes.Padding = new Padding(12);
            btnReportes.PressedBackground = Color.WhiteSmoke;
            btnReportes.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnReportes.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnReportes.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnReportes.Rounding = new Padding(8);
            btnReportes.Size = new Size(153, 45);
            btnReportes.TabIndex = 6;
            btnReportes.TextAlignment = StringAlignment.Near;
            btnReportes.TextPadding = 12;
            btnReportes.TextSpacing = 2;
            // 
            // btnMetasAhorro
            // 
            btnMetasAhorro.BackColor = Color.Transparent;
            btnMetasAhorro.CheckButton = false;
            btnMetasAhorro.Checked = false;
            btnMetasAhorro.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnMetasAhorro.CheckedForeColor = Color.White;
            btnMetasAhorro.CheckedImageTint = Color.White;
            btnMetasAhorro.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnMetasAhorro.Content = "Metas Ahorro";
            btnMetasAhorro.DialogResult = DialogResult.None;
            btnMetasAhorro.Font = new Font("Segoe UI", 11.25F);
            btnMetasAhorro.ForeColor = Color.Black;
            btnMetasAhorro.HoverBackground = Color.PowderBlue;
            btnMetasAhorro.HoverForeColor = Color.DimGray;
            btnMetasAhorro.HoverImageTint = Color.DimGray;
            btnMetasAhorro.HoverOutline = Color.Transparent;
            btnMetasAhorro.Image = (Image)resources.GetObject("btnMetasAhorro.Image");
            btnMetasAhorro.ImageExpand = new Point(1, 1);
            btnMetasAhorro.Location = new Point(12, 384);
            btnMetasAhorro.Name = "btnMetasAhorro";
            btnMetasAhorro.NormalBackground = Color.White;
            btnMetasAhorro.NormalForeColor = Color.Black;
            btnMetasAhorro.NormalImageTint = Color.Black;
            btnMetasAhorro.NormalOutline = Color.Transparent;
            btnMetasAhorro.OutlineThickness = 1F;
            btnMetasAhorro.Padding = new Padding(12);
            btnMetasAhorro.PressedBackground = Color.WhiteSmoke;
            btnMetasAhorro.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnMetasAhorro.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnMetasAhorro.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnMetasAhorro.Rounding = new Padding(8);
            btnMetasAhorro.Size = new Size(153, 45);
            btnMetasAhorro.TabIndex = 5;
            btnMetasAhorro.TextAlignment = StringAlignment.Near;
            btnMetasAhorro.TextPadding = 12;
            btnMetasAhorro.TextSpacing = 2;
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = Color.Transparent;
            btnCategorias.CheckButton = false;
            btnCategorias.Checked = false;
            btnCategorias.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnCategorias.CheckedForeColor = Color.White;
            btnCategorias.CheckedImageTint = Color.White;
            btnCategorias.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnCategorias.Content = "Categorias";
            btnCategorias.DialogResult = DialogResult.None;
            btnCategorias.Font = new Font("Segoe UI", 11.25F);
            btnCategorias.ForeColor = Color.Black;
            btnCategorias.HoverBackground = Color.PowderBlue;
            btnCategorias.HoverForeColor = Color.DimGray;
            btnCategorias.HoverImageTint = Color.DimGray;
            btnCategorias.HoverOutline = Color.Transparent;
            btnCategorias.Image = (Image)resources.GetObject("btnCategorias.Image");
            btnCategorias.ImageExpand = new Point(0, 0);
            btnCategorias.Location = new Point(12, 321);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.NormalBackground = Color.White;
            btnCategorias.NormalForeColor = Color.Black;
            btnCategorias.NormalImageTint = Color.Black;
            btnCategorias.NormalOutline = Color.Transparent;
            btnCategorias.OutlineThickness = 1F;
            btnCategorias.Padding = new Padding(12);
            btnCategorias.PressedBackground = Color.WhiteSmoke;
            btnCategorias.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnCategorias.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnCategorias.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnCategorias.Rounding = new Padding(8);
            btnCategorias.Size = new Size(153, 45);
            btnCategorias.TabIndex = 4;
            btnCategorias.TextAlignment = StringAlignment.Near;
            btnCategorias.TextPadding = 12;
            btnCategorias.TextSpacing = 2;
            btnCategorias.Click += cuiButton4_Click;
            // 
            // btnTransacciones
            // 
            btnTransacciones.BackColor = Color.Transparent;
            btnTransacciones.CheckButton = false;
            btnTransacciones.Checked = false;
            btnTransacciones.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnTransacciones.CheckedForeColor = Color.White;
            btnTransacciones.CheckedImageTint = Color.White;
            btnTransacciones.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnTransacciones.Content = "Transferencias";
            btnTransacciones.DialogResult = DialogResult.None;
            btnTransacciones.Font = new Font("Segoe UI", 11.25F);
            btnTransacciones.ForeColor = Color.Black;
            btnTransacciones.HoverBackground = Color.PowderBlue;
            btnTransacciones.HoverForeColor = Color.DimGray;
            btnTransacciones.HoverImageTint = Color.DimGray;
            btnTransacciones.HoverOutline = Color.Transparent;
            btnTransacciones.Image = (Image)resources.GetObject("btnTransacciones.Image");
            btnTransacciones.ImageExpand = new Point(3, 3);
            btnTransacciones.Location = new Point(12, 259);
            btnTransacciones.Name = "btnTransacciones";
            btnTransacciones.NormalBackground = Color.White;
            btnTransacciones.NormalForeColor = Color.Black;
            btnTransacciones.NormalImageTint = Color.Black;
            btnTransacciones.NormalOutline = Color.Transparent;
            btnTransacciones.OutlineThickness = 1F;
            btnTransacciones.Padding = new Padding(12);
            btnTransacciones.PressedBackground = Color.WhiteSmoke;
            btnTransacciones.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnTransacciones.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnTransacciones.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnTransacciones.Rounding = new Padding(8);
            btnTransacciones.Size = new Size(153, 45);
            btnTransacciones.TabIndex = 3;
            btnTransacciones.TextAlignment = StringAlignment.Near;
            btnTransacciones.TextPadding = 12;
            btnTransacciones.TextSpacing = 2;
            btnTransacciones.Click += cuiButton3_Click;
            // 
            // BtnCuentas
            // 
            BtnCuentas.BackColor = Color.Transparent;
            BtnCuentas.CheckButton = false;
            BtnCuentas.Checked = false;
            BtnCuentas.CheckedBackground = Color.FromArgb(255, 106, 0);
            BtnCuentas.CheckedForeColor = Color.White;
            BtnCuentas.CheckedImageTint = Color.White;
            BtnCuentas.CheckedOutline = Color.FromArgb(255, 106, 0);
            BtnCuentas.Content = "Cuentas";
            BtnCuentas.DialogResult = DialogResult.None;
            BtnCuentas.Font = new Font("Segoe UI", 11.25F);
            BtnCuentas.ForeColor = Color.Black;
            BtnCuentas.HoverBackground = Color.PowderBlue;
            BtnCuentas.HoverForeColor = Color.DimGray;
            BtnCuentas.HoverImageTint = Color.DimGray;
            BtnCuentas.HoverOutline = Color.Transparent;
            BtnCuentas.Image = (Image)resources.GetObject("BtnCuentas.Image");
            BtnCuentas.ImageExpand = new Point(1, 1);
            BtnCuentas.Location = new Point(12, 198);
            BtnCuentas.Name = "BtnCuentas";
            BtnCuentas.NormalBackground = Color.White;
            BtnCuentas.NormalForeColor = Color.Black;
            BtnCuentas.NormalImageTint = Color.Black;
            BtnCuentas.NormalOutline = Color.Transparent;
            BtnCuentas.OutlineThickness = 1F;
            BtnCuentas.Padding = new Padding(12);
            BtnCuentas.PressedBackground = Color.WhiteSmoke;
            BtnCuentas.PressedForeColor = Color.FromArgb(32, 32, 32);
            BtnCuentas.PressedImageTint = Color.FromArgb(32, 32, 32);
            BtnCuentas.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            BtnCuentas.Rounding = new Padding(8);
            BtnCuentas.Size = new Size(153, 45);
            BtnCuentas.TabIndex = 2;
            BtnCuentas.TextAlignment = StringAlignment.Near;
            BtnCuentas.TextPadding = 12;
            BtnCuentas.TextSpacing = 2;
            BtnCuentas.Click += cuiButton2_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.CheckButton = false;
            btnDashboard.Checked = false;
            btnDashboard.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnDashboard.CheckedForeColor = Color.White;
            btnDashboard.CheckedImageTint = Color.White;
            btnDashboard.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnDashboard.Content = "Dashboard";
            btnDashboard.DialogResult = DialogResult.None;
            btnDashboard.Font = new Font("Segoe UI", 11.25F);
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.HoverBackground = Color.PowderBlue;
            btnDashboard.HoverForeColor = Color.DimGray;
            btnDashboard.HoverImageTint = Color.DimGray;
            btnDashboard.HoverOutline = Color.Transparent;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageExpand = new Point(1, 1);
            btnDashboard.ImeMode = ImeMode.NoControl;
            btnDashboard.Location = new Point(12, 135);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.NormalBackground = Color.White;
            btnDashboard.NormalForeColor = Color.Black;
            btnDashboard.NormalImageTint = Color.Black;
            btnDashboard.NormalOutline = Color.Transparent;
            btnDashboard.OutlineThickness = 1F;
            btnDashboard.Padding = new Padding(12);
            btnDashboard.PressedBackground = Color.WhiteSmoke;
            btnDashboard.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnDashboard.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnDashboard.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnDashboard.Rounding = new Padding(8);
            btnDashboard.Size = new Size(153, 45);
            btnDashboard.TabIndex = 1;
            btnDashboard.TextAlignment = StringAlignment.Near;
            btnDashboard.TextPadding = 12;
            btnDashboard.TextSpacing = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContenedor.Location = new Point(185, 0);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.OutlineThickness = 1F;
            pnlContenedor.PanelColor = Color.White;
            pnlContenedor.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            pnlContenedor.Rounding = new Padding(12);
            pnlContenedor.Size = new Size(788, 674);
            pnlContenedor.TabIndex = 1;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(977, 674);
            Controls.Add(pnlContenedor);
            Controls.Add(cuiPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmInicio";
            Text = "FrmCuentas";
            WindowState = FormWindowState.Maximized;
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiButton BtnCuentas;
        private CuoreUI.Controls.cuiButton btnDashboard;
        private PictureBox pictureBox1;
        private CuoreUI.Controls.cuiButton btnReportes;
        private CuoreUI.Controls.cuiButton btnMetasAhorro;
        private CuoreUI.Controls.cuiButton btnCategorias;
        private CuoreUI.Controls.cuiButton btnTransacciones;
        private Label label2;
        private Label label1;
        private CuoreUI.Controls.cuiButton btnSalir;
        private CuoreUI.Controls.cuiPanel pnlContenedor;
        private CuoreUI.Controls.cuiButton btnCerrarSesion;
        private CuoreUI.Controls.cuiButton btnPresupuesto;
    }
}