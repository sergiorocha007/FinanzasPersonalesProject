using ControlFinanzas.Entity.Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlFinanzas.UI.Controles
{
    public partial class ucTarjetaPresupuesto : UserControl
    {
        public ucTarjetaPresupuesto()
        {
            InitializeComponent();
        }

        public void CargarDatos(PresupuestoDTO p)
        {
            lblCategoria.Text = p.CategoriaNombre;
            lblDetalle.Text = $"Gastado: {p.GastoActual:C2} / Límite: {p.LimiteMensual:C2}";

            decimal porcentaje = p.PorcentajeConsumido;
            lblPorcentaje.Text = $"{porcentaje:N0}%";

            if (p.Restante >= 0)
            {
                lblRestante.Text = $"Restan {p.Restante:C2}";
            }
            else
            {
                lblRestante.Text = $"Excedido por {Math.Abs(p.Restante):C2}";
            }

            Color colorEstado;
            if (porcentaje < 50)
            {
                // Verde: poco gasto
                colorEstado = Color.FromArgb(34, 197, 94);
            }
            else if (porcentaje < 80)
            {
                // Naranja: mitad o pasando la mitad
                colorEstado = Color.FromArgb(239, 152, 39);
            }
            else
            {
                // Rojo: cerca del limite o superado
                colorEstado = Color.FromArgb(239, 68, 68);
            }

            lblPorcentaje.ForeColor = colorEstado;
            lblRestante.ForeColor = colorEstado;
            pnlProgreso.BackColor = colorEstado;

            // Calcular ancho de la barra de progreso proporcional al porcentaje (maximo 100%)
            int anchoTotal = pnlFondoBarra.Width;
            float factor = (float)Math.Min(porcentaje, 100m) / 100f;
            pnlProgreso.Width = (int)(anchoTotal * factor);
        }
    }
}
