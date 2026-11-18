using ControlFinanzas.BLL;
using ControlFinanzas.Entity.Entidades;
using ControlFinanzas.Entity.Sesion;
using ControlFinanzas.UI.Controles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlFinanzas.UI.Formularios
{
    public partial class FrmMetasAhorro : Form
    {
        private readonly MetaAhorroBLL _metaBLL;
        private readonly CultureInfo _cultura = new("es-MX");

        private readonly int _UsuarioIdLogueado;

        private List<MetaAhorroEntity> _metasCargadas = new();
        private int? _metaIdEdicion = null;
        private bool _cargando = false;

        public FrmMetasAhorro()
        {
            InitializeComponent();

            _metaBLL = new MetaAhorroBLL();

            ConfigurarControles();

            // Escuchar cambios en metas de ahorro en tiempo real
            EventosFinanzas.MetasAhorroCambiadas += OnMetasAhorroCambiadas;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            EventosFinanzas.MetasAhorroCambiadas -= OnMetasAhorroCambiadas;
            base.OnFormClosed(e);
        }

        private void OnMetasAhorroCambiadas(object? sender, EventArgs e)
        {
            if (this.IsDisposed || !this.IsHandleCreated) return;

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(async () => await CargarMetasAsync()));
            }
            else
            {
                _ = CargarMetasAsync();
            }
        }

        private void ConfigurarControles()
        {
            dtpFechaLimite.MinDate = DateTime.Today;
            dtpFechaLimite.Value = DateTime.Today.AddMonths(1);

            numMontoObjetivo.Minimum = 0M;
            numMontoObjetivo.Maximum = 100000000M;
            numMontoObjetivo.DecimalPlaces = 2;
            numMontoObjetivo.ThousandsSeparator = true;

            cmbSeleccionarTipo.Items = new string[] { "Todas", "Activa", "Completada", "Cancelada" };
            cmbSeleccionarTipo.SelectedIndex = 0;
            cmbSeleccionarTipo.SelectedItem = "Todas";

            flpContenedordeTrajetas.AutoScroll = true;
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await CargarMetasAsync();
        }

        protected override async void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (!this.Visible || IsDisposed || Disposing || _cargando)
                return;

            await CargarMetasAsync();
        }

        private async Task CargarMetasAsync()
        {
            if (_cargando || IsDisposed || Disposing)
                return;

            _cargando = true;

            try
            {
                int usuarioId = SesionUsuario.HaySesionActiva ? SesionUsuario.UsuarioId : 0;
                if (usuarioId <= 0)
                    return;

                _metasCargadas = await _metaBLL.ObtenerPorUsuarioAsync(usuarioId);

                ActualizarResumenKPIs();
                RenderizarTarjetas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las metas de ahorro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _cargando = false;
            }
        }

        private void ActualizarResumenKPIs()
        {
            int activas = _metasCargadas.Count(m => m.Estado.Equals("Activa", StringComparison.OrdinalIgnoreCase));
            decimal totalAhorrado = _metasCargadas
                .Where(m => !m.Estado.Equals("Cancelada", StringComparison.OrdinalIgnoreCase))
                .Sum(m => m.MontoActual);

            lblTotalMetasActivas.Text = activas.ToString();
            lblTotalDineroAhorrado.Text = totalAhorrado.ToString("C2", _cultura);
        }

        private void RenderizarTarjetas()
        {
            flpContenedordeTrajetas.SuspendLayout();

            try
            {
                var controlesPrevios = flpContenedordeTrajetas.Controls.Cast<Control>().ToList();
                flpContenedordeTrajetas.Controls.Clear();

                foreach (var ctrl in controlesPrevios)
                {
                    ctrl.Dispose();
                }

                string filtro = cmbSeleccionarTipo.SelectedItem?.ToString() ?? "Todas";
                var metasFiltradas = (string.IsNullOrWhiteSpace(filtro) || filtro.Equals("Todas", StringComparison.OrdinalIgnoreCase))
                    ? _metasCargadas
                    : _metasCargadas.Where(m => m.Estado.Equals(filtro.Trim(), StringComparison.OrdinalIgnoreCase)).ToList();

                if (metasFiltradas.Count == 0)
                {
                    Label lblVacio = new Label
                    {
                        Text = "No se encontraron metas de ahorro en esta vista.\n¡Crea una nueva meta usando el panel de la izquierda!",
                        Font = new Font("Segoe UI", 11F),
                        ForeColor = Color.FromArgb(100, 116, 139),
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = false,
                        Size = new Size(Math.Max(350, flpContenedordeTrajetas.Width - 40), 120),
                        Margin = new Padding(20, 40, 20, 20)
                    };

                    flpContenedordeTrajetas.Controls.Add(lblVacio);
                }
                else
                {
                    foreach (var meta in metasFiltradas)
                    {
                        var tarjeta = new ucTrajetaAhorro();
                        tarjeta.CargarDatos(meta);

                        tarjeta.OnAbonar += Tarjeta_OnAbonar;
                        tarjeta.OnEditar += Tarjeta_OnEditar;
                        tarjeta.OnCancelar += Tarjeta_OnCancelar;

                        flpContenedordeTrajetas.Controls.Add(tarjeta);
                    }
                }
            }
            finally
            {
                flpContenedordeTrajetas.ResumeLayout(true);
            }
        }

        private async void Tarjeta_OnAbonar(object? sender, MetaAhorroEntity meta)
        {
            using var modal = new FrmAbonarMetaAhorro(meta);
            if (modal.ShowDialog(this) == DialogResult.OK)
            {
                await CargarMetasAsync();
            }
        }

        private void Tarjeta_OnEditar(object? sender, MetaAhorroEntity meta)
        {
            _metaIdEdicion = meta.Id;
            txtNombreMeta.Content = meta.Nombre;
            numMontoObjetivo.Value = meta.MontoObjetivo;

            if (meta.FechaLimite >= dtpFechaLimite.MinDate)
            {
                dtpFechaLimite.Value = meta.FechaLimite;
            }
            else
            {
                dtpFechaLimite.Value = DateTime.Today.AddMonths(1);
            }

            btnGuardarMeta.Content = "Actualizar Meta";
        }

        private async void Tarjeta_OnCancelar(object? sender, MetaAhorroEntity meta)
        {
            if (meta.MontoActual > 0)
            {
                // Si tiene dinero acumulado, abrir modal para seleccionar cuenta de reembolso
                using var modal = new FrmCancelarMetaAhorro(meta);
                if (modal.ShowDialog(this) == DialogResult.OK)
                {
                    await CargarMetasAsync();
                }
            }
            else
            {
                // Si tiene $0, confirmar cancelación directa
                var confirmacion = MessageBox.Show(
                    $"¿Estás seguro de que deseas cancelar la meta '{meta.Nombre}'?",
                    "Confirmar Cancelación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        int usuarioId = SesionUsuario.HaySesionActiva ? SesionUsuario.UsuarioId : meta.UsuarioId;
                        await _metaBLL.CambiarEstadoAsync(meta.Id, usuarioId, "Cancelada");
                        await CargarMetasAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error al cancelar la meta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void btnGuardarMeta_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreMeta.Content?.Trim() ?? string.Empty;
            decimal objetivo = numMontoObjetivo.Value;
            DateTime fechaLimite = dtpFechaLimite.Value.Date;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor ingresa el nombre de la meta.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (objetivo <= 0)
            {
                MessageBox.Show("El monto objetivo debe ser mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numMontoObjetivo.Focus();
                return;
            }

            int usuarioId = SesionUsuario.HaySesionActiva ? SesionUsuario.UsuarioId : 0;
            if (usuarioId <= 0)
            {
                MessageBox.Show("No se encontró una sesión activa de usuario.", "Sesión requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnGuardarMeta.Enabled = false;

                if (_metaIdEdicion == null)
                {
                    var nuevaMeta = new MetaAhorroEntity(usuarioId, nombre, objetivo, fechaLimite);
                    await _metaBLL.GuardarAsync(nuevaMeta);

                    MessageBox.Show($"¡Meta '{nombre}' creada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var metaExistente = _metasCargadas.FirstOrDefault(m => m.Id == _metaIdEdicion.Value);
                    if (metaExistente == null)
                    {
                        metaExistente = new MetaAhorroEntity(usuarioId, nombre, objetivo, fechaLimite);
                        metaExistente.AsignarId(_metaIdEdicion.Value);
                    }
                    else
                    {
                        metaExistente.CambiarNombre(nombre);
                        metaExistente.AsignarMontoObjetivo(objetivo);
                        metaExistente.AsignarFechaLimite(fechaLimite);
                    }

                    await _metaBLL.GuardarAsync(metaExistente);

                    MessageBox.Show($"¡Meta '{nombre}' actualizada correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimpiarFormularioEdicion();
                await CargarMetasAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar la meta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardarMeta.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormularioEdicion();
        }

        private void LimpiarFormularioEdicion()
        {
            _metaIdEdicion = null;
            txtNombreMeta.Content = string.Empty;
            numMontoObjetivo.Value = 0;
            dtpFechaLimite.Value = DateTime.Today.AddMonths(1);
            btnGuardarMeta.Content = "Guardar Meta";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            RenderizarTarjetas();
        }

        private void cmbSeleccionarTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            RenderizarTarjetas();
        }

        private void txtNombreMeta_ContentChanged(object sender, EventArgs e)
        {
        }

        private void numMontoObjetivo_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dtpFechaLimite_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
