using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;
using ControlFinanzas.Entity.Entidades;

namespace ControlFinanzas.UI.Controles
{
    public partial class ucTrajetaAhorro : UserControl
    {
        public MetaAhorroEntity? Meta { get; private set; }

        public event EventHandler<MetaAhorroEntity>? OnAbonar;
        public event EventHandler<MetaAhorroEntity>? OnEditar;
        public event EventHandler<MetaAhorroEntity>? OnCancelar;

        public ucTrajetaAhorro()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            ConfigurarEstilosRedondeados();
        }

        public void CargarDatos(MetaAhorroEntity meta)
        {
            Meta = meta ?? throw new ArgumentNullException(nameof(meta));

            lblNombre.Text = meta.Nombre;
            lblMonto.Text = meta.MontoActual.ToString("C2", new CultureInfo("es-MX"));
            lblObjetivo.Text = "de " + meta.MontoObjetivo.ToString("C2", new CultureInfo("es-MX"));
            lblPorcentaje.Text = $"{meta.PorcentajeCompletado:0}%";

            lblFechaLimite.Text = "📅 " + meta.FechaLimite.ToString("dd MMM yyyy", new CultureInfo("es-ES"));

            ActualizarBarraProgreso(meta);
            ActualizarEstadoVisual(meta);
            ActualizarSugerenciaVisual(meta);
        }

        private void ActualizarBarraProgreso(MetaAhorroEntity meta)
        {
            int totalAncho = pnlBarraProgreso.Width;
            int anchoCalculado = (int)((totalAncho * (double)meta.PorcentajeCompletado) / 100.0);
            pnlProgreso.Width = Math.Max(0, Math.Min(totalAncho, anchoCalculado));

            if (meta.EstaCompletada)
            {
                pnlProgreso.BackColor = Color.FromArgb(34, 197, 94); // Verde éxito
            }
            else
            {
                pnlProgreso.BackColor = Color.FromArgb(239, 152, 39); // Naranja cálido
            }
        }

        private void ActualizarEstadoVisual(MetaAhorroEntity meta)
        {
            lblEstado.Text = meta.Estado;

            switch (meta.Estado)
            {
                case "Activa":
                    lblEstado.BackColor = Color.FromArgb(220, 252, 231);
                    lblEstado.ForeColor = Color.FromArgb(21, 128, 61);

                    lblDiasRestantes.Text = meta.DiasRestantes == 1 ? "Falta 1 día" : $"Faltan {meta.DiasRestantes} días";
                    lblDiasRestantes.BackColor = Color.FromArgb(241, 245, 249);
                    lblDiasRestantes.ForeColor = Color.FromArgb(71, 85, 105);

                    btnAbonar.Visible = true;
                    btnEditar.Visible = true;
                    btnCancelar.Visible = true;
                    break;

                case "Completada":
                    lblEstado.BackColor = Color.FromArgb(219, 234, 254);
                    lblEstado.ForeColor = Color.FromArgb(29, 78, 216);

                    lblDiasRestantes.Text = "Completada";
                    lblDiasRestantes.BackColor = Color.FromArgb(219, 234, 254);
                    lblDiasRestantes.ForeColor = Color.FromArgb(29, 78, 216);

                    btnAbonar.Visible = false;
                    btnEditar.Visible = false;
                    btnCancelar.Visible = false;
                    break;

                case "Cancelada":
                    lblEstado.BackColor = Color.FromArgb(241, 245, 249);
                    lblEstado.ForeColor = Color.FromArgb(100, 116, 139);

                    lblDiasRestantes.Text = "Cancelada";
                    lblDiasRestantes.BackColor = Color.FromArgb(241, 245, 249);
                    lblDiasRestantes.ForeColor = Color.FromArgb(100, 116, 139);

                    btnAbonar.Visible = false;
                    btnEditar.Visible = false;
                    btnCancelar.Visible = false;
                    break;
            }

            AplicarRegionRedondeada(lblEstado, 11);
            AplicarRegionRedondeada(lblDiasRestantes, 11);
        }

        private void ActualizarSugerenciaVisual(MetaAhorroEntity meta)
        {
            if (meta.EstaCompletada)
            {
                lblSugerencia.Text = "🎉 ¡Felicidades! Has completado esta meta con éxito.";
            }
            else if (meta.Estado == "Cancelada")
            {
                lblSugerencia.Text = "Esta meta ha sido cancelada y sus fondos devueltos.";
            }
            else if (meta.DiasRestantes <= 0)
            {
                lblSugerencia.Text = "⚠️ La fecha límite ha llegado. ¡Abona para finalizarla!";
            }
            else
            {
                string sugerenciaFormateada = meta.SugerenciaSemanal.ToString("C2", new CultureInfo("es-MX"));
                lblSugerencia.Text = $"💡 Ahorra {sugerenciaFormateada} por semana para llegar a tiempo";
            }
        }

        private void ConfigurarEstilosRedondeados()
        {
            AplicarRegionRedondeada(this, 14);
            AplicarRegionRedondeada(lblEstado, 11);
            AplicarRegionRedondeada(lblDiasRestantes, 11);
            AplicarRegionRedondeada(pnlSugerencia, 8);
            AplicarRegionRedondeada(btnAbonar, 8);
            AplicarRegionRedondeada(btnEditar, 8);
            AplicarRegionRedondeada(btnCancelar, 8);

            this.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                using (GraphicsPath path = CrearRutaRedondeada(rect, 14))
                using (Pen pen = new Pen(Color.FromArgb(226, 232, 240), 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            };
        }

        private void AplicarRegionRedondeada(Control control, int radio)
        {
            if (control.Width <= 0 || control.Height <= 0) return;

            Rectangle rect = new Rectangle(0, 0, control.Width, control.Height);
            using (GraphicsPath path = CrearRutaRedondeada(rect, radio))
            {
                control.Region = new Region(path);
            }
        }

        private GraphicsPath CrearRutaRedondeada(Rectangle rect, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            int diametro = radio * 2;
            path.AddArc(rect.X, rect.Y, diametro, diametro, 180, 90);
            path.AddArc(rect.Right - diametro, rect.Y, diametro, diametro, 270, 90);
            path.AddArc(rect.Right - diametro, rect.Bottom - diametro, diametro, diametro, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diametro, diametro, diametro, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            if (Meta != null)
                OnAbonar?.Invoke(this, Meta);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Meta != null)
                OnEditar?.Invoke(this, Meta);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Meta != null)
                OnCancelar?.Invoke(this, Meta);
        }
    }
}
