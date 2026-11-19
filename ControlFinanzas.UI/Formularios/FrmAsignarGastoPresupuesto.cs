using ControlFinanzas.BLL;
using ControlFinanzas.DAL;
using ControlFinanzas.Entity.Sesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlFinanzas.UI.Formularios
{
    public partial class FrmAsignarGastoPresupuesto : Form
    {
        private readonly int _usuarioId;
        private readonly int? _categoriaIdPreseleccionada;
        private readonly CategoriaBLL _categoriaBll;
        private readonly CuentaBLL _cuentaBll;
        private readonly TransaccionBLL _transaccionesBll;

        // Listas cargadas al iniciar el formulario
        private List<ControlFinanzas.Entity.Entidades.CuentaEntity> _cuentasActivas = new();
        private List<ControlFinanzas.Entity.Entidades.CategoriaEntity> _categoriasActivas = new();

        public FrmAsignarGastoPresupuesto(int usuarioId, int? categoriaIdPreseleccionada = null)
        {
            InitializeComponent();

            _usuarioId = usuarioId > 0 ? usuarioId : (SesionUsuario.HaySesionActiva ? SesionUsuario.UsuarioId : 0);
            _categoriaIdPreseleccionada = categoriaIdPreseleccionada;
            _categoriaBll = new CategoriaBLL();
            _cuentaBll = new CuentaBLL();
            _transaccionesBll = new TransaccionBLL(new TransaccionesDAL());
            ConfigurarControles();
        }

        private async void FrmAsignarGastoPresupuesto_Load(object sender, EventArgs e)
        {
            await CargarListaAsync();
        }


        #region Mis Metodos

        private async Task CargarListaAsync()
        {
            try
            {
                // Cargar categorías de tipo Gasto
                var categorias = await _categoriaBll.ObtenerConFiltroAsync(
                    _usuarioId, null, "Gasto");

                // Comprobar que el formulario sigue existiendo
                if (IsDisposed || Disposing)
                    return;

                _categoriasActivas = (categorias != null)
                    ? categorias.Where(c => c.Estado).ToList()
                    : new List<ControlFinanzas.Entity.Entidades.CategoriaEntity>();

                List<string> nombresCategorias = _categoriasActivas
                    .Select(c => c.Nombre)
                    .ToList();

                cmbCategoriaGasto.Items.Clear();

                cmbCategoriaGasto.Items.AddRange(
                    nombresCategorias.ToArray()
                );

                if (_categoriasActivas.Count == 0)
                {
                    cmbCategoriaGasto.SelectedIndex = -1;

                    MessageBox.Show(
                        "No se encontraron categorías de tipo 'Gasto' activas. Por favor, crea una en el módulo de Categorías.",
                        "Sin Categorías",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    // Preseleccionar categoría si se pasó una
                    var categoriaPresel = _categoriaIdPreseleccionada.HasValue
                        ? _categoriasActivas.FirstOrDefault(
                            c => c.Id == _categoriaIdPreseleccionada.Value)
                        : null;

                    if (categoriaPresel != null)
                    {
                        int idx = _categoriasActivas.IndexOf(categoriaPresel);
                        cmbCategoriaGasto.SelectedIndex = idx;
                    }
                    else
                    {
                        cmbCategoriaGasto.SelectedIndex = 0;
                    }
                }

                // Cargar cuentas activas
                var cuentas = await Task.Run(
                    () => _cuentaBll.ObtenerTodas());

                // Comprobar que el formulario sigue existiendo
                if (IsDisposed || Disposing)
                    return;

                _cuentasActivas = (cuentas != null)
                    ? cuentas.Where(c => c.Estado).ToList()
                    : new List<ControlFinanzas.Entity.Entidades.CuentaEntity>();

                // Cargar nombres en el ComboBox
                List<string> nombresCuentas = _cuentasActivas
                    .Select(c => c.Nombre)
                    .ToList();

                cmbCuentaOrigen.Items.Clear();

                cmbCuentaOrigen.Items.AddRange(
                    nombresCuentas.ToArray()
                );

                if (_cuentasActivas.Count == 0)
                {
                    cmbCuentaOrigen.SelectedIndex = -1;

                    MessageBox.Show(
                        "No se encontraron cuentas activas registradas. Por favor, crea una cuenta en el módulo de Cuentas.",
                        "Sin Cuentas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    cmbCuentaOrigen.SelectedIndex = 0;
                }

                //Dar foco al monto
                nudDineroATransferir.Focus();
                nudDineroATransferir.Select(
                    0, nudDineroATransferir.Text.Length);
            }
            catch (ObjectDisposedException) when (IsDisposed || Disposing)
            {
                // El formulario fue cerrado durante la carga.
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar datos: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ConfigurarControles()
        {
            // Configurar NumericUpDown para que acepte cualquier monto sin toparse en 100
            nudDineroATransferir.Minimum = 0;
            nudDineroATransferir.Maximum = 100000000M;
            nudDineroATransferir.DecimalPlaces = 2;
            nudDineroATransferir.ThousandsSeparator = true;
            nudDineroATransferir.Increment = 10M;
            nudDineroATransferir.Value = 0M;

            // Seleccionar todo el texto al recibir el foco para facilitar edición
            nudDineroATransferir.Enter += (s, e) =>
            {
                nudDineroATransferir.Select(0, nudDineroATransferir.Text.Length);
            };
        }

        #endregion



        #region Metodos de Botones

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void btnConfirmarTransferencia_Click(object sender, EventArgs e)
        {
            try
            {
                //Validar selección de cuenta
                if (cmbCuentaOrigen.SelectedIndex < 0 || cmbCuentaOrigen.SelectedItem == null || string.IsNullOrWhiteSpace(cmbCuentaOrigen.SelectedItem.ToString()))
                {
                    MessageBox.Show("Debes seleccionar una cuenta de origen válida.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar selección de categoría 
                if (cmbCategoriaGasto.SelectedIndex < 0 || cmbCategoriaGasto.SelectedItem == null || string.IsNullOrWhiteSpace(cmbCategoriaGasto.SelectedItem.ToString()))
                {
                    MessageBox.Show("Debes seleccionar una categoría de gasto válida.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar monto
                decimal monto = nudDineroATransferir.Value;
                if (monto <= 0)
                {
                    MessageBox.Show("El monto a gastar debe ser mayor a cero.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nudDineroATransferir.Focus();
                    return;
                }

                // Obtener los IDs reales desde las listas en memoria 
                string nombreCuenta = cmbCuentaOrigen.SelectedItem.ToString()!;
                var cuentaSeleccionada = (cmbCuentaOrigen.SelectedIndex >= 0 && cmbCuentaOrigen.SelectedIndex < _cuentasActivas.Count)
                    ? _cuentasActivas[cmbCuentaOrigen.SelectedIndex]
                    : _cuentasActivas.FirstOrDefault(c => c.Nombre == nombreCuenta);

                if (cuentaSeleccionada == null)
                {
                    MessageBox.Show("No se pudo encontrar la cuenta seleccionada.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string nombreCategoria = cmbCategoriaGasto.SelectedItem.ToString()!;
                var categoriaSeleccionada = (cmbCategoriaGasto.SelectedIndex >= 0 && cmbCategoriaGasto.SelectedIndex < _categoriasActivas.Count)
                    ? _categoriasActivas[cmbCategoriaGasto.SelectedIndex]
                    : _categoriasActivas.FirstOrDefault(c => c.Nombre == nombreCategoria);

                if (categoriaSeleccionada == null)
                {
                    MessageBox.Show("No se pudo encontrar la categoría seleccionada.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Deshabilitar botón para evitar doble clic
                btnConfirmarTransferencia.Enabled = false;

                // Construir la entidad de transacción 
                var gasto = new ControlFinanzas.Entity.Entidades.TransaccionesEntity(
                    cuentaId: cuentaSeleccionada.Id,
                    categoriaId: categoriaSeleccionada.Id,
                    tipoTransaccion: "Gasto",
                    monto: monto,
                    fecha: DateTime.Now,
                    descripcion: $"Gasto de presupuesto — {categoriaSeleccionada.Nombre}"
                );

                // Persistir via BLL
                await _transaccionesBll.AgregarAsync(_usuarioId, gasto);

                // Cerrar el modal con éxito 
                MessageBox.Show($"¡Gasto de {monto:C2} registrado y aplicado al presupuesto correctamente!",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el gasto: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (!IsDisposed && !Disposing &&
                    !btnConfirmarTransferencia.IsDisposed)
                {
                    btnConfirmarTransferencia.Enabled = true;
                }
            }
        }

        #endregion

    }
}
