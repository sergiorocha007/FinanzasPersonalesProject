namespace ControlFinanzas.UI.Controles
{
    partial class ucTrajetaAhorro
    {


        
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblObjetivo;
        private System.Windows.Forms.Panel pnlBarraProgreso;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lblFechaLimite;
        private System.Windows.Forms.Label lblDiasRestantes;
        private System.Windows.Forms.Panel pnlSugerencia;
        private System.Windows.Forms.Label lblSugerencia;
        private System.Windows.Forms.Button btnAbonar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>

        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblEstado = new Label();
            lblMonto = new Label();
            lblObjetivo = new Label();
            pnlBarraProgreso = new Panel();
            pnlProgreso = new Panel();
            lblPorcentaje = new Label();
            lblFechaLimite = new Label();
            lblDiasRestantes = new Label();
            pnlSugerencia = new Panel();
            lblSugerencia = new Label();
            btnAbonar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            pnlBarraProgreso.SuspendLayout();
            pnlSugerencia.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(15, 23, 42);
            lblNombre.Location = new Point(9, 20);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(126, 21);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Viaje a la Playa";
            // 
            // lblEstado
            // 
            lblEstado.BackColor = Color.FromArgb(220, 252, 231);
            lblEstado.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblEstado.ForeColor = Color.FromArgb(21, 128, 61);
            lblEstado.Location = new Point(261, 19);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(68, 22);
            lblEstado.TabIndex = 10;
            lblEstado.Text = "Activa";
            lblEstado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 16.5F, FontStyle.Bold);
            lblMonto.ForeColor = Color.FromArgb(15, 23, 42);
            lblMonto.Location = new Point(7, 50);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(123, 30);
            lblMonto.TabIndex = 9;
            lblMonto.Text = "$10000.00";
            // 
            // lblObjetivo
            // 
            lblObjetivo.AutoSize = true;
            lblObjetivo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObjetivo.ForeColor = Color.FromArgb(100, 116, 139);
            lblObjetivo.Location = new Point(134, 59);
            lblObjetivo.Name = "lblObjetivo";
            lblObjetivo.Size = new Size(82, 20);
            lblObjetivo.TabIndex = 8;
            lblObjetivo.Text = "de $800.00";
            // 
            // pnlBarraProgreso
            // 
            pnlBarraProgreso.Controls.Add(pnlProgreso);
            pnlBarraProgreso.Location = new Point(9, 92);
            pnlBarraProgreso.Name = "pnlBarraProgreso";
            pnlBarraProgreso.Size = new Size(272, 10);
            pnlBarraProgreso.TabIndex = 7;
            // 
            // pnlProgreso
            // 
            pnlProgreso.BackColor = Color.FromArgb(239, 152, 39);
            pnlProgreso.Dock = DockStyle.Left;
            pnlProgreso.Location = new Point(0, 0);
            pnlProgreso.Name = "pnlProgreso";
            pnlProgreso.Size = new Size(237, 10);
            pnlProgreso.TabIndex = 1;
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPorcentaje.ForeColor = Color.FromArgb(15, 23, 42);
            lblPorcentaje.Location = new Point(285, 87);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(44, 19);
            lblPorcentaje.TabIndex = 6;
            lblPorcentaje.Text = "75%";
            lblPorcentaje.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFechaLimite
            // 
            lblFechaLimite.AutoSize = true;
            lblFechaLimite.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaLimite.ForeColor = Color.FromArgb(100, 116, 139);
            lblFechaLimite.Location = new Point(9, 118);
            lblFechaLimite.Name = "lblFechaLimite";
            lblFechaLimite.Size = new Size(97, 17);
            lblFechaLimite.TabIndex = 5;
            lblFechaLimite.Text = "📅 15 dic 2026";
            // 
            // lblDiasRestantes
            // 
            lblDiasRestantes.BackColor = Color.FromArgb(241, 245, 249);
            lblDiasRestantes.Font = new Font("Segoe UI", 8.5F);
            lblDiasRestantes.ForeColor = Color.FromArgb(71, 85, 105);
            lblDiasRestantes.Location = new Point(231, 115);
            lblDiasRestantes.Name = "lblDiasRestantes";
            lblDiasRestantes.Size = new Size(98, 22);
            lblDiasRestantes.TabIndex = 4;
            lblDiasRestantes.Text = "Faltan 34 días";
            lblDiasRestantes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSugerencia
            // 
            pnlSugerencia.BackColor = Color.FromArgb(241, 245, 249);
            pnlSugerencia.Controls.Add(lblSugerencia);
            pnlSugerencia.Location = new Point(9, 148);
            pnlSugerencia.Name = "pnlSugerencia";
            pnlSugerencia.Size = new Size(320, 38);
            pnlSugerencia.TabIndex = 3;
            // 
            // lblSugerencia
            // 
            lblSugerencia.Dock = DockStyle.Fill;
            lblSugerencia.Font = new Font("Segoe UI", 8.8F);
            lblSugerencia.ForeColor = Color.FromArgb(30, 41, 59);
            lblSugerencia.Location = new Point(0, 0);
            lblSugerencia.Name = "lblSugerencia";
            lblSugerencia.Padding = new Padding(10, 0, 10, 0);
            lblSugerencia.Size = new Size(320, 38);
            lblSugerencia.TabIndex = 0;
            lblSugerencia.Text = "💡 Ahorra $41.18 por semana para llegar a tiempo";
            lblSugerencia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAbonar
            // 
            btnAbonar.BackColor = Color.FromArgb(37, 99, 235);
            btnAbonar.Cursor = Cursors.Hand;
            btnAbonar.FlatAppearance.BorderSize = 0;
            btnAbonar.FlatStyle = FlatStyle.Flat;
            btnAbonar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnAbonar.ForeColor = Color.White;
            btnAbonar.Location = new Point(9, 200);
            btnAbonar.Name = "btnAbonar";
            btnAbonar.Size = new Size(178, 36);
            btnAbonar.TabIndex = 2;
            btnAbonar.Text = "+ Abonar";
            btnAbonar.UseVisualStyleBackColor = false;
            btnAbonar.Click += btnAbonar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnEditar.ForeColor = Color.FromArgb(51, 65, 85);
            btnEditar.Location = new Point(193, 200);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(92, 36);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "✏️ Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.ForeColor = Color.FromArgb(239, 68, 68);
            btnCancelar.Location = new Point(293, 200);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(36, 36);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "🚫";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // ucTrajetaAhorro
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnAbonar);
            Controls.Add(pnlSugerencia);
            Controls.Add(lblDiasRestantes);
            Controls.Add(lblFechaLimite);
            Controls.Add(lblPorcentaje);
            Controls.Add(pnlBarraProgreso);
            Controls.Add(lblObjetivo);
            Controls.Add(lblMonto);
            Controls.Add(lblEstado);
            Controls.Add(lblNombre);
            Margin = new Padding(10);
            Name = "ucTrajetaAhorro";
            Size = new Size(344, 256);
            pnlBarraProgreso.ResumeLayout(false);
            pnlSugerencia.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel pnlProgreso;
    }      
}

