namespace ControlFinanzas.UI.Formularios
{
    partial class FrmAsignarGastoPresupuesto
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
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            label1 = new Label();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            btnCancelar = new CuoreUI.Controls.cuiButton();
            btnConfirmarTransferencia = new CuoreUI.Controls.cuiButton();
            nudDineroATransferir = new NumericUpDown();
            label5 = new Label();
            cmbCategoriaGasto = new CuoreUI.Controls.cuiComboBox();
            label2 = new Label();
            cmbCuentaOrigen = new CuoreUI.Controls.cuiComboBox();
            label4 = new Label();
            cuiPanel1.SuspendLayout();
            cuiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDineroATransferir).BeginInit();
            SuspendLayout();
            // 
            // cuiPanel1
            // 
            cuiPanel1.BackColor = Color.Transparent;
            cuiPanel1.Controls.Add(label1);
            cuiPanel1.Location = new Point(5, 7);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.Black;
            cuiPanel1.Rounding = new Padding(12);
            cuiPanel1.Size = new Size(389, 55);
            cuiPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 11);
            label1.Name = "label1";
            label1.Size = new Size(319, 30);
            label1.TabIndex = 3;
            label1.Text = "Asignar Fondos a Presupuestos";
            // 
            // cuiPanel2
            // 
            cuiPanel2.BackColor = Color.Transparent;
            cuiPanel2.Controls.Add(btnCancelar);
            cuiPanel2.Controls.Add(btnConfirmarTransferencia);
            cuiPanel2.Controls.Add(nudDineroATransferir);
            cuiPanel2.Controls.Add(label5);
            cuiPanel2.Controls.Add(cmbCategoriaGasto);
            cuiPanel2.Controls.Add(label2);
            cuiPanel2.Controls.Add(cmbCuentaOrigen);
            cuiPanel2.Controls.Add(label4);
            cuiPanel2.Location = new Point(5, 74);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.White;
            cuiPanel2.PanelOutlineColor = Color.Black;
            cuiPanel2.Rounding = new Padding(12);
            cuiPanel2.Size = new Size(389, 340);
            cuiPanel2.TabIndex = 1;
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
            btnCancelar.Location = new Point(76, 279);
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
            btnCancelar.TabIndex = 19;
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
            btnConfirmarTransferencia.Location = new Point(232, 279);
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
            btnConfirmarTransferencia.TabIndex = 18;
            btnConfirmarTransferencia.TextAlignment = StringAlignment.Center;
            btnConfirmarTransferencia.TextPadding = 12;
            btnConfirmarTransferencia.TextSpacing = 2;
            btnConfirmarTransferencia.Click += btnConfirmarTransferencia_Click;
            // 
            // nudDineroATransferir
            // 
            nudDineroATransferir.BorderStyle = BorderStyle.FixedSingle;
            nudDineroATransferir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudDineroATransferir.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            nudDineroATransferir.Location = new Point(7, 222);
            nudDineroATransferir.Name = "nudDineroATransferir";
            nudDineroATransferir.Size = new Size(244, 29);
            nudDineroATransferir.TabIndex = 17;
            nudDineroATransferir.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(5, 190);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 16;
            label5.Text = "Monto A Gastar";
            // 
            // cmbCategoriaGasto
            // 
            cmbCategoriaGasto.BackColor = Color.Transparent;
            cmbCategoriaGasto.BackgroundColor = Color.FromArgb(255, 255, 255);
            cmbCategoriaGasto.DropDownBackgroundColor = Color.White;
            cmbCategoriaGasto.DropDownForeColor = Color.FromArgb(27, 27, 27);
            cmbCategoriaGasto.ExpandArrowColor = Color.DimGray;
            cmbCategoriaGasto.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCategoriaGasto.ForeColor = Color.DimGray;
            cmbCategoriaGasto.Items = new string[]
    {
    "Efectivo",
    "Debito",
    "Credito"
    };
            cmbCategoriaGasto.Location = new Point(4, 136);
            cmbCategoriaGasto.Margin = new Padding(5, 4, 5, 4);
            cmbCategoriaGasto.MaxDropDownHeight = 240;
            cmbCategoriaGasto.Name = "cmbCategoriaGasto";
            cmbCategoriaGasto.NoSelectionText = "None";
            cmbCategoriaGasto.OutlineColor = Color.FromArgb(64, 64, 64);
            cmbCategoriaGasto.OutlineThickness = 1F;
            cmbCategoriaGasto.Rounding = 8;
            cmbCategoriaGasto.SelectedIndex = 0;
            cmbCategoriaGasto.SelectedItem = "Efectivo";
            cmbCategoriaGasto.Size = new Size(378, 36);
            cmbCategoriaGasto.SortAlphabetically = false;
            cmbCategoriaGasto.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(7, 112);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 11;
            label2.Text = "Categoria de Gasto";
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
    "Efectivo",
    "Debito",
    "Credito"
    };
            cmbCuentaOrigen.Location = new Point(4, 48);
            cmbCuentaOrigen.Margin = new Padding(5, 4, 5, 4);
            cmbCuentaOrigen.MaxDropDownHeight = 240;
            cmbCuentaOrigen.Name = "cmbCuentaOrigen";
            cmbCuentaOrigen.NoSelectionText = "None";
            cmbCuentaOrigen.OutlineColor = Color.FromArgb(64, 64, 64);
            cmbCuentaOrigen.OutlineThickness = 1F;
            cmbCuentaOrigen.Rounding = 8;
            cmbCuentaOrigen.SelectedIndex = 0;
            cmbCuentaOrigen.SelectedItem = "Efectivo";
            cmbCuentaOrigen.Size = new Size(378, 36);
            cmbCuentaOrigen.SortAlphabetically = false;
            cmbCuentaOrigen.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(7, 24);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 9;
            label4.Text = "Cuenta de Origen";
            // 
            // FrmAsignarGastoPresupuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(401, 426);
            Controls.Add(cuiPanel2);
            Controls.Add(cuiPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAsignarGastoPresupuesto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmAsignarGastoPresupuesto";
            Load += FrmAsignarGastoPresupuesto_Load;
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            cuiPanel2.ResumeLayout(false);
            cuiPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDineroATransferir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private Label label1;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiComboBox cmbCategoriaGasto;
        private Label label2;
        private CuoreUI.Controls.cuiComboBox cmbCuentaOrigen;
        private Label label4;
        private NumericUpDown nudDineroATransferir;
        private Label label5;
        private CuoreUI.Controls.cuiButton btnCancelar;
        private CuoreUI.Controls.cuiButton btnConfirmarTransferencia;
    }
}