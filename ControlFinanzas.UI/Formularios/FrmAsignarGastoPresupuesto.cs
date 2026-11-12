using ControlFinanzas.BLL;
using ControlFinanzas.BLL.Servicios;
using ControlFinanzas.DAL;
using ControlFinanzas.Entity.Sesion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
        private List<ControlFinanzas.Entity.Entidades.Cuenta> _cuentasActivas = new();
        private List<ControlFinanzas.Entity.Entidades.CategoriaEntity> _categoriasActivas = new();



        public FrmAsignarGastoPresupuesto(int usuarioId, int? categoriaIdPreseleccionada = null)
        {
            InitializeComponent();
            _usuarioId = usuarioId;
            _categoriaIdPreseleccionada = categoriaIdPreseleccionada;

            _categoriaBll = new CategoriaBLL();
            _cuentaBll = new CuentaBLL();
            _transaccionesBll = new TransaccionBLL(new TransaccionesDAL());
        }

        private async void FrmAsignarGastoPresupuesto_Load(object sender, EventArgs e)
        {
            await CargarListaAsync();
        }

        private async Task CargarListaAsync()
        {
            try
            {
                // 1. Cargar categorías de tipo Gasto filtradas por usuario
                var categorias = await _categoriaBll.ObtenerConFiltroAsync(_usuarioId, null, "Gasto");
                _categoriasActivas = categorias.Where(c => c.Estado).ToList();

                List<string> nombresCategorias = new List<string>();
                foreach (var categoria in _categoriasActivas)
                {
                    nombresCategorias.Add(categoria.Nombre);
                }

                cmbCategoriaGasto.Items = nombresCategorias.ToArray();

                // Preseleccionar categoría si se pasó una
                if (_categoriaIdPreseleccionada.HasValue && _categoriasActivas.Count > 0)
                {
                    var categoriaPresel = _categoriasActivas.FirstOrDefault(c => c.Id == _categoriaIdPreseleccionada.Value);
                    if (categoriaPresel != null)
                        cmbCategoriaGasto.SelectedItem = categoriaPresel.Nombre;
                }

                // 2. Cargar cuentas activas del usuario en cmbCuentaOrigen
                var cuentas = await Task.Run(() => _cuentaBll.ObtenerTodas());
                _cuentasActivas = cuentas.Where(c => c.Estado).ToList();

                List<string> nombresCuentas = new List<string>();
                foreach (var cuenta in _cuentasActivas)
                {
                    nombresCuentas.Add(cuenta.Nombre);
                }

                cmbCuentaOrigen.Items = nombresCuentas.ToArray();

                if (_cuentasActivas.Count > 0)
                    cmbCuentaOrigen.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Indica al formulario padre que la operación fue cancelada
            this.DialogResult = DialogResult.Cancel;

            // Destruye el formulario modal liberando la memoria
            this.Close();
        }

        private async void btnConfirmarTransferencia_Click(object sender, EventArgs e)
        {
            try
            {
                // ── 1. Validar selección de cuenta ──────────────────────────────
                if (cmbCuentaOrigen.SelectedIndex < 0 || string.IsNullOrWhiteSpace(cmbCuentaOrigen.SelectedItem))
                {
                    MessageBox.Show("Debes seleccionar una cuenta de origen.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ── 2. Validar selección de categoría ───────────────────────────
                if (cmbCategoriaGasto.SelectedIndex < 0 || string.IsNullOrWhiteSpace(cmbCategoriaGasto.SelectedItem))
                {
                    MessageBox.Show("Debes seleccionar una categoría de gasto.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ── 3. Validar monto ────────────────────────────────────────────
                decimal monto = nudDineroATransferir.Value;
                if (monto <= 0)
                {
                    MessageBox.Show("El monto a gastar debe ser mayor a cero.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ── 4. Obtener los IDs reales desde las listas en memoria ───────
                string nombreCuenta = cmbCuentaOrigen.SelectedItem;
                var cuentaSeleccionada = _cuentasActivas.FirstOrDefault(c => c.Nombre == nombreCuenta);
                if (cuentaSeleccionada == null)
                {
                    MessageBox.Show("No se pudo encontrar la cuenta seleccionada.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string nombreCategoria = cmbCategoriaGasto.SelectedItem;
                var categoriaSeleccionada = _categoriasActivas.FirstOrDefault(c => c.Nombre == nombreCategoria);
                if (categoriaSeleccionada == null)
                {
                    MessageBox.Show("No se pudo encontrar la categoría seleccionada.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ── 5. Construir la entidad de transacción ──────────────────────
                var gasto = new ControlFinanzas.Entity.Entidades.TransaccionesEntity(
                    cuentaId: cuentaSeleccionada.Id,
                    categoriaId: categoriaSeleccionada.Id,
                    tipoTransaccion: "Gasto",
                    monto: monto,
                    fecha: DateTime.Now,
                    descripcion: $"Gasto de presupuesto — {nombreCategoria}"
                );

                // ── 6. Deshabilitar el botón para evitar doble clic ─────────────
                btnConfirmarTransferencia.Enabled = false;

                // ── 7. Persistir via BLL ────────────────────────────────────────
                await _transaccionesBll.AgregarAsync(_usuarioId, gasto);

                // ── 8. Cerrar el modal con éxito ────────────────────────────────
                MessageBox.Show("¡Gasto registrado correctamente!", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el gasto: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Re-habilitar el botón si algo falló para que el usuario pueda reintentar
                btnConfirmarTransferencia.Enabled = true;
            }
        }
    }
}
