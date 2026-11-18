using ControlFinanzas.BLL;
using ControlFinanzas.BLL.Servicios;
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
    public class FrmCancelarMetaAhorro : Form
    {
        private readonly MetaAhorroEntity _meta;
        private readonly MetaAhorroBLL _metaBLL;
        private readonly CuentaBLL _cuentaBLL;
        private List<CuentaEntity> _cuentasDisponibles = new();
        private readonly CultureInfo _cultura = new("es-MX");

        private Panel pnlHeader = null!;
        private Label lblTitulo = null!;
        private Label lblSubtitulo = null!;
        private Label lblCuenta = null!;
        private ComboBox cmbCuentaDestino = null!;
        private Label lblSaldoCuenta = null!;
        private Button btnConfirmar = null!;
        private Button btnVolver = null!;
        private Button btnCerrarX = null!;

        public FrmCancelarMetaAhorro(MetaAhorroEntity meta)
        {
            _meta = meta ?? throw new ArgumentNullException(nameof(meta));
            _metaBLL = new MetaAhorroBLL();
            _cuentaBLL = new CuentaBLL();

            ConstruirComponentes();
            CargarCuentas();
        }

        private void ConstruirComponentes()
        {
            this.Size = new Size(420, 360);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.White;
            this.DoubleBuffered = true;

            this.Paint += (s, e) =>
            {
                using Pen pen = new Pen(Color.FromArgb(203, 213, 225), 1.5f);
                e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
            };

            pnlHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 85,
                BackColor = Color.FromArgb(254, 242, 242), // Rojo muy suave
                Padding = new Padding(20, 15, 20, 10)
            };

            btnCerrarX = new Button
            {
                Text = "✕",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(153, 27, 27),
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(28, 28),
                Location = new Point(375, 12),
                Cursor = Cursors.Hand
            };
            btnCerrarX.FlatAppearance.BorderSize = 0;
            btnCerrarX.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };

            lblTitulo = new Label
            {
                Text = "Cancelar Meta de Ahorro",
                Font = new Font("Segoe UI", 13, FontStyle.Bold),
                ForeColor = Color.FromArgb(153, 27, 27),
                Location = new Point(20, 15),
                AutoSize = true
            };

            lblSubtitulo = new Label
            {
                Text = $"Se reembolsarán {_meta.MontoActual.ToString("C2", _cultura)} a tu cuenta.",
                Font = new Font("Segoe UI", 9.5f),
                ForeColor = Color.FromArgb(185, 28, 28),
                Location = new Point(20, 48),
                AutoSize = true
            };

            pnlHeader.Controls.Add(btnCerrarX);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Controls.Add(lblSubtitulo);

            lblCuenta = new Label
            {
                Text = "Selecciona la cuenta destino del reembolso:",
                Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                Location = new Point(25, 105),
                AutoSize = true
            };

            cmbCuentaDestino = new ComboBox
            {
                Font = new Font("Segoe UI Semibold", 11),
                Location = new Point(25, 135),
                Size = new Size(365, 30),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbCuentaDestino.SelectedIndexChanged += (s, e) => ActualizarSaldo();

            lblSaldoCuenta = new Label
            {
                Text = "Saldo actual disponible: $0.00",
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.FromArgb(100, 116, 139),
                Location = new Point(25, 175),
                AutoSize = true
            };

            btnConfirmar = new Button
            {
                Text = "Devolver Fondos y Cancelar",
                Font = new Font("Segoe UI Semibold", 10.5f, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(220, 38, 38), // Rojo
                FlatStyle = FlatStyle.Flat,
                Size = new Size(215, 38),
                Location = new Point(175, 290),
                Cursor = Cursors.Hand
            };
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.Click += BtnConfirmar_Click;

            btnVolver = new Button
            {
                Text = "Regresar",
                Font = new Font("Segoe UI Semibold", 10.5f, FontStyle.Bold),
                ForeColor = Color.FromArgb(71, 85, 105),
                BackColor = Color.FromArgb(241, 245, 249),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(130, 38),
                Location = new Point(25, 290),
                Cursor = Cursors.Hand
            };
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };

            this.Controls.Add(pnlHeader);
            this.Controls.Add(lblCuenta);
            this.Controls.Add(cmbCuentaDestino);
            this.Controls.Add(lblSaldoCuenta);
            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnVolver);
        }

        private void CargarCuentas()
        {
            try
            {
                var todas = _cuentaBLL.ObtenerTodas();
                _cuentasDisponibles = todas
                    .Where(c => c.Estado && (c.TipoCuenta.Equals("Debito", StringComparison.OrdinalIgnoreCase) ||
                                            c.TipoCuenta.Equals("Efectivo", StringComparison.OrdinalIgnoreCase)))
                    .ToList();

                cmbCuentaDestino.Items.Clear();
                foreach (var cuenta in _cuentasDisponibles)
                {
                    cmbCuentaDestino.Items.Add($"{cuenta.Nombre} ({cuenta.TipoCuenta})");
                }

                if (_cuentasDisponibles.Count > 0)
                {
                    cmbCuentaDestino.SelectedIndex = 0;
                }
                else
                {
                    lblSaldoCuenta.Text = "No hay cuentas activas disponibles para el reembolso.";
                    lblSaldoCuenta.ForeColor = Color.Red;
                    btnConfirmar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cuentas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarSaldo()
        {
            if (cmbCuentaDestino.SelectedIndex >= 0 && cmbCuentaDestino.SelectedIndex < _cuentasDisponibles.Count)
            {
                var cuenta = _cuentasDisponibles[cmbCuentaDestino.SelectedIndex];
                lblSaldoCuenta.Text = $"Saldo actual: {cuenta.ObtenerSaldoMostrar().ToString("C2", _cultura)}";
            }
        }

        private async void BtnConfirmar_Click(object? sender, EventArgs e)
        {
            if (cmbCuentaDestino.SelectedIndex < 0 || cmbCuentaDestino.SelectedIndex >= _cuentasDisponibles.Count)
            {
                MessageBox.Show("Por favor selecciona una cuenta para recibir el reembolso.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cuenta = _cuentasDisponibles[cmbCuentaDestino.SelectedIndex];

            var confirm = MessageBox.Show(
                $"¿Confirmas que deseas cancelar la meta '{_meta.Nombre}' y transferir sus {_meta.MontoActual.ToString("C2", _cultura)} a '{cuenta.Nombre}'?",
                "Confirmar Cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                btnConfirmar.Enabled = false;
                btnVolver.Enabled = false;

                int usuarioId = SesionUsuario.HaySesionActiva ? SesionUsuario.UsuarioId : _meta.UsuarioId;
                await _metaBLL.CancelarYDevolverAsync(usuarioId, _meta.Id, cuenta.Id);

                if (cuenta is CuentaDebitoEntity debito)
                {
                    debito.SaldoActual += _meta.MontoActual;
                }
                ActualizarSaldo();

                MessageBox.Show($"La meta fue cancelada y se han reembolsado {_meta.MontoActual.ToString("C2", _cultura)} a '{cuenta.Nombre}'.", "Meta Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cancelar la meta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnConfirmar.Enabled = true;
                btnVolver.Enabled = true;
            }
        }
    }
}
