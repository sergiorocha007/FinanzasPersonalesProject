namespace ControlFinanzas.UI.Formularios
{
    partial class FrmConfiguracionConexion1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracionConexion1));
            lblTitulo = new Label();
            lblServidor = new Label();
            txtServidor = new CuoreUI.Controls.cuiTextBox();
            lblBaseDatos = new Label();
            txtBaseDatos = new CuoreUI.Controls.cuiTextBox();
            lblUsuario = new Label();
            txtUsuario = new CuoreUI.Controls.cuiTextBox();
            lblContrasena = new Label();
            txtContrasena = new CuoreUI.Controls.cuiTextBox();
            btnCancelar = new CuoreUI.Controls.cuiButton();
            btnGuardar = new CuoreUI.Controls.cuiButton();
            btnProbarConexion = new CuoreUI.Controls.cuiButton();
            pnlContenedor = new CuoreUI.Controls.cuiPanel();
            label1 = new Label();
            errorIcon = new ErrorProvider(components);
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorIcon).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitulo.Image = (Image)resources.GetObject("lblTitulo.Image");
            lblTitulo.ImageAlign = ContentAlignment.MiddleLeft;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(419, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "   configuracion de la Base de Datos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblServidor
            // 
            lblServidor.AutoSize = true;
            lblServidor.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblServidor.Location = new Point(13, 20);
            lblServidor.Margin = new Padding(4, 0, 4, 0);
            lblServidor.Name = "lblServidor";
            lblServidor.Size = new Size(68, 20);
            lblServidor.TabIndex = 1;
            lblServidor.Text = "Servidor";
            // 
            // txtServidor
            // 
            txtServidor.BackColor = Color.Transparent;
            txtServidor.BackgroundColor = Color.White;
            txtServidor.Content = "";
            txtServidor.FocusBackgroundColor = Color.White;
            txtServidor.FocusImageTint = Color.White;
            txtServidor.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txtServidor.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtServidor.ForeColor = Color.DimGray;
            txtServidor.Image = null;
            txtServidor.ImageExpand = new Point(0, 0);
            txtServidor.ImageOffset = new Point(0, 0);
            txtServidor.Location = new Point(123, 13);
            txtServidor.Margin = new Padding(4, 3, 4, 3);
            txtServidor.Multiline = false;
            txtServidor.Name = "txtServidor";
            txtServidor.NormalImageTint = Color.White;
            txtServidor.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtServidor.Padding = new Padding(20, 6, 20, 0);
            txtServidor.PasswordChar = false;
            txtServidor.PlaceholderColor = Color.LightGray;
            txtServidor.PlaceholderText = "Ej: localhost ó .\\SQLEXPRESS";
            txtServidor.Rounding = new Padding(8);
            txtServidor.Size = new Size(247, 32);
            txtServidor.TabIndex = 2;
            txtServidor.TextOffset = new Size(0, 0);
            txtServidor.UnderlinedStyle = true;
            // 
            // lblBaseDatos
            // 
            lblBaseDatos.AutoSize = true;
            lblBaseDatos.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblBaseDatos.Location = new Point(13, 66);
            lblBaseDatos.Margin = new Padding(4, 0, 4, 0);
            lblBaseDatos.Name = "lblBaseDatos";
            lblBaseDatos.Size = new Size(104, 20);
            lblBaseDatos.TabIndex = 3;
            lblBaseDatos.Text = "Base de Datos";
            // 
            // txtBaseDatos
            // 
            txtBaseDatos.BackgroundColor = Color.White;
            txtBaseDatos.Content = "";
            txtBaseDatos.FocusBackgroundColor = Color.White;
            txtBaseDatos.FocusImageTint = Color.White;
            txtBaseDatos.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txtBaseDatos.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtBaseDatos.ForeColor = Color.DimGray;
            txtBaseDatos.Image = null;
            txtBaseDatos.ImageExpand = new Point(0, 0);
            txtBaseDatos.ImageOffset = new Point(0, 0);
            txtBaseDatos.Location = new Point(123, 58);
            txtBaseDatos.Margin = new Padding(4, 3, 4, 3);
            txtBaseDatos.Multiline = false;
            txtBaseDatos.Name = "txtBaseDatos";
            txtBaseDatos.NormalImageTint = Color.White;
            txtBaseDatos.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtBaseDatos.Padding = new Padding(20, 6, 20, 0);
            txtBaseDatos.PasswordChar = false;
            txtBaseDatos.PlaceholderColor = Color.LightGray;
            txtBaseDatos.PlaceholderText = "Ej: ControlFinanzasDB";
            txtBaseDatos.Rounding = new Padding(8);
            txtBaseDatos.Size = new Size(247, 32);
            txtBaseDatos.TabIndex = 4;
            txtBaseDatos.TextOffset = new Size(0, 0);
            txtBaseDatos.UnderlinedStyle = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblUsuario.Location = new Point(13, 113);
            lblUsuario.Margin = new Padding(4, 0, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.BackgroundColor = Color.White;
            txtUsuario.Content = "";
            txtUsuario.FocusBackgroundColor = Color.White;
            txtUsuario.FocusImageTint = Color.White;
            txtUsuario.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txtUsuario.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Image = null;
            txtUsuario.ImageExpand = new Point(0, 0);
            txtUsuario.ImageOffset = new Point(0, 0);
            txtUsuario.Location = new Point(123, 105);
            txtUsuario.Margin = new Padding(4, 3, 4, 3);
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.NormalImageTint = Color.White;
            txtUsuario.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtUsuario.Padding = new Padding(20, 6, 20, 0);
            txtUsuario.PasswordChar = false;
            txtUsuario.PlaceholderColor = Color.LightGray;
            txtUsuario.PlaceholderText = "Ej: sa";
            txtUsuario.Rounding = new Padding(8);
            txtUsuario.Size = new Size(247, 32);
            txtUsuario.TabIndex = 6;
            txtUsuario.TextOffset = new Size(0, 0);
            txtUsuario.UnderlinedStyle = true;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblContrasena.Location = new Point(13, 161);
            lblContrasena.Margin = new Padding(4, 0, 4, 0);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(86, 20);
            lblContrasena.TabIndex = 7;
            lblContrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.BackgroundColor = Color.White;
            txtContrasena.Content = "";
            txtContrasena.FocusBackgroundColor = Color.White;
            txtContrasena.FocusImageTint = Color.White;
            txtContrasena.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txtContrasena.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtContrasena.ForeColor = Color.DimGray;
            txtContrasena.Image = null;
            txtContrasena.ImageExpand = new Point(0, 0);
            txtContrasena.ImageOffset = new Point(0, 0);
            txtContrasena.Location = new Point(123, 154);
            txtContrasena.Margin = new Padding(4, 3, 4, 3);
            txtContrasena.Multiline = false;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.NormalImageTint = Color.White;
            txtContrasena.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtContrasena.Padding = new Padding(20, 6, 20, 0);
            txtContrasena.PasswordChar = true;
            txtContrasena.PlaceholderColor = Color.LightGray;
            txtContrasena.PlaceholderText = "Ingrese la contraseña";
            txtContrasena.Rounding = new Padding(8);
            txtContrasena.Size = new Size(247, 32);
            txtContrasena.TabIndex = 8;
            txtContrasena.TextOffset = new Size(0, 0);
            txtContrasena.UnderlinedStyle = true;
            // 
            // btnCancelar
            // 
            btnCancelar.CheckButton = false;
            btnCancelar.Checked = false;
            btnCancelar.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnCancelar.CheckedForeColor = Color.White;
            btnCancelar.CheckedImageTint = Color.White;
            btnCancelar.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnCancelar.Content = "cancelar";
            btnCancelar.DialogResult = DialogResult.None;
            btnCancelar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.HoverBackground = Color.FromArgb(215, 67, 67);
            btnCancelar.HoverForeColor = Color.DimGray;
            btnCancelar.HoverImageTint = Color.DimGray;
            btnCancelar.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnCancelar.Image = null;
            btnCancelar.ImageExpand = new Point(0, 0);
            btnCancelar.Location = new Point(3, 239);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NormalBackground = Color.FromArgb(235, 87, 87);
            btnCancelar.NormalForeColor = Color.White;
            btnCancelar.NormalImageTint = Color.Black;
            btnCancelar.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnCancelar.OutlineThickness = 1F;
            btnCancelar.Padding = new Padding(12);
            btnCancelar.PressedBackground = Color.FromArgb(195, 47, 47);
            btnCancelar.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnCancelar.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnCancelar.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnCancelar.Rounding = new Padding(8);
            btnCancelar.Size = new Size(112, 40);
            btnCancelar.TabIndex = 9;
            btnCancelar.TextAlignment = StringAlignment.Center;
            btnCancelar.TextPadding = 12;
            btnCancelar.TextSpacing = 2;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.CheckButton = false;
            btnGuardar.Checked = false;
            btnGuardar.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnGuardar.CheckedForeColor = Color.White;
            btnGuardar.CheckedImageTint = Color.White;
            btnGuardar.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnGuardar.Content = "guardar";
            btnGuardar.DialogResult = DialogResult.None;
            btnGuardar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.HoverBackground = Color.FromArgb(54, 104, 179);
            btnGuardar.HoverForeColor = Color.DimGray;
            btnGuardar.HoverImageTint = Color.DimGray;
            btnGuardar.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnGuardar.Image = null;
            btnGuardar.ImageExpand = new Point(0, 0);
            btnGuardar.Location = new Point(123, 239);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NormalBackground = Color.FromArgb(74, 124, 199);
            btnGuardar.NormalForeColor = Color.White;
            btnGuardar.NormalImageTint = Color.Black;
            btnGuardar.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnGuardar.OutlineThickness = 1F;
            btnGuardar.Padding = new Padding(12);
            btnGuardar.PressedBackground = Color.FromArgb(34, 84, 159);
            btnGuardar.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnGuardar.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnGuardar.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnGuardar.Rounding = new Padding(8);
            btnGuardar.Size = new Size(112, 40);
            btnGuardar.TabIndex = 10;
            btnGuardar.TextAlignment = StringAlignment.Center;
            btnGuardar.TextPadding = 12;
            btnGuardar.TextSpacing = 2;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.CheckButton = false;
            btnProbarConexion.Checked = false;
            btnProbarConexion.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnProbarConexion.CheckedForeColor = Color.White;
            btnProbarConexion.CheckedImageTint = Color.White;
            btnProbarConexion.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnProbarConexion.Content = "probar Conexion";
            btnProbarConexion.DialogResult = DialogResult.None;
            btnProbarConexion.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnProbarConexion.ForeColor = Color.White;
            btnProbarConexion.HoverBackground = Color.FromArgb(91, 145, 91);
            btnProbarConexion.HoverForeColor = Color.DimGray;
            btnProbarConexion.HoverImageTint = Color.DimGray;
            btnProbarConexion.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnProbarConexion.Image = null;
            btnProbarConexion.ImageExpand = new Point(0, 0);
            btnProbarConexion.Location = new Point(243, 239);
            btnProbarConexion.Margin = new Padding(4, 3, 4, 3);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.NormalBackground = Color.FromArgb(111, 165, 111);
            btnProbarConexion.NormalForeColor = Color.White;
            btnProbarConexion.NormalImageTint = Color.Black;
            btnProbarConexion.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnProbarConexion.OutlineThickness = 1F;
            btnProbarConexion.Padding = new Padding(12);
            btnProbarConexion.PressedBackground = Color.FromArgb(71, 125, 71);
            btnProbarConexion.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnProbarConexion.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnProbarConexion.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnProbarConexion.Rounding = new Padding(8);
            btnProbarConexion.Size = new Size(139, 40);
            btnProbarConexion.TabIndex = 11;
            btnProbarConexion.TextAlignment = StringAlignment.Center;
            btnProbarConexion.TextPadding = 12;
            btnProbarConexion.TextSpacing = 2;
            btnProbarConexion.Click += btnProbarConexion_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.Transparent;
            pnlContenedor.Controls.Add(btnProbarConexion);
            pnlContenedor.Controls.Add(lblServidor);
            pnlContenedor.Controls.Add(btnGuardar);
            pnlContenedor.Controls.Add(txtServidor);
            pnlContenedor.Controls.Add(btnCancelar);
            pnlContenedor.Controls.Add(lblBaseDatos);
            pnlContenedor.Controls.Add(txtContrasena);
            pnlContenedor.Controls.Add(txtBaseDatos);
            pnlContenedor.Controls.Add(lblContrasena);
            pnlContenedor.Controls.Add(lblUsuario);
            pnlContenedor.Controls.Add(txtUsuario);
            pnlContenedor.Location = new Point(13, 105);
            pnlContenedor.Margin = new Padding(4, 3, 4, 3);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.OutlineThickness = 1F;
            pnlContenedor.PanelColor = Color.White;
            pnlContenedor.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            pnlContenedor.Rounding = new Padding(8);
            pnlContenedor.Size = new Size(390, 307);
            pnlContenedor.TabIndex = 12;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(33, 37, 41);
            label1.Location = new Point(62, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(321, 43);
            label1.TabIndex = 13;
            label1.Text = "Ingrese la siguiente informacion para completar la conexion con la base datos!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorIcon
            // 
            errorIcon.ContainerControl = this;
            // 
            // FrmConfiguracionConexion1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(419, 436);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Controls.Add(pnlContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FrmConfiguracionConexion1";
            Opacity = 0.8D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuración";
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorIcon).EndInit();
            ResumeLayout(false);
        }

     

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblServidor;
        private CuoreUI.Controls.cuiTextBox txtServidor;
        private System.Windows.Forms.Label lblBaseDatos;
        private CuoreUI.Controls.cuiTextBox txtBaseDatos;
        private System.Windows.Forms.Label lblUsuario;
        private CuoreUI.Controls.cuiTextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private CuoreUI.Controls.cuiTextBox txtContrasena;
        private CuoreUI.Controls.cuiButton btnCancelar;
        private CuoreUI.Controls.cuiButton btnGuardar;
        private CuoreUI.Controls.cuiButton btnProbarConexion;
        private CuoreUI.Controls.cuiPanel pnlContenedor;


        #endregion

        private Label label1;
        private ErrorProvider errorIcon;
    }
}