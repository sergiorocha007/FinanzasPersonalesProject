namespace ControlFinanzas.UI.Formularios
{
    partial class FrmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistro));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            panel2 = new Panel();
            txtConfirmarContrasena = new CuoreUI.Controls.cuiTextBox();
            txtContrasena = new CuoreUI.Controls.cuiTextBox();
            label5 = new Label();
            label6 = new Label();
            btnIniciarSesion = new Button();
            label4 = new Label();
            btnRegistrarse = new HartUI.Controls.cuiButton();
            txtEmail = new CuoreUI.Controls.cuiTextBox();
            txtNombre = new CuoreUI.Controls.cuiTextBox();
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
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cuiLabel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 459);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 221);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 226);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(36, 137);
            label1.Name = "label1";
            label1.Size = new Size(320, 75);
            label1.TabIndex = 1;
            label1.Text = "Registrate ahora mismo\r\npara empezar a gestionar tu Dinero \r\nDe la mejor manera.";
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Control\\ de\\ Finanzas";
            cuiLabel1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel1.ForeColor = SystemColors.ActiveCaptionText;
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(36, 26);
            cuiLabel1.Margin = new Padding(4, 3, 4, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(220, 98);
            cuiLabel1.TabIndex = 0;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 33, 61);
            panel2.Controls.Add(txtConfirmarContrasena);
            panel2.Controls.Add(txtContrasena);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnIniciarSesion);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnRegistrarse);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cuiLabel2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(375, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(375, 459);
            panel2.TabIndex = 2;
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.BackColor = Color.Transparent;
            txtConfirmarContrasena.BackgroundColor = Color.Gainsboro;
            txtConfirmarContrasena.Content = "";
            txtConfirmarContrasena.FocusBackgroundColor = Color.White;
            txtConfirmarContrasena.FocusImageTint = Color.White;
            txtConfirmarContrasena.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txtConfirmarContrasena.Font = new Font("Segoe UI", 11.25F);
            txtConfirmarContrasena.ForeColor = Color.Gray;
            txtConfirmarContrasena.Image = null;
            txtConfirmarContrasena.ImageExpand = new Point(0, 0);
            txtConfirmarContrasena.ImageOffset = new Point(0, 0);
            txtConfirmarContrasena.Location = new Point(32, 324);
            txtConfirmarContrasena.Margin = new Padding(4);
            txtConfirmarContrasena.Multiline = false;
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.NormalImageTint = SystemColors.Window;
            txtConfirmarContrasena.OutlineColor = Color.Gray;
            txtConfirmarContrasena.Padding = new Padding(20, 9, 20, 0);
            txtConfirmarContrasena.PasswordChar = false;
            txtConfirmarContrasena.PlaceholderColor = Color.Gray;
            txtConfirmarContrasena.PlaceholderText = "Contraseña..";
            txtConfirmarContrasena.Rounding = new Padding(8);
            txtConfirmarContrasena.Size = new Size(302, 38);
            txtConfirmarContrasena.TabIndex = 16;
            txtConfirmarContrasena.TextOffset = new Size(0, 0);
            txtConfirmarContrasena.UnderlinedStyle = true;
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
            txtContrasena.Location = new Point(32, 246);
            txtContrasena.Margin = new Padding(4);
            txtContrasena.Multiline = false;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.NormalImageTint = SystemColors.Window;
            txtContrasena.OutlineColor = Color.Gray;
            txtContrasena.Padding = new Padding(20, 9, 20, 0);
            txtContrasena.PasswordChar = false;
            txtContrasena.PlaceholderColor = Color.Gray;
            txtContrasena.PlaceholderText = "Email..";
            txtContrasena.Rounding = new Padding(8);
            txtContrasena.Size = new Size(302, 38);
            txtContrasena.TabIndex = 15;
            txtContrasena.TextOffset = new Size(0, 0);
            txtContrasena.UnderlinedStyle = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(32, 299);
            label5.Name = "label5";
            label5.Size = new Size(169, 21);
            label5.TabIndex = 14;
            label5.Text = "Confirmar Contraseña";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(32, 221);
            label6.Name = "label6";
            label6.Size = new Size(92, 21);
            label6.TabIndex = 13;
            label6.Text = "Contraseña";
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.Location = new Point(204, 418);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(89, 23);
            btnIniciarSesion.TabIndex = 12;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(84, 422);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 11;
            label4.Text = "Ya tienes una cuenta?";
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.CheckButton = false;
            btnRegistrarse.Checked = false;
            btnRegistrarse.CheckedBackground = Color.FromArgb(61, 24, 226);
            btnRegistrarse.CheckedForeColor = Color.White;
            btnRegistrarse.CheckedImageTint = Color.White;
            btnRegistrarse.CheckedOutline = Color.FromArgb(61, 24, 226);
            btnRegistrarse.Content = "Registrarse";
            btnRegistrarse.DialogResult = DialogResult.None;
            btnRegistrarse.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarse.ForeColor = Color.White;
            btnRegistrarse.HoverBackground = Color.White;
            btnRegistrarse.HoverForeColor = Color.DimGray;
            btnRegistrarse.HoverImageTint = Color.DimGray;
            btnRegistrarse.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnRegistrarse.Image = null;
            btnRegistrarse.ImageExpand = new Point(0, 0);
            btnRegistrarse.Location = new Point(32, 381);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.NormalBackground = Color.RoyalBlue;
            btnRegistrarse.NormalForeColor = Color.White;
            btnRegistrarse.NormalImageTint = Color.Black;
            btnRegistrarse.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnRegistrarse.OutlineThickness = 1F;
            btnRegistrarse.Padding = new Padding(12);
            btnRegistrarse.PressedBackground = Color.WhiteSmoke;
            btnRegistrarse.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnRegistrarse.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnRegistrarse.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnRegistrarse.Rounding = new Padding(8);
            btnRegistrarse.Size = new Size(302, 33);
            btnRegistrarse.TabIndex = 10;
            btnRegistrarse.TextAlignment = StringAlignment.Center;
            btnRegistrarse.TextPadding = 12;
            btnRegistrarse.TextSpacing = 2;
            btnRegistrarse.Click += btnRegistrarse_Click;
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
            txtEmail.Location = new Point(32, 176);
            txtEmail.Margin = new Padding(4);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.NormalImageTint = SystemColors.Window;
            txtEmail.OutlineColor = Color.Gray;
            txtEmail.Padding = new Padding(20, 9, 20, 0);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceholderColor = Color.Gray;
            txtEmail.PlaceholderText = "Contraseña..";
            txtEmail.Rounding = new Padding(8);
            txtEmail.Size = new Size(302, 38);
            txtEmail.TabIndex = 7;
            txtEmail.TextOffset = new Size(0, 0);
            txtEmail.UnderlinedStyle = true;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Transparent;
            txtNombre.BackgroundColor = Color.Gainsboro;
            txtNombre.Content = "";
            txtNombre.FocusBackgroundColor = Color.White;
            txtNombre.FocusImageTint = Color.White;
            txtNombre.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txtNombre.Font = new Font("Segoe UI", 11.25F);
            txtNombre.ForeColor = Color.Gray;
            txtNombre.Image = null;
            txtNombre.ImageExpand = new Point(0, 0);
            txtNombre.ImageOffset = new Point(0, 0);
            txtNombre.Location = new Point(32, 98);
            txtNombre.Margin = new Padding(4);
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.NormalImageTint = SystemColors.Window;
            txtNombre.OutlineColor = Color.Gray;
            txtNombre.Padding = new Padding(20, 9, 20, 0);
            txtNombre.PasswordChar = false;
            txtNombre.PlaceholderColor = Color.Gray;
            txtNombre.PlaceholderText = "Email..";
            txtNombre.Rounding = new Padding(8);
            txtNombre.Size = new Size(302, 38);
            txtNombre.TabIndex = 6;
            txtNombre.TextOffset = new Size(0, 0);
            txtNombre.UnderlinedStyle = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(32, 151);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 73);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // cuiLabel2
            // 
            cuiLabel2.Content = "Bienvenido!";
            cuiLabel2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel2.ForeColor = Color.White;
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(17, 26);
            cuiLabel2.Margin = new Padding(4, 3, 4, 3);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(230, 65);
            cuiLabel2.TabIndex = 3;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 459);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRegistro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private Panel panel2;
        private Button btnIniciarSesion;
        private Label label4;
        private HartUI.Controls.cuiButton btnRegistrarse;
        private CuoreUI.Controls.cuiTextBox txtEmail;
        private CuoreUI.Controls.cuiTextBox txtNombre;
        private Label label3;
        private Label label2;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiTextBox txtConfirmarContrasena;
        private CuoreUI.Controls.cuiTextBox txtContrasena;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
    }
}