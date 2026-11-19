using ControlFinanzas.BLL;
using ControlFinanzas.Entity.Entidades;
using ControlFinanzas.Entity.Sesion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ControlFinanzas.UI.Formularios
{
    public partial class FrmAbonarMetaAhorro : Form
    {
        private readonly MetaAhorroEntity _meta;
        private readonly MetaAhorroBLL _metaBLL;
        private readonly CuentaBLL _cuentaBLL;

        private List<CuentaEntity> _cuentasDisponibles = new();
        private readonly CultureInfo _cultura = new("es-MX");

        public FrmAbonarMetaAhorro(MetaAhorroEntity meta)
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            _meta = meta ?? throw new ArgumentNullException(nameof(meta));
            _metaBLL = new MetaAhorroBLL();
            _cuentaBLL = new CuentaBLL();

            ConfigurarBordeModal();
            CargarDatosMeta();
            CargarCuentasDisponibles();
        }

        public FrmAbonarMetaAhorro() : this(new MetaAhorroEntity())
        {
        }

        private void ConfigurarBordeModal()
        {
            this.Paint += (s, e) =>
            {
                using Pen pen = new Pen(Color.FromArgb(203, 213, 225), 1.5f);
                e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
            };
        }

        private void CargarDatosMeta()
        {
            lblTituloMeta.Text = $"Abonar a: {_meta.Nombre}";
            lblMontoFaltante.Text = $"Faltan {_meta.MontoFaltante.ToString("C2", _cultura)} para completar la meta";

            if (_meta.SugerenciaSemanal > 0)
            {
                lblSugerencia.Text = $"💡 Sugerencia semanal: {_meta.SugerenciaSemanal.ToString("C2", _cultura)}";
                pnlSugerencia.Visible = true;
            }
            else
            {
                pnlSugerencia.Visible = false;
            }

            nudMontoAbono.Minimum = 0.01M;
            nudMontoAbono.Maximum = Math.Max(0.01M, _meta.MontoFaltante);
            nudMontoAbono.DecimalPlaces = 2;

            decimal valorInicial = _meta.SugerenciaSemanal > 0 ? _meta.SugerenciaSemanal : Math.Min(50m, _meta.MontoFaltante);
            nudMontoAbono.Value = Math.Min(valorInicial, _meta.MontoFaltante);
        }

        private void CargarCuentasDisponibles()
        {
            try
            {
                var todas = _cuentaBLL.ObtenerTodas();

                // Filtrar solo cuentas activas de débito y efectivo (no tarjetas de crédito)
                _cuentasDisponibles = todas
                    .Where(c => c.Estado && (c.TipoCuenta.Equals("Debito", StringComparison.OrdinalIgnoreCase) ||
                                            c.TipoCuenta.Equals("Efectivo", StringComparison.OrdinalIgnoreCase)))
                    .ToList();

                cmbCuentaOrigen.Items.Clear();

                foreach (var cuenta in _cuentasDisponibles)
                {
                    cmbCuentaOrigen.Items.Add($"{cuenta.Nombre} ({cuenta.TipoCuenta})");
                }

                if (_cuentasDisponibles.Count > 0)
                {
                    cmbCuentaOrigen.SelectedIndex = 0;
                }
                else
                {
                    lblSaldoCuenta.Text = "Saldo disponible: $0.00";
                    lblSaldoCuenta.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las cuentas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarSaldoCuentaSeleccionada();
        }

        private void ActualizarSaldoCuentaSeleccionada()
        {
            if (cmbCuentaOrigen.SelectedIndex >= 0 && cmbCuentaOrigen.SelectedIndex < _cuentasDisponibles.Count)
            {
                var cuenta = _cuentasDisponibles[cmbCuentaOrigen.SelectedIndex];
                decimal saldo = cuenta.ObtenerSaldoMostrar();

                lblSaldoCuenta.Text = $"Saldo disponible: {saldo.ToString("C2", _cultura)}";
                lblSaldoCuenta.ForeColor = saldo > 0 ? Color.FromArgb(71, 85, 105) : Color.FromArgb(239, 68, 68);
            }
            else
            {
                lblSaldoCuenta.Text = "Saldo disponible: $0.00";
            }
        }

        private void lnkUsarSugerencia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_meta.SugerenciaSemanal > 0)
            {
                decimal sugerido = Math.Min(_meta.SugerenciaSemanal, _meta.MontoFaltante);
                nudMontoAbono.Value = sugerido;
            }
        }

        private void nudMontoAbono_ValueChanged(object sender, EventArgs e)
        {
            // Validar visualmente si el monto ingresado supera el saldo disponible
            if (cmbCuentaOrigen.SelectedIndex >= 0 && cmbCuentaOrigen.SelectedIndex < _cuentasDisponibles.Count)
            {
                var cuenta = _cuentasDisponibles[cmbCuentaOrigen.SelectedIndex];
                decimal saldo = cuenta.ObtenerSaldoMostrar();

                if (nudMontoAbono.Value > saldo)
                {
                    lblSaldoCuenta.ForeColor = Color.FromArgb(239, 68, 68);
                }
                else
                {
                    lblSaldoCuenta.ForeColor = Color.FromArgb(71, 85, 105);
                }
            }
        }

        private async void btnConfirmarTransferencia_Click(object sender, EventArgs e)
        {
            if (cmbCuentaOrigen.SelectedIndex < 0 || cmbCuentaOrigen.SelectedIndex >= _cuentasDisponibles.Count)
            {
                MessageBox.Show("Por favor, selecciona una cuenta de origen válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCuentaOrigen.Focus();
                return;
            }

            var cuentaSeleccionada = _cuentasDisponibles[cmbCuentaOrigen.SelectedIndex];
            decimal montoAbono = nudMontoAbono.Value;

            if (montoAbono <= 0)
            {
                MessageBox.Show("El monto a abonar debe ser mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudMontoAbono.Focus();
                return;
            }

            if (montoAbono > cuentaSeleccionada.ObtenerSaldoMostrar())
            {
                MessageBox.Show($"La cuenta '{cuentaSeleccionada.Nombre}' no cuenta con saldo suficiente ({cuentaSeleccionada.ObtenerSaldoMostrar().ToString("C2", _cultura)}) para realizar este abono.", "Saldo insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (montoAbono > _meta.MontoFaltante)
            {
                MessageBox.Show($"El abono ({montoAbono.ToString("C2", _cultura)}) supera el monto restante para completar la meta ({_meta.MontoFaltante.ToString("C2", _cultura)}).", "Monto excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnConfirmarTransferencia.Enabled = false;
                btnCancelar.Enabled = false;

                int usuarioId = SesionUsuario.HaySesionActiva ? SesionUsuario.UsuarioId : _meta.UsuarioId;
                await _metaBLL.AbonarAsync(usuarioId, _meta.Id, cuentaSeleccionada.Id, montoAbono);

                // Actualizar el saldo de la cuenta seleccionada en memoria y reflejarlo en la interfaz
                if (cuentaSeleccionada is CuentaDebitoEntity debito)
                {
                    debito.SaldoActual -= montoAbono;
                }
                ActualizarSaldoCuentaSeleccionada();

                MessageBox.Show($"¡Abono de {montoAbono.ToString("C2", _cultura)} realizado con éxito a la meta '{_meta.Nombre}'!", "Abono exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al procesar el abono", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnConfirmarTransferencia.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCerrarX_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
