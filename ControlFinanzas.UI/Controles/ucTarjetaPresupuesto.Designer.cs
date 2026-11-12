namespace ControlFinanzas.UI.Controles
{
    partial class ucTarjetaPresupuesto
    {

        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblRestante;
        private System.Windows.Forms.Panel pnlFondoBarra;
        private System.Windows.Forms.Panel pnlProgreso;
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>

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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblCategoria = new Label();
            lblPorcentaje = new Label();
            lblDetalle = new Label();
            lblRestante = new Label();
            pnlFondoBarra = new Panel();
            pnlProgreso = new Panel();
            PanelFondo = new CuoreUI.Controls.cuiPanel();
            pnlFondoBarra.SuspendLayout();
            SuspendLayout();
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(15, 24);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(127, 23);
            lblCategoria.TabIndex = 1;
            lblCategoria.Text = "Supermercado";
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPorcentaje.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPorcentaje.ForeColor = Color.FromArgb(239, 152, 39);
            lblPorcentaje.Location = new Point(234, 24);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(70, 21);
            lblPorcentaje.TabIndex = 2;
            lblPorcentaje.Text = "83%";
            lblPorcentaje.TextAlign = ContentAlignment.TopRight;
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetalle.ForeColor = Color.Gray;
            lblDetalle.Location = new Point(15, 60);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(239, 20);
            lblDetalle.TabIndex = 3;
            lblDetalle.Text = "Gastado: $250.00 / Límite: $300.00";
            // 
            // lblRestante
            // 
            lblRestante.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRestante.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRestante.ForeColor = Color.FromArgb(239, 152, 39);
            lblRestante.Location = new Point(104, 115);
            lblRestante.Name = "lblRestante";
            lblRestante.Size = new Size(200, 17);
            lblRestante.TabIndex = 5;
            lblRestante.Text = "Restan $50.00";
            lblRestante.TextAlign = ContentAlignment.TopRight;
            // 
            // pnlFondoBarra
            // 
            pnlFondoBarra.BackColor = Color.FromArgb(241, 245, 249);
            pnlFondoBarra.Controls.Add(pnlProgreso);
            pnlFondoBarra.Location = new Point(18, 92);
            pnlFondoBarra.Name = "pnlFondoBarra";
            pnlFondoBarra.Size = new Size(286, 10);
            pnlFondoBarra.TabIndex = 4;
            // 
            // pnlProgreso
            // 
            pnlProgreso.BackColor = Color.FromArgb(239, 152, 39);
            pnlProgreso.Dock = DockStyle.Left;
            pnlProgreso.Location = new Point(0, 0);
            pnlProgreso.Name = "pnlProgreso";
            pnlProgreso.Size = new Size(237, 10);
            pnlProgreso.TabIndex = 0;
            // 
            // PanelFondo
            // 
            PanelFondo.BackColor = Color.FromArgb(248, 250, 252);
            PanelFondo.Dock = DockStyle.Fill;
            PanelFondo.Location = new Point(0, 0);
            PanelFondo.Name = "PanelFondo";
            PanelFondo.OutlineThickness = 1F;
            PanelFondo.PanelColor = Color.White;
            PanelFondo.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            PanelFondo.Rounding = new Padding(15);
            PanelFondo.Size = new Size(320, 165);
            PanelFondo.TabIndex = 0;
            // 
            // ucTarjetaPresupuesto
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblRestante);
            Controls.Add(pnlFondoBarra);
            Controls.Add(lblDetalle);
            Controls.Add(lblPorcentaje);
            Controls.Add(lblCategoria);
            Name = "ucTarjetaPresupuesto";
            Size = new Size(320, 145);
            pnlFondoBarra.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CuoreUI.Controls.cuiPanel PanelFondo;
    }
}
