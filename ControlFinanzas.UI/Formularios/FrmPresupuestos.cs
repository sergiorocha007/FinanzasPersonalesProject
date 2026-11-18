using ControlFinanzas.BLL;
using ControlFinanzas.DAL;
using ControlFinanzas.Entity.Entidades;
using ControlFinanzas.Entity.Sesion;
using ControlFinanzas.UI.Controles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlFinanzas.UI.Formularios
{
    public partial class FrmPresupuestos : Form
    {
        private bool _cargandoPresupuestos = false;

        private readonly PresupuestoBLL _presupuestoBLL;
        private readonly CategoriaBLL _categoriaBLL;
        private readonly int _usuarioIdLogueado;
        private List<CategoriaEntity> _categoriasGasto = new();
        private bool _cargando;

        public FrmPresupuestos()
        {
            InitializeComponent();

            _presupuestoBLL = new PresupuestoBLL(new PresupuestoDAL());
            _categoriaBLL = new CategoriaBLL();
            _usuarioIdLogueado = SesionUsuario.HaySesionActiva ? SesionUsuario.UsuarioId : 0;

            InicializarPeriodo();
            ConectarEventos();
        }

        private bool _cargandoVista = false;

        protected override async void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (!this.Visible || IsDisposed || Disposing || _cargandoVista)
                return;

            _cargandoVista = true;

            try
            {
                await CargarCategoriasGastoAsync();

                if (IsDisposed || Disposing)
                    return;

                await CargarPresupuestosAsync();
            }
            finally
            {
                _cargandoVista = false;
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Desuscribir evento para evitar memory leaks
            TransaccionBLL.MovimientoRegistrado -= OnMovimientoRegistrado;
            EventosFinanzas.PresupuestosCambiados -= OnPresupuestosCambiados;
            EventosFinanzas.CategoriasCambiadas -= OnCategoriasCambiadas;
            EventosFinanzas.TransaccionesCambiadas -= OnMovimientoRegistrado;
            base.OnFormClosed(e);
        }

        private async void FrmPresupuestos_Load(object sender, EventArgs e)
        {
            await CargarCategoriasGastoAsync();
            await CargarPresupuestosAsync();
        }

        private void InicializarPeriodo()
        {
            _cargando = true;

            int anioActual = DateTime.Now.Year;
            int mesActual = DateTime.Now.Month;

            comboBoxAnios.Items = new string[]
            {
                (anioActual - 2).ToString(),
                (anioActual - 1).ToString(),
                anioActual.ToString(),
                (anioActual + 1).ToString(),
                (anioActual + 2).ToString()
            };
            comboBoxAnios.SelectedItem = anioActual.ToString();

            numericUpDown2.Minimum = 1;
            numericUpDown2.Maximum = 12;
            numericUpDown2.Value = mesActual;

            numericUpDown1.Minimum = 0.01M;
            numericUpDown1.Maximum = 100000000M;
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.ThousandsSeparator = true;
            numericUpDown1.Value = 100M;

            _cargando = false;
        }

        private void ConectarEventos()
        {
            cuiButton3.Click += btnGuardarPresupuesto_Click;
            cuiButton4.Click += cuiButton4_Click;
            numericUpDown2.ValueChanged += Periodo_Changed;
            comboBoxAnios.SelectedIndexChanged += Periodo_Changed;

            // Escuchar cambios en tiempo real
            TransaccionBLL.MovimientoRegistrado += OnMovimientoRegistrado;
            EventosFinanzas.PresupuestosCambiados += OnPresupuestosCambiados;
            EventosFinanzas.CategoriasCambiadas += OnCategoriasCambiadas;
            EventosFinanzas.TransaccionesCambiadas += OnMovimientoRegistrado;
        }

        private void OnMovimientoRegistrado(object? sender, EventArgs e)
        {
            if (this.IsDisposed || !this.IsHandleCreated) return;

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(async () => await CargarPresupuestosAsync()));
            }
            else
            {
                _ = CargarPresupuestosAsync();
            }
        }

        private void OnPresupuestosCambiados(object? sender, EventArgs e)
        {
            if (this.IsDisposed || !this.IsHandleCreated) return;

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(async () => await CargarPresupuestosAsync()));
            }
            else
            {
                _ = CargarPresupuestosAsync();
            }
        }

        private void OnCategoriasCambiadas(object? sender, EventArgs e)
        {
            if (this.IsDisposed || !this.IsHandleCreated) return;

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(async () => await CargarCategoriasGastoAsync()));
            }
            else
            {
                _ = CargarCategoriasGastoAsync();
            }
        }

        private async Task CargarCategoriasGastoAsync()
        {
            try
            {
                var todas = await _categoriaBLL.ObtenerConFiltroAsync(_usuarioIdLogueado, null, "Gasto");

                if (todas != null)
                {
                    _categoriasGasto = todas.Where(c => c.Estado).ToList();
                }
                else
                {
                    _categoriasGasto = new List<CategoriaEntity>();
                }

                List<string> nombres = _categoriasGasto.Select(c => c.Nombre).ToList();
                cuiComboBox2.Items = nombres.ToArray();

                if (nombres.Count > 0)
                {
                    cuiComboBox2.SelectedIndex = 0;
                    cuiComboBox2.SelectedItem = nombres[0];
                }
                else
                {
                    cuiComboBox2.SelectedIndex = -1;
                    cuiComboBox2.SelectedItem = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías de gasto: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarPresupuestosAsync()
        {
            if (_cargandoPresupuestos || IsDisposed || Disposing)
                return;

            _cargandoPresupuestos = true;

            try
            {
                byte mes = (byte)numericUpDown2.Value;

                if (!short.TryParse(comboBoxAnios.SelectedItem?.ToString(), out short anio))
                {
                    anio = (short)DateTime.Now.Year;
                }

                // Primero obtenemos los datos
                var lista = await _presupuestoBLL.ObtenerPorPeriodoAsync(
                    _usuarioIdLogueado, mes, anio);

                // Comprobar que el formulario sigue existiendo
                if (IsDisposed || Disposing || flpTarjetas.IsDisposed)
                    return;

                flpTarjetas.SuspendLayout();

                try
                {
                    // Eliminar las tarjetas anteriores
                    var controlesAnteriores = flpTarjetas.Controls
                        .Cast<Control>()
                        .ToList();

                    flpTarjetas.Controls.Clear();

                    foreach (var ctrl in controlesAnteriores)
                    {
                        ctrl.Dispose();
                    }

                    if (lista == null || lista.Count == 0)
                    {
                        Label lblVacio = new Label
                        {
                            Text = "No hay presupuestos configurados para este período.\nPuedes crear uno usando el panel de la izquierda.",
                            Font = new Font("Segoe UI", 11F),
                            ForeColor = Color.FromArgb(100, 116, 139),
                            TextAlign = ContentAlignment.MiddleCenter,
                            AutoSize = false,
                            Size = new Size(flpTarjetas.Width - 30, 120),
                            Margin = new Padding(10, 40, 10, 10)
                        };

                        flpTarjetas.Controls.Add(lblVacio);
                    }
                    else
                    {
                        foreach (var p in lista)
                        {
                            var tarjeta = new ucTarjetaPresupuesto();

                            tarjeta.CargarDatos(p);

                            tarjeta.Click += (s, e) =>
                                SeleccionarCategoriaDesdeTarjeta(p);

                            flpTarjetas.Controls.Add(tarjeta);
                        }
                    }
                }
                finally
                {
                    flpTarjetas.ResumeLayout(true);
                }
            }
            catch (ObjectDisposedException) when (IsDisposed || Disposing)
            {
                // El formulario se cerró mientras se ejecutaba la operación.
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar presupuestos: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                _cargandoPresupuestos = false;
            }
        }

        private void SeleccionarCategoriaDesdeTarjeta(PresupuestoDTO p)
        {
            var categoria = _categoriasGasto.FirstOrDefault(c => c.Id == p.CategoriaId);
            if (categoria != null)
            {
                int idx = _categoriasGasto.IndexOf(categoria);
                cuiComboBox2.SelectedIndex = idx;
                cuiComboBox2.SelectedItem = categoria.Nombre;
                numericUpDown1.Value = p.LimiteMensual;
            }
        }

        private async void Periodo_Changed(object? sender, EventArgs e)
        {
            if (_cargando) return;
            await CargarPresupuestosAsync();
        }

        private async void btnGuardarPresupuesto_Click(object? sender, EventArgs e)
        {
            if (cuiComboBox2.SelectedIndex < 0 || cuiComboBox2.SelectedItem == null || string.IsNullOrWhiteSpace(cuiComboBox2.SelectedItem.ToString()))
            {
                MessageBox.Show("Debe seleccionar una categoría de gasto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string catNombre = cuiComboBox2.SelectedItem.ToString()!;
            var categoria = (cuiComboBox2.SelectedIndex >= 0 && cuiComboBox2.SelectedIndex < _categoriasGasto.Count)
                ? _categoriasGasto[cuiComboBox2.SelectedIndex]
                : _categoriasGasto.FirstOrDefault(c => c.Nombre == catNombre);

            if (categoria == null)
            {
                MessageBox.Show("Categoría de gasto no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal limite = numericUpDown1.Value;
            if (limite <= 0)
            {
                MessageBox.Show("El dinero mensual asignado debe ser mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDown1.Focus();
                return;
            }

            byte mes = (byte)numericUpDown2.Value;
            if (!short.TryParse(comboBoxAnios.SelectedItem?.ToString(), out short anio))
            {
                anio = (short)DateTime.Now.Year;
            }

            try
            {
                cuiButton3.Enabled = false;

                var nuevoPresupuesto = new PresupuestoEntity(
                    usuarioId: _usuarioIdLogueado,
                    categoriaId: categoria.Id,
                    mes: mes,
                    anio: anio,
                    limiteMensual: limite
                );

                await _presupuestoBLL.GuardarAsync(nuevoPresupuesto);

                MessageBox.Show("Presupuesto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                await CargarPresupuestosAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                cuiButton3.Enabled = true;
            }
        }

        private async void cuiButton4_Click(object? sender, EventArgs e)
        {
            int? categoriaIdSeleccionada = null;

            if (cuiComboBox2.SelectedIndex >= 0 && cuiComboBox2.SelectedItem != null)
            {
                string catNombre = cuiComboBox2.SelectedItem.ToString()!;
                var categoria = (cuiComboBox2.SelectedIndex >= 0 && cuiComboBox2.SelectedIndex < _categoriasGasto.Count)
                    ? _categoriasGasto[cuiComboBox2.SelectedIndex]
                    : _categoriasGasto.FirstOrDefault(c => c.Nombre == catNombre);

                if (categoria != null)
                {
                    categoriaIdSeleccionada = categoria.Id;
                }
            }

            using (var modal = new FrmAsignarGastoPresupuesto(_usuarioIdLogueado, categoriaIdSeleccionada))
            {
                if (modal.ShowDialog(this) == DialogResult.OK)
                {
                    await CargarPresupuestosAsync();
                }
            }
        }

        private void LimpiarCampos()
        {
            if (_categoriasGasto.Count > 0)
            {
                cuiComboBox2.SelectedIndex = 0;
                cuiComboBox2.SelectedItem = _categoriasGasto[0].Nombre;
            }
            else
            {
                cuiComboBox2.SelectedIndex = -1;
                cuiComboBox2.SelectedItem = "";
            }

            numericUpDown1.Value = 100M;
            cuiComboBox2.Focus();
        }
    }
}
