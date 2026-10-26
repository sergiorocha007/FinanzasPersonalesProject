namespace ControlFinanzas.UI.Formularios
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            panel2 = new Panel();
            btnRegristarse = new Button();
            label4 = new Label();
            cuiButton1 = new HartUI.Controls.cuiButton();
            button1 = new Button();
            cuiCheckbox1 = new CuoreUI.Controls.cuiCheckbox();
            txtContrasena = new CuoreUI.Controls.cuiTextBox();
            txtEmail = new CuoreUI.Controls.cuiTextBox();
            label3 = new Label();
            label2 = new Label();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 33, 61);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cuiLabel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 462);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(80, 235);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 215);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(148, 163, 184);
            label1.Location = new Point(38, 182);
            label1.Name = "label1";
            label1.Size = new Size(312, 50);
            label1.TabIndex = 1;
            label1.Text = "Gestiona tus ingresos, egresos \r\ny presupuestos de forma eficiente. ";
            // 
            // cuiLabel1
            // 
            cuiLabel1.Content = "Control\\ de\\ Finanzas";
            cuiLabel1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel1.ForeColor = Color.White;
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(38, 66);
            cuiLabel1.Margin = new Padding(4, 3, 4, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(220, 98);
            cuiLabel1.TabIndex = 0;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnRegristarse);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cuiButton1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(cuiCheckbox1);
            panel2.Controls.Add(txtContrasena);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cuiLabel2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(375, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(375, 462);
            panel2.TabIndex = 1;
            // 
            // btnRegristarse
            // 
            btnRegristarse.FlatAppearance.BorderSize = 0;
            btnRegristarse.FlatStyle = FlatStyle.Flat;
            btnRegristarse.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegristarse.Location = new Point(203, 382);
            btnRegristarse.Name = "btnRegristarse";
            btnRegristarse.Size = new Size(76, 23);
            btnRegristarse.TabIndex = 12;
            btnRegristarse.Text = "Registrate";
            btnRegristarse.TextAlign = ContentAlignment.MiddleLeft;
            btnRegristarse.UseVisualStyleBackColor = true;
            btnRegristarse.Click += btnRegristarse_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(83, 386);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 11;
            label4.Text = "No tienes una cuenta?";
            // 
            // cuiButton1
            // 
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(61, 24, 226);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(61, 24, 226);
            cuiButton1.Content = "Iniciar sesión";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiButton1.ForeColor = Color.White;
            cuiButton1.HoverBackground = Color.White;
            cuiButton1.HoverForeColor = Color.DimGray;
            cuiButton1.HoverImageTint = Color.DimGray;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = null;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.Location = new Point(32, 347);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.RoyalBlue;
            cuiButton1.NormalForeColor = Color.White;
            cuiButton1.NormalImageTint = Color.Black;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.Padding = new Padding(12);
            cuiButton1.PressedBackground = Color.WhiteSmoke;
            cuiButton1.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedImageTint = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(302, 33);
            cuiButton1.TabIndex = 10;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextPadding = 12;
            cuiButton1.TextSpacing = 2;
            cuiButton1.Click += cuiButton1_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(186, 301);
            button1.Name = "button1";
            button1.Size = new Size(157, 27);
            button1.TabIndex = 9;
            button1.Text = "Olvidastes tu contraseña?";
            button1.UseVisualStyleBackColor = true;
            // 
            // cuiCheckbox1
            // 
            cuiCheckbox1.Checked = false;
            cuiCheckbox1.CheckedForeground = Color.FromArgb(255, 106, 0);
            cuiCheckbox1.CheckedOutlineColor = Color.FromArgb(255, 106, 0);
            cuiCheckbox1.CheckedSymbolColor = Color.White;
            cuiCheckbox1.Content = "Mostrar Contraseña";
            cuiCheckbox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiCheckbox1.ForeColor = Color.Black;
            cuiCheckbox1.Location = new Point(32, 305);
            cuiCheckbox1.MinimumSize = new Size(16, 16);
            cuiCheckbox1.Name = "cuiCheckbox1";
            cuiCheckbox1.OutlineThickness = 1F;
            cuiCheckbox1.Rounding = 4;
            cuiCheckbox1.ShowSymbols = true;
            cuiCheckbox1.Size = new Size(148, 17);
            cuiCheckbox1.TabIndex = 8;
            cuiCheckbox1.UncheckedForeground = Color.Empty;
            cuiCheckbox1.UncheckedOutlineColor = Color.Gray;
            cuiCheckbox1.UncheckedSymbolColor = Color.Empty;
            cuiCheckbox1.CheckedChanged += cuiCheckbox1_CheckedChanged;
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = Color.Transparent;
            txtContrasena.BackgroundColor = Color.Gainsboro;
            txtContrasena.Content = "";
            txtContrasena.FocusBackgroundColor = Color.White;
            txtContrasena.FocusImageTint = Color.White;
            txtContrasena.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txtContrasena.Font = new Font("Segoe UI", 11.25F);
            txtContrasena.ForeColor = Color.Gray;
            txtContrasena.Image = null;
            txtContrasena.ImageExpand = new Point(0, 0);
            txtContrasena.ImageOffset = new Point(0, 0);
            txtContrasena.Location = new Point(32, 260);
            txtContrasena.Margin = new Padding(4);
            txtContrasena.Multiline = false;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.NormalImageTint = SystemColors.Window;
            txtContrasena.OutlineColor = Color.Gray;
            txtContrasena.Padding = new Padding(20, 9, 20, 0);
            txtContrasena.PasswordChar = false;
            txtContrasena.PlaceholderColor = Color.Gray;
            txtContrasena.PlaceholderText = "Contraseña..";
            txtContrasena.Rounding = new Padding(8);
            txtContrasena.Size = new Size(302, 38);
            txtContrasena.TabIndex = 7;
            txtContrasena.TextOffset = new Size(0, 0);
            txtContrasena.UnderlinedStyle = true;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Transparent;
            txtEmail.BackgroundColor = Color.Gainsboro;
            txtEmail.Content = "";
            txtEmail.FocusBackgroundColor = Color.White;
            txtEmail.FocusImageTint = Color.White;
            txtEmail.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txtEmail.Font = new Font("Segoe UI", 11.25F);
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Image = null;
            txtEmail.ImageExpand = new Point(0, 0);
            txtEmail.ImageOffset = new Point(0, 0);
            txtEmail.Location = new Point(32, 182);
            txtEmail.Margin = new Padding(4);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.NormalImageTint = SystemColors.Window;
            txtEmail.OutlineColor = Color.Gray;
            txtEmail.Padding = new Padding(20, 9, 20, 0);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceholderColor = Color.Gray;
            txtEmail.PlaceholderText = "Email..";
            txtEmail.Rounding = new Padding(8);
            txtEmail.Size = new Size(302, 38);
            txtEmail.TabIndex = 6;
            txtEmail.TextOffset = new Size(0, 0);
            txtEmail.UnderlinedStyle = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(32, 235);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(32, 149);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // cuiLabel2
            // 
            cuiLabel2.Content = "Bienvenido!";
            cuiLabel2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel2.ForeColor = Color.Black;
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(7, 81);
            cuiLabel2.Margin = new Padding(4, 3, 4, 3);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(230, 65);
            cuiLabel2.TabIndex = 3;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 462);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);



        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private Label label1;
        private PictureBox pictureBox1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private Label label3;
        private Label label2;
        private CuoreUI.Controls.cuiTextBox txtContrasena;
        private CuoreUI.Controls.cuiTextBox txtEmail;
        private Button button1;
        private CuoreUI.Controls.cuiCheckbox cuiCheckbox1;
        private HartUI.Controls.cuiButton cuiButton1;
        private Button btnRegristarse;
        private Label label4;
    }
}