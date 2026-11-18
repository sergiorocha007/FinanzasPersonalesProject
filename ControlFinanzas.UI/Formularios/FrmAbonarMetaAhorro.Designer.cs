namespace ControlFinanzas.UI.Formularios
{
    partial class FrmAbonarMetaAhorro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTituloMeta;
        private System.Windows.Forms.Button btnCerrarX;
        private System.Windows.Forms.Label lblMontoFaltante;
        private System.Windows.Forms.Panel pnlLineaHeader;
        private System.Windows.Forms.Label lblCuentaTitulo;
        private System.Windows.Forms.Label lblSaldoCuenta;
        private System.Windows.Forms.Label lblMontoTitulo;
        private System.Windows.Forms.Panel pnlMontoWrapper;
        private System.Windows.Forms.Label lblSimboloMoneda;
        private System.Windows.Forms.NumericUpDown nudMontoAbono;
        private System.Windows.Forms.Panel pnlSugerencia;
        private System.Windows.Forms.Label lblSugerencia;
        private System.Windows.Forms.LinkLabel lnkUsarSugerencia;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlLineaFooter;

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
            pnlHeader = new Panel();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            lblMontoFaltante = new Label();
            btnCerrarX = new Button();
            lblTituloMeta = new Label();
            pnlLineaHeader = new Panel();
            lblCuentaTitulo = new Label();
            lblSaldoCuenta = new Label();
            lblMontoTitulo = new Label();
            pnlMontoWrapper = new Panel();
            nudMontoAbono = new NumericUpDown();
            lblSimboloMoneda = new Label();
            pnlSugerencia = new Panel();
            lnkUsarSugerencia = new LinkLabel();
            lblSugerencia = new Label();
            pnlFooter = new Panel();
            btnCancelar = new CuoreUI.Controls.cuiButton();
            btnConfirmarTransferencia = new CuoreUI.Controls.cuiButton();
            pnlLineaFooter = new Panel();
            cmbCuentaOrigen = new ComboBox();
            pnlHeader.SuspendLayout();
            cuiPanel1.SuspendLayout();
            pnlMontoWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMontoAbono).BeginInit();
            pnlSugerencia.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(cuiPanel1);
            pnlHeader.Controls.Add(btnCerrarX);
            pnlHeader.Controls.Add(lblTituloMeta);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(430, 100);
            pnlHeader.TabIndex = 7;
            // 
            // cuiPanel1
            // 
            cuiPanel1.BackColor = Color.Transparent;
            cuiPanel1.Controls.Add(lblMontoFaltante);
            cuiPanel1.Location = new Point(24, 59);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.FromArgb(254, 243, 199);
            cuiPanel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel1.Rounding = new Padding(12);
            cuiPanel1.Size = new Size(260, 26);
            cuiPanel1.TabIndex = 3;
            // 
            // lblMontoFaltante
            // 
            lblMontoFaltante.BackColor = Color.Transparent;
            lblMontoFaltante.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMontoFaltante.ForeColor = Color.FromArgb(217, 119, 6);
            lblMontoFaltante.Location = new Point(5, 0);
            lblMontoFaltante.Name = "lblMontoFaltante";
            lblMontoFaltante.Size = new Size(252, 26);
            lblMontoFaltante.TabIndex = 0;
            lblMontoFaltante.Text = "Faltan $2,350.00 para completar la meta";
            lblMontoFaltante.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCerrarX
            // 
            btnCerrarX.BackColor = Color.Transparent;
            btnCerrarX.Cursor = Cursors.Hand;
            btnCerrarX.FlatAppearance.BorderSize = 0;
            btnCerrarX.FlatStyle = FlatStyle.Flat;
            btnCerrarX.Font = new Font("Segoe UI", 11F);
            btnCerrarX.ForeColor = Color.FromArgb(100, 116, 139);
            btnCerrarX.Location = new Point(386, 12);
            btnCerrarX.Name = "btnCerrarX";
            btnCerrarX.Size = new Size(32, 32);
            btnCerrarX.TabIndex = 1;
            btnCerrarX.Text = "✕";
            btnCerrarX.UseVisualStyleBackColor = false;
            btnCerrarX.Click += btnCerrarX_Click;
            // 
            // lblTituloMeta
            // 
            lblTituloMeta.AutoSize = true;
            lblTituloMeta.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTituloMeta.ForeColor = Color.FromArgb(15, 23, 42);
            lblTituloMeta.Location = new Point(24, 22);
            lblTituloMeta.Name = "lblTituloMeta";
            lblTituloMeta.Size = new Size(283, 25);
            lblTituloMeta.TabIndex = 2;
            lblTituloMeta.Text = "Abonar a: Fondo de Emergencia";
            // 
            // pnlLineaHeader
            // 
            pnlLineaHeader.BackColor = Color.FromArgb(226, 232, 240);
            pnlLineaHeader.Dock = DockStyle.Top;
            pnlLineaHeader.Location = new Point(0, 100);
            pnlLineaHeader.Name = "pnlLineaHeader";
            pnlLineaHeader.Size = new Size(430, 1);
            pnlLineaHeader.TabIndex = 6;
            // 
            // lblCuentaTitulo
            // 
            lblCuentaTitulo.AutoSize = true;
            lblCuentaTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblCuentaTitulo.ForeColor = Color.FromArgb(30, 41, 59);
            lblCuentaTitulo.Location = new Point(24, 126);
            lblCuentaTitulo.Name = "lblCuentaTitulo";
            lblCuentaTitulo.Size = new Size(130, 20);
            lblCuentaTitulo.TabIndex = 5;
            lblCuentaTitulo.Text = "Cuenta de Origen";
            // 
            // lblSaldoCuenta
            // 
            lblSaldoCuenta.AutoSize = true;
            lblSaldoCuenta.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaldoCuenta.ForeColor = Color.FromArgb(100, 116, 139);
            lblSaldoCuenta.Location = new Point(24, 198);
            lblSaldoCuenta.Name = "lblSaldoCuenta";
            lblSaldoCuenta.Size = new Size(167, 17);
            lblSaldoCuenta.TabIndex = 3;
            lblSaldoCuenta.Text = "Saldo disponible: $1,250.00";
            // 
            // lblMontoTitulo
            // 
            lblMontoTitulo.AutoSize = true;
            lblMontoTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblMontoTitulo.ForeColor = Color.FromArgb(30, 41, 59);
            lblMontoTitulo.Location = new Point(24, 234);
            lblMontoTitulo.Name = "lblMontoTitulo";
            lblMontoTitulo.Size = new Size(124, 20);
            lblMontoTitulo.TabIndex = 2;
            lblMontoTitulo.Text = "Monto a Abonar";
            // 
            // pnlMontoWrapper
            // 
            pnlMontoWrapper.BackColor = Color.White;
            pnlMontoWrapper.Controls.Add(nudMontoAbono);
            pnlMontoWrapper.Controls.Add(lblSimboloMoneda);
            pnlMontoWrapper.Location = new Point(24, 258);
            pnlMontoWrapper.Name = "pnlMontoWrapper";
            pnlMontoWrapper.Size = new Size(382, 58);
            pnlMontoWrapper.TabIndex = 1;
            // 
            // nudMontoAbono
            // 
            nudMontoAbono.BorderStyle = BorderStyle.None;
            nudMontoAbono.DecimalPlaces = 2;
            nudMontoAbono.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            nudMontoAbono.ForeColor = Color.FromArgb(15, 23, 42);
            nudMontoAbono.Location = new Point(44, 11);
            nudMontoAbono.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudMontoAbono.Name = "nudMontoAbono";
            nudMontoAbono.Size = new Size(324, 39);
            nudMontoAbono.TabIndex = 0;
            nudMontoAbono.ThousandsSeparator = true;
            nudMontoAbono.ValueChanged += nudMontoAbono_ValueChanged;
            // 
            // lblSimboloMoneda
            // 
            lblSimboloMoneda.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSimboloMoneda.ForeColor = Color.FromArgb(100, 116, 139);
            lblSimboloMoneda.Location = new Point(12, 8);
            lblSimboloMoneda.Name = "lblSimboloMoneda";
            lblSimboloMoneda.Size = new Size(30, 40);
            lblSimboloMoneda.TabIndex = 1;
            lblSimboloMoneda.Text = "$";
            lblSimboloMoneda.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSugerencia
            // 
            pnlSugerencia.BackColor = Color.FromArgb(236, 253, 245);
            pnlSugerencia.Controls.Add(lnkUsarSugerencia);
            pnlSugerencia.Controls.Add(lblSugerencia);
            pnlSugerencia.Location = new Point(24, 332);
            pnlSugerencia.Name = "pnlSugerencia";
            pnlSugerencia.Size = new Size(382, 42);
            pnlSugerencia.TabIndex = 0;
            // 
            // lnkUsarSugerencia
            // 
            lnkUsarSugerencia.ActiveLinkColor = Color.FromArgb(21, 128, 61);
            lnkUsarSugerencia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkUsarSugerencia.LinkBehavior = LinkBehavior.NeverUnderline;
            lnkUsarSugerencia.LinkColor = Color.FromArgb(71, 85, 105);
            lnkUsarSugerencia.Location = new Point(322, 0);
            lnkUsarSugerencia.Name = "lnkUsarSugerencia";
            lnkUsarSugerencia.Size = new Size(48, 42);
            lnkUsarSugerencia.TabIndex = 0;
            lnkUsarSugerencia.TabStop = true;
            lnkUsarSugerencia.Text = "Usar";
            lnkUsarSugerencia.TextAlign = ContentAlignment.MiddleRight;
            lnkUsarSugerencia.LinkClicked += lnkUsarSugerencia_LinkClicked;
            // 
            // lblSugerencia
            // 
            lblSugerencia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSugerencia.ForeColor = Color.FromArgb(15, 23, 42);
            lblSugerencia.Location = new Point(12, 0);
            lblSugerencia.Name = "lblSugerencia";
            lblSugerencia.Size = new Size(305, 42);
            lblSugerencia.TabIndex = 1;
            lblSugerencia.Text = "💡 Sugerencia semanal: $71.21";
            lblSugerencia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(248, 250, 252);
            pnlFooter.Controls.Add(btnCancelar);
            pnlFooter.Controls.Add(btnConfirmarTransferencia);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 399);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(430, 76);
            pnlFooter.TabIndex = 9;
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
            btnCancelar.Location = new Point(100, 22);
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
            btnCancelar.Size = new Size(150, 42);
            btnCancelar.TabIndex = 21;
            btnCancelar.TextAlignment = StringAlignment.Center;
            btnCancelar.TextPadding = 12;
            btnCancelar.TextSpacing = 2;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmarTransferencia
            // 
            btnConfirmarTransferencia.BackColor = Color.Transparent;
            btnConfirmarTransferencia.CheckButton = false;
            btnConfirmarTransferencia.Checked = false;
            btnConfirmarTransferencia.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnConfirmarTransferencia.CheckedForeColor = Color.White;
            btnConfirmarTransferencia.CheckedImageTint = Color.White;
            btnConfirmarTransferencia.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnConfirmarTransferencia.Content = "Confirmar ";
            btnConfirmarTransferencia.DialogResult = DialogResult.None;
            btnConfirmarTransferencia.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnConfirmarTransferencia.ForeColor = Color.White;
            btnConfirmarTransferencia.HoverBackground = Color.White;
            btnConfirmarTransferencia.HoverForeColor = Color.DimGray;
            btnConfirmarTransferencia.HoverImageTint = Color.DimGray;
            btnConfirmarTransferencia.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnConfirmarTransferencia.Image = null;
            btnConfirmarTransferencia.ImageExpand = new Point(0, 0);
            btnConfirmarTransferencia.Location = new Point(256, 22);
            btnConfirmarTransferencia.Name = "btnConfirmarTransferencia";
            btnConfirmarTransferencia.NormalBackground = SystemColors.Highlight;
            btnConfirmarTransferencia.NormalForeColor = Color.White;
            btnConfirmarTransferencia.NormalImageTint = Color.White;
            btnConfirmarTransferencia.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnConfirmarTransferencia.OutlineThickness = 1F;
            btnConfirmarTransferencia.Padding = new Padding(12);
            btnConfirmarTransferencia.PressedBackground = Color.WhiteSmoke;
            btnConfirmarTransferencia.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnConfirmarTransferencia.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnConfirmarTransferencia.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnConfirmarTransferencia.Rounding = new Padding(8);
            btnConfirmarTransferencia.Size = new Size(150, 42);
            btnConfirmarTransferencia.TabIndex = 20;
            btnConfirmarTransferencia.TextAlignment = StringAlignment.Center;
            btnConfirmarTransferencia.TextPadding = 12;
            btnConfirmarTransferencia.TextSpacing = 2;
            btnConfirmarTransferencia.Click += btnConfirmarTransferencia_Click;
            // 
            // pnlLineaFooter
            // 
            pnlLineaFooter.BackColor = Color.FromArgb(226, 232, 240);
            pnlLineaFooter.Dock = DockStyle.Bottom;
            pnlLineaFooter.Location = new Point(0, 398);
            pnlLineaFooter.Name = "pnlLineaFooter";
            pnlLineaFooter.Size = new Size(430, 1);
            pnlLineaFooter.TabIndex = 8;
            // 
            // cmbCuentaOrigen
            // 
            cmbCuentaOrigen.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCuentaOrigen.ForeColor = Color.DimGray;
            cmbCuentaOrigen.FormattingEnabled = true;
            cmbCuentaOrigen.ItemHeight = 20;
            cmbCuentaOrigen.Location = new Point(32, 153);
            cmbCuentaOrigen.Name = "cmbCuentaOrigen";
            cmbCuentaOrigen.Size = new Size(374, 28);
            cmbCuentaOrigen.TabIndex = 10;
            cmbCuentaOrigen.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // FrmAbonarMetaAhorro
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(430, 475);
            Controls.Add(cmbCuentaOrigen);
            Controls.Add(pnlSugerencia);
            Controls.Add(pnlMontoWrapper);
            Controls.Add(lblMontoTitulo);
            Controls.Add(lblSaldoCuenta);
            Controls.Add(lblCuentaTitulo);
            Controls.Add(pnlLineaHeader);
            Controls.Add(pnlHeader);
            Controls.Add(pnlLineaFooter);
            Controls.Add(pnlFooter);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAbonarMetaAhorro";
            StartPosition = FormStartPosition.CenterParent;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            cuiPanel1.ResumeLayout(false);
            pnlMontoWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudMontoAbono).EndInit();
            pnlSugerencia.ResumeLayout(false);
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private ComboBox cmbCuentaOrigen;
        private CuoreUI.Controls.cuiButton btnCancelar;
        private CuoreUI.Controls.cuiButton btnConfirmarTransferencia;
    }
}