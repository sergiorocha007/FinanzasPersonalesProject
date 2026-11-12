namespace ControlFinanzas.UI.Formularios
{
    partial class FrmPresupuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPresupuestos));
            label2 = new Label();
            label1 = new Label();
            cuiPanel5 = new CuoreUI.Controls.cuiPanel();
            comboBoxAnios = new CuoreUI.Controls.cuiComboBox();
            numericUpDown2 = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            cuiButton4 = new CuoreUI.Controls.cuiButton();
            cuiButton3 = new CuoreUI.Controls.cuiButton();
            cuiComboBox2 = new CuoreUI.Controls.cuiComboBox();
            label4 = new Label();
            label3 = new Label();
            flpTarjetas = new FlowLayoutPanel();
            cuiPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            label2.Size = new Size(538, 20);
            label2.TabIndex = 3;
            label2.Text = "Establece topes de gasto por categoría y monitorea tu consumo en tiempo real.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 25);
            label1.Name = "label1";
            label1.Size = new Size(254, 30);
            label1.TabIndex = 2;
            label1.Text = "Gestion de Presupuestos";
            // 
            // cuiPanel5
            // 
            cuiPanel5.Controls.Add(comboBoxAnios);
            cuiPanel5.Controls.Add(numericUpDown2);
            cuiPanel5.Controls.Add(label7);
            cuiPanel5.Controls.Add(label6);
            cuiPanel5.Controls.Add(numericUpDown1);
            cuiPanel5.Controls.Add(label5);
            cuiPanel5.Controls.Add(cuiButton4);
            cuiPanel5.Controls.Add(cuiButton3);
            cuiPanel5.Controls.Add(cuiComboBox2);
            cuiPanel5.Controls.Add(label4);
            cuiPanel5.Controls.Add(label3);
            cuiPanel5.Location = new Point(18, 107);
            cuiPanel5.Name = "cuiPanel5";
            cuiPanel5.OutlineThickness = 1F;
            cuiPanel5.PanelColor = Color.White;
            cuiPanel5.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel5.Rounding = new Padding(15);
            cuiPanel5.Size = new Size(464, 402);
            cuiPanel5.TabIndex = 5;
            // 
            // comboBoxAnios
            // 
            comboBoxAnios.BackColor = Color.Transparent;
            comboBoxAnios.BackgroundColor = Color.FromArgb(255, 255, 255);
            comboBoxAnios.DropDownBackgroundColor = Color.White;
            comboBoxAnios.DropDownForeColor = Color.FromArgb(27, 27, 27);
            comboBoxAnios.ExpandArrowColor = Color.DimGray;
            comboBoxAnios.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxAnios.ForeColor = Color.Gray;
            comboBoxAnios.Items = new string[]
    {
    "2026"
    };
            comboBoxAnios.Location = new Point(279, 243);
            comboBoxAnios.Margin = new Padding(5, 4, 5, 4);
            comboBoxAnios.MaxDropDownHeight = 240;
            comboBoxAnios.Name = "comboBoxAnios";
            comboBoxAnios.NoSelectionText = "None";
            comboBoxAnios.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            comboBoxAnios.OutlineThickness = 1F;
            comboBoxAnios.Rounding = 8;
            comboBoxAnios.SelectedIndex = 0;
            comboBoxAnios.SelectedItem = "2026";
            comboBoxAnios.Size = new Size(165, 29);
            comboBoxAnios.SortAlphabetically = false;
            comboBoxAnios.TabIndex = 19;
            // 
            // numericUpDown2
            // 
            numericUpDown2.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown2.Location = new Point(17, 243);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(121, 29);
            numericUpDown2.TabIndex = 18;
            numericUpDown2.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(279, 220);
            label7.Name = "label7";
            label7.Size = new Size(38, 20);
            label7.TabIndex = 17;
            label7.Text = "Año";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(17, 220);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 16;
            label6.Text = "Mes";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown1.Location = new Point(17, 168);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(427, 29);
            numericUpDown1.TabIndex = 15;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(12, 145);
            label5.Name = "label5";
            label5.Size = new Size(189, 20);
            label5.TabIndex = 14;
            label5.Text = "Dinero Mensual Asignado";
            // 
            // cuiButton4
            // 
            cuiButton4.CheckButton = false;
            cuiButton4.Checked = false;
            cuiButton4.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton4.CheckedForeColor = Color.White;
            cuiButton4.CheckedImageTint = Color.White;
            cuiButton4.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton4.Content = "Asignar Fondo/Abonar";
            cuiButton4.DialogResult = DialogResult.None;
            cuiButton4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            cuiButton4.ForeColor = Color.Black;
            cuiButton4.HoverBackground = Color.Transparent;
            cuiButton4.HoverForeColor = Color.DimGray;
            cuiButton4.HoverImageTint = Color.DimGray;
            cuiButton4.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton4.Image = (Image)resources.GetObject("cuiButton4.Image");
            cuiButton4.ImageExpand = new Point(0, 0);
            cuiButton4.Location = new Point(64, 336);
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
            cuiButton4.Size = new Size(328, 42);
            cuiButton4.TabIndex = 13;
            cuiButton4.TextAlignment = StringAlignment.Center;
            cuiButton4.TextPadding = 12;
            cuiButton4.TextSpacing = 2;
            cuiButton4.Click += cuiButton4_Click;
            // 
            // cuiButton3
            // 
            cuiButton3.CheckButton = false;
            cuiButton3.Checked = false;
            cuiButton3.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton3.CheckedForeColor = Color.White;
            cuiButton3.CheckedImageTint = Color.White;
            cuiButton3.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton3.Content = "Guardar Presupuesto";
            cuiButton3.DialogResult = DialogResult.None;
            cuiButton3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            cuiButton3.ForeColor = Color.White;
            cuiButton3.HoverBackground = Color.White;
            cuiButton3.HoverForeColor = Color.DimGray;
            cuiButton3.HoverImageTint = Color.DimGray;
            cuiButton3.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton3.Image = (Image)resources.GetObject("cuiButton3.Image");
            cuiButton3.ImageExpand = new Point(0, 0);
            cuiButton3.Location = new Point(64, 279);
            cuiButton3.Name = "cuiButton3";
            cuiButton3.NormalBackground = SystemColors.Highlight;
            cuiButton3.NormalForeColor = Color.White;
            cuiButton3.NormalImageTint = Color.White;
            cuiButton3.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton3.OutlineThickness = 1F;
            cuiButton3.Padding = new Padding(12);
            cuiButton3.PressedBackground = Color.WhiteSmoke;
            cuiButton3.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton3.PressedImageTint = Color.FromArgb(32, 32, 32);
            cuiButton3.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton3.Rounding = new Padding(8);
            cuiButton3.Size = new Size(328, 42);
            cuiButton3.TabIndex = 12;
            cuiButton3.TextAlignment = StringAlignment.Center;
            cuiButton3.TextPadding = 12;
            cuiButton3.TextSpacing = 2;
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
            cuiComboBox2.Location = new Point(12, 85);
            cuiComboBox2.Margin = new Padding(5, 4, 5, 4);
            cuiComboBox2.MaxDropDownHeight = 240;
            cuiComboBox2.Name = "cuiComboBox2";
            cuiComboBox2.NoSelectionText = "None";
            cuiComboBox2.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiComboBox2.OutlineThickness = 1F;
            cuiComboBox2.Rounding = 8;
            cuiComboBox2.SelectedIndex = 0;
            cuiComboBox2.SelectedItem = "Efectivo";
            cuiComboBox2.Size = new Size(432, 36);
            cuiComboBox2.SortAlphabetically = false;
            cuiComboBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(12, 61);
            label4.Name = "label4";
            label4.Size = new Size(142, 20);
            label4.TabIndex = 3;
            label4.Text = "Categoria de Gasto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(190, 21);
            label3.TabIndex = 1;
            label3.Text = "Configurar Presupuesto";
            // 
            // flpTarjetas
            // 
            flpTarjetas.BackColor = Color.White;
            flpTarjetas.Location = new Point(499, 107);
            flpTarjetas.Name = "flpTarjetas";
            flpTarjetas.Size = new Size(660, 597);
            flpTarjetas.TabIndex = 6;
            // 
            // FrmPresupuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1171, 716);
            Controls.Add(flpTarjetas);
            Controls.Add(cuiPanel5);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPresupuestos";
            Text = "FrmPresupuestos";
            cuiPanel5.ResumeLayout(false);
            cuiPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private CuoreUI.Controls.cuiPanel cuiPanel5;
        private CuoreUI.Controls.cuiButton cuiButton4;
        private CuoreUI.Controls.cuiButton cuiButton3;
        private Label label4;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private CuoreUI.Controls.cuiComboBox cuiComboBox2;
        private FlowLayoutPanel flpTarjetas;
        private NumericUpDown numericUpDown2;
        private Label label7;
        private Label label6;
        private CuoreUI.Controls.cuiComboBox comboBoxAnios;
    }
}