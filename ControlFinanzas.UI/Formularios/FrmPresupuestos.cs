using ControlFinanzas.BLL;
using ControlFinanzas.DAL;
using ControlFinanzas.Entity.Entidades;
using ControlFinanzas.Entity.Sesion;
using ControlFinanzas.UI.Controles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ControlFinanzas.UI.Formularios
{
    public partial class FrmPresupuestos : Form
    {
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
            _usuarioIdLogueado = SesionUsuario.UsuarioId;

            InicializarPeriodo();
            ConectarEventos();
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
                (anioActual - 1).ToString(),
                anioActual.ToString(),
                (anioActual + 1).ToString()
            };
            comboBoxAnios.SelectedItem = anioActual.ToString();

            numericUpDown2.Minimum = 1;
            numericUpDown2.Maximum = 12;
            numericUpDown2.Value = mesActual;

            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 1000000;
            numericUpDown1.Value = 100;

            _cargando = false;
        }

        private void ConectarEventos()
        {
            this.Load += FrmPresupuestos_Load;
            cuiButton3.Click += btnGuardarPresupuesto_Click;
            numericUpDown2.ValueChanged += Periodo_Changed;
            comboBoxAnios.SelectedIndexChanged += Periodo_Changed;
        }

        private async Task CargarCategoriasGastoAsync()
        {
            try
            {
                var todas = await _categoriaBLL.ObtenerConFiltroAsync(_usuarioIdLogueado, null, "Gasto");

                // Prevención del NullReferenceException validando que 'todas' haya traído datos
                if (todas != null)
                {
                    _categoriasGasto = todas.Where(c => c.Estado).ToList();
                }
                else
                {
                    _categoriasGasto = new List<CategoriaEntity>(); // Evitar fallos posteriores
                }

                List<string> nombres = _categoriasGasto.Select(c => c.Nombre).ToList();

                // Limpiamos los ítems previos antes de asignar los nuevos
                cuiComboBox2.Items = new string[0];

                if (nombres.Count > 0)
                {
                    cuiComboBox2.Items = nombres.ToArray();
                    cuiComboBox2.SelectedIndex = 0;
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
            if (_cargando) return;

            try
            {
                byte mes = (byte)numericUpDown2.Value;
                short anio = short.Parse(comboBoxAnios.SelectedItem?.ToString() ?? DateTime.Now.Year.ToString());

                flpTarjetas.SuspendLayout();
                flpTarjetas.Controls.Clear();

                var lista = await _presupuestoBLL.ObtenerPorPeriodoAsync(_usuarioIdLogueado, mes, anio);

                foreach (var p in lista)
                {
                    var tarjeta = new ucTarjetaPresupuesto();
                    tarjeta.CargarDatos(p);
                    flpTarjetas.Controls.Add(tarjeta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar presupuestos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                flpTarjetas.ResumeLayout();
            }
        }

        private async void Periodo_Changed(object? sender, EventArgs e)
        {
            await CargarPresupuestosAsync();
        }

        private async void btnGuardarPresupuesto_Click(object? sender, EventArgs e)
        {
            if (cuiComboBox2.SelectedIndex < 0 || cuiComboBox2.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una categoría de gasto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string catNombre = cuiComboBox2.SelectedItem.ToString()!;
            var categoria = _categoriasGasto.FirstOrDefault(c => c.Nombre == catNombre);
            if (categoria == null)
            {
                MessageBox.Show("Categoría no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal limite = numericUpDown1.Value;
            byte mes = (byte)numericUpDown2.Value;
            short anio = short.Parse(comboBoxAnios.SelectedItem?.ToString() ?? DateTime.Now.Year.ToString());

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
                await CargarPresupuestosAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                cuiButton3.Enabled = true;
            }
        }

        private  async void cuiButton4_Click(object sender, EventArgs e)
        {
            int? categoriaIdSeleccionada = null;

            // Si hay una categoría seleccionada en el combo principal, buscamos su ID
            if (cuiComboBox2.SelectedIndex >= 0 && cuiComboBox2.SelectedItem != null)
            {
                string catNombre = cuiComboBox2.SelectedItem.ToString()!;
                var categoria = _categoriasGasto.FirstOrDefault(c => c.Nombre == catNombre);
                if (categoria != null)
                {
                    categoriaIdSeleccionada = categoria.Id;
                }
            }

            // Instanciamos el modal pasándole el UsuarioId y el CategoriaId opcional
            using (var modal = new FrmAsignarGastoPresupuesto(_usuarioIdLogueado, categoriaIdSeleccionada))
            {
                // Abrimos el modal. Si el usuario confirma y guarda, devuelve DialogResult.OK
                if (modal.ShowDialog(this) == DialogResult.OK)
                {
                    // Recargamos las tarjetas de presupuesto para reflejar el nuevo gasto
                    await CargarPresupuestosAsync();
                }
            }
        }
    }
}
