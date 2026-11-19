using ControlFinanzas.BLL;
using ControlFinanzas.BLL.Common;
using ControlFinanzas.Entity.ObjetosTransferenciaDatos;
using ControlFinanzas.Entity.Sesion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlFinanzas.UI.Formularios
{
    
    public partial class FrmDashboard : Form
    {
        
        private readonly DashboardBLL _dashboardBLL;

       
        private readonly int _usuarioIdLogueado;

     
        private bool _cargandoDatos = false;

        
        private PictureBox picCanvasDona = null!;
        private PictureBox picCanvasBarras = null!;

        // Modelos de datos en memoria para alimentar la interfaz y los gráficos
        private DashboardResumenDTO _resumen = new DashboardResumenDTO();
        private List<GastoPorCategoriaDTO> _gastosCategoria = new List<GastoPorCategoriaDTO>();
        private List<ComparativaMesDTO> _comparativa6Meses = new List<ComparativaMesDTO>();
        private List<PresupuestoDTO> _presupuestosRiesgo = new List<PresupuestoDTO>();
        private List<TransferenciaDashboardDTO> _ultimasTransferencias = new List<TransferenciaDashboardDTO>();

        
        public FrmDashboard()
        {
            InitializeComponent();

            _dashboardBLL = new DashboardBLL();
            _usuarioIdLogueado = SesionUsuario.UsuarioId;

            InicializarLienzosGraficas();
            ConfigurarDataGridTransferencias();
            CorregirTextosIniciales();
            SuscribirEventosFinanzas();
        }

        
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await CargarDashboardCompletoAsync();
        }

        // Se ejecuta cuando el formulario cambia de visibilidad dentro del contenedor principal
        protected override async void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (this.Visible && !this.IsDisposed && !_cargandoDatos)
            {
                await CargarDashboardCompletoAsync();
            }
        }

        // Libera suscripciones a eventos cuando el formulario se cierra
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            DesuscribirEventosFinanzas();
            base.OnFormClosed(e);
        }

        // Suscribe el dashboard a los eventos globales del sistema para actualización en tiempo real
        private void SuscribirEventosFinanzas()
        {
            EventosFinanzas.TransaccionesCambiadas += OnDatosModificados;
            EventosFinanzas.CuentasCambiadas += OnDatosModificados;
            EventosFinanzas.PresupuestosCambiados += OnDatosModificados;
            EventosFinanzas.MetasAhorroCambiadas += OnDatosModificados;
        }

        // Remueve la suscripción de eventos para prevenir fugas de memoria
        private void DesuscribirEventosFinanzas()
        {
            EventosFinanzas.TransaccionesCambiadas -= OnDatosModificados;
            EventosFinanzas.CuentasCambiadas -= OnDatosModificados;
            EventosFinanzas.PresupuestosCambiados -= OnDatosModificados;
            EventosFinanzas.MetasAhorroCambiadas -= OnDatosModificados;
        }

        // Manejador del evento cuando ocurren cambios en cuentas, transferencias o presupuestos
        private void OnDatosModificados(object? sender, EventArgs e)
        {
            if (this.IsDisposed || !this.IsHandleCreated) return;

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(async () => await CargarDashboardCompletoAsync()));
            }
            else
            {
                _ = CargarDashboardCompletoAsync();
            }
        }

        // Configura los lienzos de dibujo PictureBox dentro de cuiPanel9 y cuiPanel10
        private void InicializarLienzosGraficas()
        {
            
            if (GraficoGastoPorCategoria != null)
                GraficoGastoPorCategoria.Visible = false;

            if (GraficoIngresosvsGastos != null)
                GraficoIngresosvsGastos.Visible = false;

            
            picCanvasDona = new PictureBox
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            picCanvasDona.Paint += DibujarGraficoDona_Paint;
            cuiPanel9.Controls.Add(picCanvasDona);
            picCanvasDona.BringToFront();

         
            picCanvasBarras = new PictureBox
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            picCanvasBarras.Paint += DibujarGraficoBarras_Paint;
            cuiPanel10.Controls.Add(picCanvasBarras);
            picCanvasBarras.BringToFront();
        }

       
        private void CorregirTextosIniciales()
        {
            if (label5 != null)
                label5.Text = "Presupuestos en Riesgo";
        }

        // Configura las columnas, cabeceras y estilos visuales del DataGridView de transferencias
        private void ConfigurarDataGridTransferencias()
        {
            dgvUltimasTransferencias.Columns.Clear();
            dgvUltimasTransferencias.AutoGenerateColumns = false;

            dgvUltimasTransferencias.BorderStyle = BorderStyle.None;
            dgvUltimasTransferencias.BackgroundColor = Color.White;
            dgvUltimasTransferencias.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUltimasTransferencias.GridColor = Color.FromArgb(241, 245, 249);
            dgvUltimasTransferencias.RowHeadersVisible = false;
            dgvUltimasTransferencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUltimasTransferencias.MultiSelect = false;
            dgvUltimasTransferencias.AllowUserToAddRows = false;
            dgvUltimasTransferencias.AllowUserToDeleteRows = false;
            dgvUltimasTransferencias.AllowUserToResizeRows = false;
            dgvUltimasTransferencias.ReadOnly = true;
            dgvUltimasTransferencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvUltimasTransferencias.EnableHeadersVisualStyles = false;
            dgvUltimasTransferencias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUltimasTransferencias.ColumnHeadersHeight = 36;
            dgvUltimasTransferencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUltimasTransferencias.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            dgvUltimasTransferencias.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(51, 65, 85);
            dgvUltimasTransferencias.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvUltimasTransferencias.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvUltimasTransferencias.RowTemplate.Height = 32;
            dgvUltimasTransferencias.DefaultCellStyle.BackColor = Color.White;
            dgvUltimasTransferencias.DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvUltimasTransferencias.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            dgvUltimasTransferencias.DefaultCellStyle.SelectionBackColor = Color.FromArgb(243, 244, 246);
            dgvUltimasTransferencias.DefaultCellStyle.SelectionForeColor = Color.FromArgb(15, 23, 42);

           
            dgvUltimasTransferencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colOrigen",
                HeaderText = "Cuenta Origen",
                DataPropertyName = "CuentaOrigen",
                FillWeight = 30
            });

            dgvUltimasTransferencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDestino",
                HeaderText = "Cuenta Destino",
                DataPropertyName = "CuentaDestino",
                FillWeight = 30
            });

            dgvUltimasTransferencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMonto",
                HeaderText = "Monto",
                DataPropertyName = "MontoFormateado",
                FillWeight = 20,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleRight,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(15, 23, 42)
                }
            });

            dgvUltimasTransferencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFecha",
                HeaderText = "Fecha",
                DataPropertyName = "FechaFormateada",
                FillWeight = 20,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    ForeColor = Color.FromArgb(100, 116, 139)
                }
            });
        }

        // Carga de forma asíncrona todos los datos del dashboard desde la BLL
        public async Task CargarDashboardCompletoAsync()
        {
            if (_cargandoDatos) return;

            try
            {
                _cargandoDatos = true;

                // 1. Consultar resumen de las 4 tarjetas principales
                _resumen = await _dashboardBLL.ObtenerResumenAsync(_usuarioIdLogueado);

                // 2. Consultar desglose de gastos por categoría del mes actual
                _gastosCategoria = await _dashboardBLL.ObtenerGastosPorCategoriaAsync(_usuarioIdLogueado);

                // 3. Consultar comparativa de ingresos vs gastos de los últimos 6 meses
                _comparativa6Meses = await _dashboardBLL.ObtenerIngresosVsGastos6MesesAsync(_usuarioIdLogueado);

                // 4. Consultar los 3 presupuestos en mayor riesgo
                _presupuestosRiesgo = await _dashboardBLL.ObtenerPresupuestosEnRiesgoAsync(_usuarioIdLogueado, null, null, 3);

                // 5. Consultar las transferencias recientes
                _ultimasTransferencias = await _dashboardBLL.ObtenerUltimasTransferenciasAsync(_usuarioIdLogueado, 10);

                // Actualizar interfaz de usuario
                ActualizarTarjetasResumen();
                ActualizarPresupuestosEnRiesgo();
                ActualizarGridTransferencias();

                // Redibujar gráficos personalizados
                picCanvasDona?.Invalidate();
                picCanvasBarras?.Invalidate();
            }
            catch (Exception ex)
            {
                // Notificar en consola de depuración en caso de error
                System.Diagnostics.Debug.WriteLine("Error al actualizar el Dashboard: " + ex.Message);
            }
            finally
            {
                _cargandoDatos = false;
            }
        }

        // Asigna los montos correspondientes en las 4 tarjetas de resumen
        private void ActualizarTarjetasResumen()
        {
            CultureInfo culturaUSD = new CultureInfo("en-US");

            // Tarjeta 1: Total de patrimonio / dinero en cuentas
            lblBalanceNeto.Text = "$" + _resumen.TotalPatrimonio.ToString("N2", culturaUSD);

            // Tarjeta 2: Total dinero ingresado en el mes actual
            lblTotalDineroIngreso.Text = "+ $" + _resumen.TotalIngresosMes.ToString("N2", culturaUSD);

            // Tarjeta 3: Total de gastos del mes actual
            lblTotalDineroGasto.Text = "- $" + _resumen.TotalGastosMes.ToString("N2", culturaUSD);

            // Tarjeta 4: Total de dinero ahorrado en metas
            lblTotalDineroAhorrado.Text = "$" + _resumen.TotalAhorrado.ToString("N2", culturaUSD);
        }

        // Actualiza las 3 barras de progreso y porcentajes de los presupuestos en riesgo
        private void ActualizarPresupuestosEnRiesgo()
        {
            PresupuestoDTO? pres1 = _presupuestosRiesgo.Count > 0 ? _presupuestosRiesgo[0] : null;
            PresupuestoDTO? pres2 = _presupuestosRiesgo.Count > 1 ? _presupuestosRiesgo[1] : null;
            PresupuestoDTO? pres3 = _presupuestosRiesgo.Count > 2 ? _presupuestosRiesgo[2] : null;

            AsignarDatosBarraPresupuesto(pres1, lblNombrePresupuesto1, pnlFondoBarra1, pnlProgresoPresupuesto1, lblPorcentaje1);
            AsignarDatosBarraPresupuesto(pres2, lblNombrePresupuesto2, pnlFondoBarra2, pnlProgresoPresupuesto2, lblPorcentaje2);
            AsignarDatosBarraPresupuesto(pres3, lblNombrePresupuesto3, pnlFondoBarra3, pnlProgresoPresupuesto3, lblPorcentaje3);
        }

        // Asigna nombre, ancho de barra y color según el porcentaje de consumo de un presupuesto
        private void AsignarDatosBarraPresupuesto(PresupuestoDTO? pres, Label lblNombre, Panel pnlFondo, Panel pnlProgreso, Label lblPorcentaje)
        {
            if (pres == null)
            {
                lblNombre.Text = "Sin alertas de presupuesto";
                lblNombre.ForeColor = Color.DarkGray;
                lblPorcentaje.Text = "0%";
                lblPorcentaje.ForeColor = Color.DarkGray;
                pnlProgreso.Width = 0;
                return;
            }

            lblNombre.Text = pres.CategoriaNombre;
            lblNombre.ForeColor = Color.Black;

            decimal porcentaje = Math.Round(pres.PorcentajeConsumido, 0);
            lblPorcentaje.Text = $"{porcentaje}%";

            // Calcular ancho proporcional de la barra dentro del panel fondo
            int anchoMaximo = pnlFondo.Width;
            decimal proporcion = Math.Min(porcentaje, 100m) / 100m;
            int nuevoAncho = (int)(anchoMaximo * proporcion);
            pnlProgreso.Width = Math.Max(nuevoAncho, 6);

            // Determinar color de riesgo: Rojo para >= 90%, Naranja para >= 80%, Ámbar para menores
            Color colorRiesgo;
            if (porcentaje >= 90m)
            {
                colorRiesgo = Color.FromArgb(239, 68, 68); // Rojo peligro
            }
            else if (porcentaje >= 80m)
            {
                colorRiesgo = Color.FromArgb(245, 158, 11); // Naranja advertencia
            }
            else
            {
                colorRiesgo = Color.FromArgb(234, 179, 8); // Ámbar preventivo
            }

            pnlProgreso.BackColor = colorRiesgo;
            lblPorcentaje.ForeColor = colorRiesgo;
        }

        // Llena el DataGridView con las transferencias obtenidas
        private void ActualizarGridTransferencias()
        {
            dgvUltimasTransferencias.Rows.Clear();
            CultureInfo culturaUSD = new CultureInfo("en-US");

            foreach (var t in _ultimasTransferencias)
            {
                dgvUltimasTransferencias.Rows.Add(
                    t.CuentaOrigen,
                    t.CuentaDestino,
                    "$" + t.Monto.ToString("N2", culturaUSD),
                    t.Fecha.ToString("dd/MM/yyyy")
                );
            }
        }

        // Dibuja la gráfica de pastel/dona de gastos por categoría en picCanvasDona
        private void DibujarGraficoDona_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            // Título de la gráfica
            using Font fontTitulo = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            using Brush brushTitulo = new SolidBrush(Color.FromArgb(15, 23, 42));
            g.DrawString("Gastos por Categoría", fontTitulo, brushTitulo, 16, 14);

            // Paleta de colores modernos si no vienen definidos desde la base de datos
            Color[] paletaColores = new Color[]
            {
                Color.FromArgb(74, 222, 128),  // Verde claro (Comida)
                Color.FromArgb(236, 72, 153),  // Rosa/Magenta (Compras)
                Color.FromArgb(239, 68, 68),   // Rojo (Regalos)
                Color.FromArgb(37, 99, 235),   // Azul (Transporte)
                Color.FromArgb(245, 158, 11),  // Naranja (Otros)
                Color.FromArgb(139, 92, 246),  // Púrpura
                Color.FromArgb(20, 184, 166)   // Turquesa
            };

            // Dimensiones del anillo de la dona
            int diametroExterior = 170;
            int posX = 30;
            int posY = 65;
            Rectangle rectExterior = new Rectangle(posX, posY, diametroExterior, diametroExterior);

            int diametroInterior = 106;
            int huecoX = posX + (diametroExterior - diametroInterior) / 2;
            int huecoY = posY + (diametroExterior - diametroInterior) / 2;
            Rectangle rectHueco = new Rectangle(huecoX, huecoY, diametroInterior, diametroInterior);

            // Si no hay gastos en el mes, dibujar dona vacía neutra
            if (_gastosCategoria == null || _gastosCategoria.Count == 0 || _gastosCategoria.Sum(x => x.TotalGasto) == 0)
            {
                using (Brush brushVacio = new SolidBrush(Color.FromArgb(241, 245, 249)))
                {
                    g.FillEllipse(brushVacio, rectExterior);
                }

                using (Brush brushHueco = new SolidBrush(Color.White))
                {
                    g.FillEllipse(brushHueco, rectHueco);
                }

                using Font fontVacio = new Font("Segoe UI", 9.5F, FontStyle.Regular);
                using Brush brushVacioTexto = new SolidBrush(Color.FromArgb(148, 163, 184));
                StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString("Sin gastos\nen el mes", fontVacio, brushVacioTexto, new RectangleF(huecoX, huecoY, diametroInterior, diametroInterior), sf);
                return;
            }

            // Calcular monto total de los gastos representados
            decimal totalGastado = _gastosCategoria.Sum(x => x.TotalGasto);

            // Agrupar categorías principales (máximo 5) y agrupar el resto en "Otros"
            var categoriasMostradas = new List<GastoPorCategoriaDTO>();
            if (_gastosCategoria.Count <= 5)
            {
                categoriasMostradas = _gastosCategoria.ToList();
            }
            else
            {
                categoriasMostradas = _gastosCategoria.Take(4).ToList();
                decimal totalRestante = _gastosCategoria.Skip(4).Sum(x => x.TotalGasto);
                decimal pctRestante = _gastosCategoria.Skip(4).Sum(x => x.Porcentaje);
                categoriasMostradas.Add(new GastoPorCategoriaDTO
                {
                    Categoria = "Otros",
                    ColorHex = "#F59E0B",
                    TotalGasto = totalRestante,
                    Porcentaje = pctRestante
                });
            }

            // 1. Dibujar los arcos de cada categoría con separación blanca
            float anguloActual = -90f;
            using Pen penSeparador = new Pen(Color.White, 3);

            for (int i = 0; i < categoriasMostradas.Count; i++)
            {
                var item = categoriasMostradas[i];
                float barrido = (float)(item.Porcentaje / 100m) * 360f;
                if (barrido <= 0) continue;

                // Color de la rebanada
                Color colorRebanada = paletaColores[i % paletaColores.Length];
                if (!string.IsNullOrWhiteSpace(item.ColorHex) && item.ColorHex.StartsWith("#") && item.ColorHex.Length == 7 && item.ColorHex != "#808080")
                {
                    try { colorRebanada = ColorTranslator.FromHtml(item.ColorHex); } catch { }
                }

                using (Brush brushRebanada = new SolidBrush(colorRebanada))
                {
                    g.FillPie(brushRebanada, rectExterior, anguloActual, barrido);
                }

                // Línea divisoria blanca para dar estilo limpio entre segmentos
                g.DrawPie(penSeparador, rectExterior, anguloActual, barrido);

                anguloActual += barrido;
            }

            // 2. Dibujar el hueco central para convertirlo en dona
            using (Brush brushCentro = new SolidBrush(Color.White))
            {
                g.FillEllipse(brushCentro, rectHueco);
            }

            // 3. Dibujar el texto central "Total" y el monto gastado
            float centroX = posX + diametroExterior / 2f;
            float centroY = posY + diametroExterior / 2f;

            using Font fontTotalLabel = new Font("Segoe UI", 9F, FontStyle.Regular);
            using Brush brushTotalLabel = new SolidBrush(Color.FromArgb(100, 116, 139));
            StringFormat sfCentro = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };

            g.DrawString("Total", fontTotalLabel, brushTotalLabel, centroX, centroY - 14, sfCentro);

            using Font fontTotalMonto = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            using Brush brushTotalMonto = new SolidBrush(Color.FromArgb(15, 23, 42));
            CultureInfo culturaUSD = new CultureInfo("en-US");
            g.DrawString("$" + totalGastado.ToString("N2", culturaUSD), fontTotalMonto, brushTotalMonto, centroX, centroY + 8, sfCentro);

            // 4. Dibujar la leyenda de categorías y porcentajes a la derecha
            int leyendaX = 225;
            int leyendaY = 65;
            int espacioFila = 34;

            using Font fontNombreCat = new Font("Segoe UI", 10F, FontStyle.Regular);
            using Brush brushNombreCat = new SolidBrush(Color.FromArgb(30, 41, 59));
            using Font fontPorcentaje = new Font("Segoe UI", 10.5F, FontStyle.Bold);

            for (int i = 0; i < categoriasMostradas.Count; i++)
            {
                var item = categoriasMostradas[i];
                int filaY = leyendaY + (i * espacioFila);

                Color colorCat = paletaColores[i % paletaColores.Length];
                if (!string.IsNullOrWhiteSpace(item.ColorHex) && item.ColorHex.StartsWith("#") && item.ColorHex.Length == 7 && item.ColorHex != "#808080")
                {
                    try { colorCat = ColorTranslator.FromHtml(item.ColorHex); } catch { }
                }

                // Círculo de color identificador
                using (Brush brushCirculo = new SolidBrush(colorCat))
                {
                    g.FillEllipse(brushCirculo, leyendaX, filaY + 5, 11, 11);
                }

                // Nombre de la categoría
                string nombreRecortado = item.Categoria.Length > 15 ? item.Categoria.Substring(0, 13) + ".." : item.Categoria;
                g.DrawString(nombreRecortado, fontNombreCat, brushNombreCat, leyendaX + 18, filaY + 1);

                // Porcentaje a la derecha
                using (Brush brushPct = new SolidBrush(Color.FromArgb(30, 41, 59)))
                {
                    StringFormat sfDer = new StringFormat { Alignment = StringAlignment.Far };
                    g.DrawString($"{item.Porcentaje:0}%", fontPorcentaje, brushPct, picCanvasDona.Width - 25, filaY + 1, sfDer);
                }
            }
        }

        // Dibuja la gráfica comparativa de barras (Ingresos vs Gastos) en picCanvasBarras
        private void DibujarGraficoBarras_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            // Título de la gráfica
            using Font fontTitulo = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            using Brush brushTitulo = new SolidBrush(Color.FromArgb(15, 23, 42));
            g.DrawString("Ingresos vs Gastos (Últimos 6 Meses)", fontTitulo, brushTitulo, 16, 14);

            // Leyenda en la parte superior derecha
            using Font fontLeyenda = new Font("Segoe UI", 9F, FontStyle.Regular);
            using Brush brushTextoLeyenda = new SolidBrush(Color.FromArgb(100, 116, 139));

            // Indicador Ingresos (Verde)
            using (Brush brushIngreso = new SolidBrush(Color.FromArgb(0, 196, 140)))
            {
                g.FillEllipse(brushIngreso, picCanvasBarras.Width - 190, 19, 9, 9);
            }
            g.DrawString("Ingresos", fontLeyenda, brushTextoLeyenda, picCanvasBarras.Width - 176, 15);

            // Indicador Gastos (Rojo)
            using (Brush brushGasto = new SolidBrush(Color.FromArgb(239, 68, 68)))
            {
                g.FillEllipse(brushGasto, picCanvasBarras.Width - 100, 19, 9, 9);
            }
            g.DrawString("Gastos", fontLeyenda, brushTextoLeyenda, picCanvasBarras.Width - 86, 15);

            // Área de trazado del gráfico
            int margenIzq = 50;
            int margenDer = picCanvasBarras.Width - 20;
            int margenSup = 55;
            int margenInf = picCanvasBarras.Height - 45;

            int anchoGrafico = margenDer - margenIzq;
            int altoGrafico = margenInf - margenSup;

            // Calcular el valor máximo para la escala del eje Y
            decimal maximoValor = 1000m;
            if (_comparativa6Meses != null && _comparativa6Meses.Count > 0)
            {
                decimal maxIng = _comparativa6Meses.Max(x => x.TotalIngresos);
                decimal maxGas = _comparativa6Meses.Max(x => x.TotalGastos);
                maximoValor = Math.Max(maxIng, maxGas);
            }

            if (maximoValor <= 0) maximoValor = 1000m;

            // Redondear a un múltiplo limpio (ej. 2000, 4000, 6000, 8000)
            decimal paso = 1000m;
            decimal sugerido = maximoValor / 4m;
            if (sugerido <= 500m) paso = 500m;
            else if (sugerido <= 1000m) paso = 1000m;
            else if (sugerido <= 2000m) paso = 2000m;
            else if (sugerido <= 5000m) paso = 5000m;
            else paso = Math.Ceiling(sugerido / 1000m) * 1000m;

            decimal escalaMax = paso * 4m;

            // 1. Dibujar líneas guía horizontales y etiquetas del eje Y
            using Pen penGuia = new Pen(Color.FromArgb(241, 245, 249), 1);
            using Font fontEjeY = new Font("Segoe UI", 8.5F, FontStyle.Regular);
            using Brush brushEjeY = new SolidBrush(Color.FromArgb(148, 163, 184));
            StringFormat sfDerY = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center };

            for (int nivel = 0; nivel <= 4; nivel++)
            {
                decimal valorLinea = nivel * paso;
                int yLinea = margenInf - (int)((valorLinea / escalaMax) * altoGrafico);

                g.DrawLine(penGuia, margenIzq, yLinea, margenDer, yLinea);
                g.DrawString(valorLinea.ToString("N0"), fontEjeY, brushEjeY, margenIzq - 8, yLinea, sfDerY);
            }

            // Línea base inferior
            using Pen penBase = new Pen(Color.FromArgb(226, 232, 240), 1);
            g.DrawLine(penBase, margenIzq, margenInf, margenDer, margenInf);

            if (_comparativa6Meses == null || _comparativa6Meses.Count == 0) return;

            // 2. Dibujar las barras agrupadas de cada uno de los 6 meses
            int cantidadMeses = _comparativa6Meses.Count;
            float anchoColumna = (float)anchoGrafico / cantidadMeses;
            float anchoBarra = 18f;
            float separacionBarras = 4f;

            using Brush brushVerdeIngreso = new SolidBrush(Color.FromArgb(0, 196, 140));
            using Brush brushRojoGasto = new SolidBrush(Color.FromArgb(239, 68, 68));
            using Font fontMes = new Font("Segoe UI", 9F, FontStyle.Regular);
            using Brush brushMes = new SolidBrush(Color.FromArgb(100, 116, 139));
            StringFormat sfCentroX = new StringFormat { Alignment = StringAlignment.Center };

            for (int i = 0; i < cantidadMeses; i++)
            {
                var mesItem = _comparativa6Meses[i];
                float centroGrupoX = margenIzq + (i * anchoColumna) + (anchoColumna / 2f);

                float barraIngresoX = centroGrupoX - anchoBarra - (separacionBarras / 2f);
                float barraGastoX = centroGrupoX + (separacionBarras / 2f);

                // Calcular altura de la barra de ingresos
                float altoIngreso = (float)(mesItem.TotalIngresos / escalaMax) * altoGrafico;
                if (altoIngreso < 2f && mesItem.TotalIngresos > 0) altoIngreso = 2f;
                float yIngreso = margenInf - altoIngreso;

                // Calcular altura de la barra de gastos
                float altoGasto = (float)(mesItem.TotalGastos / escalaMax) * altoGrafico;
                if (altoGasto < 2f && mesItem.TotalGastos > 0) altoGasto = 2f;
                float yGasto = margenInf - altoGasto;

                // Dibujar barra verde de ingresos con esquinas superiores redondeadas
                DibujarBarraRedondeada(g, brushVerdeIngreso, barraIngresoX, yIngreso, anchoBarra, altoIngreso, 4f);

                // Dibujar barra roja de gastos con esquinas superiores redondeadas
                DibujarBarraRedondeada(g, brushRojoGasto, barraGastoX, yGasto, anchoBarra, altoGasto, 4f);

                // Etiqueta del mes bajo la línea base
                g.DrawString(mesItem.NombreMes, fontMes, brushMes, centroGrupoX, margenInf + 8, sfCentroX);
            }
        }

        // Dibuja un rectángulo con las esquinas superiores suavemente redondeadas
        private void DibujarBarraRedondeada(Graphics g, Brush brush, float x, float y, float width, float height, float radius)
        {
            if (height <= 0 || width <= 0) return;

            if (height < radius * 2)
            {
                g.FillRectangle(brush, x, y, width, height);
                return;
            }

            using GraphicsPath path = new GraphicsPath();
            path.AddArc(x, y, radius * 2, radius * 2, 180, 90);
            path.AddArc(x + width - (radius * 2), y, radius * 2, radius * 2, 270, 90);
            path.AddLine(x + width, y + radius, x + width, y + height);
            path.AddLine(x + width, y + height, x, y + height);
            path.CloseFigure();

            g.FillPath(brush, path);
        }
    }
}
