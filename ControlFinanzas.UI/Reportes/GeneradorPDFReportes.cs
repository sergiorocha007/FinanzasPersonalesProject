using ControlFinanzas.Entity.ObjetosTransferenciaDatos;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;

namespace ControlFinanzas.UI.Reportes
{
    // Clase encargada de generar los tres reportes en formato PDF usando QuestPDF
    // Cada método crea un documento completo y lo guarda en la ruta indicada
    public static class GeneradorPDFReportes
    {
        // --- Colores corporativos usados en todos los reportes ---
        private static readonly string ColorVerde       = "#16A34A";
        private static readonly string ColorRojo        = "#DC2626";
        private static readonly string ColorAzul        = "#1D4ED8";
        private static readonly string ColorGrisClaro   = "#F1F5F9";
        private static readonly string ColorGrisMedio   = "#94A3B8";
        private static readonly string ColorTexto       = "#1E293B";
        private static readonly string ColorBlancoZebra = "#FFFFFF";
        private static readonly string ColorFilaAlterna = "#F8FAFC";

        // Convierte un string hexadecimal (#RRGGBB) a un objeto Color de QuestPDF
        private static QuestPDF.Infrastructure.Color HexColor(string hex)
        {
            hex = hex.TrimStart('#');
            int r = Convert.ToInt32(hex.Substring(0, 2), 16);
            int g = Convert.ToInt32(hex.Substring(2, 2), 16);
            int b = Convert.ToInt32(hex.Substring(4, 2), 16);
            return QuestPDF.Infrastructure.Color.FromRGB((byte)r, (byte)g, (byte)b);
        }

        // Dibuja el encabezado común a todos los reportes:
        // logo textual, título del reporte, periodo y usuario que lo generó
        private static void DibujarEncabezado(
            IContainer header,
            string tituloReporte,
            string periodo,
            string nombreUsuario)
        {
            header.Column(col =>
            {
                // Barra superior de color corporativo azul
                col.Item().Height(6).Background(HexColor(ColorAzul));

                col.Item().Padding(16).Row(row =>
                {
                    // Lado izquierdo: nombre de la app y título del reporte
                    row.RelativeItem().Column(c =>
                    {
                        c.Item()
                         .Text("💰 Control de Finanzas Personales")
                         .Bold()
                         .FontSize(14)
                         .FontColor(HexColor(ColorAzul));

                        c.Item()
                         .Text(tituloReporte)
                         .FontSize(11)
                         .FontColor(HexColor(ColorTexto));
                    });

                    // Lado derecho: periodo y usuario
                    row.RelativeItem().AlignRight().Column(c =>
                    {
                        c.Item()
                         .Text(periodo)
                         .FontSize(9)
                         .FontColor(HexColor(ColorGrisMedio));

                        c.Item()
                         .Text($"Generado por: {nombreUsuario}")
                         .FontSize(9)
                         .FontColor(HexColor(ColorGrisMedio));

                        c.Item()
                         .Text($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}")
                         .FontSize(9)
                         .FontColor(HexColor(ColorGrisMedio));
                    });
                });

                // Línea separadora debajo del encabezado
                col.Item().Height(1).Background(HexColor("#CBD5E1"));
            });
        }

        // Dibuja el pie de página con el número de página actual y el total de páginas
        private static void DibujarPiePagina(IContainer footer)
        {
            footer.Padding(10).Row(row =>
            {
                row.RelativeItem()
                   .Text("Control de Finanzas Personales — Documento generado automáticamente")
                   .FontSize(8)
                   .FontColor(HexColor(ColorGrisMedio));

                row.RelativeItem()
                   .AlignRight()
                   .Text(txt =>
                   {
                       txt.Span("Página ").FontSize(8).FontColor(HexColor(ColorGrisMedio));
                       txt.CurrentPageNumber().FontSize(8).FontColor(HexColor(ColorGrisMedio));
                       txt.Span(" de ").FontSize(8).FontColor(HexColor(ColorGrisMedio));
                       txt.TotalPages().FontSize(8).FontColor(HexColor(ColorGrisMedio));
                   });
            });
        }

        // Dibuja una tarjeta KPI (caja de resumen) con un título, un valor y un color de acento
        private static void DibujarTarjetaKPI(
            IContainer contenedor,
            string titulo,
            string valor,
            string colorAcento)
        {
            contenedor
                .Border(1)
                .BorderColor(HexColor(colorAcento))
                .Padding(10)
                .Column(c =>
                {
                    c.Item()
                     .Text(titulo)
                     .FontSize(8)
                     .FontColor(HexColor(ColorGrisMedio));

                    c.Item()
                     .Text(valor)
                     .Bold()
                     .FontSize(13)
                     .FontColor(HexColor(colorAcento));
                });
        }

        // ==================== REPORTE 1 — Historial de Movimientos ====================

        // Genera el PDF del Reporte 1 con todos los movimientos del periodo indicado
        // Incluye tarjetas KPI en la cabecera y una tabla zebra con colores por tipo
        public static void GenerarPDFMovimientos(
            List<ReporteMovimientoDTO> datos,
            ReporteMovimientosResumenDTO resumen,
            string desde,
            string hasta,
            string tipoFiltro,
            string cuentaFiltro,
            string nombreUsuario,
            string rutaArchivo)
        {
            string periodo  = $"Periodo: {desde} — {hasta}";
            string filtros  = $"Tipo: {tipoFiltro} | Cuenta: {cuentaFiltro}";

            Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.Letter.Landscape());
                    page.Margin(1.5f, Unit.Centimetre);
                    page.DefaultTextStyle(t => t.FontFamily("Segoe UI").FontSize(9));

                    // Encabezado
                    page.Header().Element(h =>
                        DibujarEncabezado(h, "Reporte 1 — Historial Integral de Movimientos",
                            $"{periodo} | {filtros}", nombreUsuario));

                    page.Content().Column(col =>
                    {
                        col.Spacing(10);

                        // Fila de tarjetas KPI
                        col.Item().Row(row =>
                        {
                            row.Spacing(8);
                            row.RelativeItem().Element(c =>
                                DibujarTarjetaKPI(c, "Total Ingresos",
                                    resumen.TotalIngresos.ToString("C2"), ColorVerde));

                            row.RelativeItem().Element(c =>
                                DibujarTarjetaKPI(c, "Total Gastos",
                                    resumen.TotalGastos.ToString("C2"), ColorRojo));

                            row.RelativeItem().Element(c =>
                                DibujarTarjetaKPI(c, "Flujo Neto",
                                    resumen.FlujoNeto.ToString("C2"),
                                    resumen.FlujoNeto >= 0 ? ColorVerde : ColorRojo));

                            row.RelativeItem().Element(c =>
                                DibujarTarjetaKPI(c, "Total Transferido",
                                    resumen.TotalTransferido.ToString("C2"), ColorAzul));
                        });

                        // Subtítulo de la tabla
                        col.Item()
                           .Text($"Detalle de movimientos ({datos.Count} registros)")
                           .Bold()
                           .FontSize(10)
                           .FontColor(HexColor(ColorTexto));

                        // Tabla de movimientos
                        col.Item().Table(tabla =>
                        {
                            // Definición de columnas con sus anchos relativos
                            tabla.ColumnsDefinition(cols =>
                            {
                                cols.RelativeColumn(1.3f); // Fecha
                                cols.RelativeColumn(1.5f); // Tipo
                                cols.RelativeColumn(2f);   // Cuenta Origen
                                cols.RelativeColumn(2f);   // Destino/Categoría
                                cols.RelativeColumn(2.5f); // Descripción
                                cols.RelativeColumn(1.2f); // Monto
                            });

                            // Fila de encabezado de la tabla
                            tabla.Header(h =>
                            {
                                void CeldaHeader(string texto) =>
                                    h.Cell().Background(HexColor(ColorGrisClaro))
                                      .Padding(5)
                                      .Text(texto).Bold().FontSize(8).FontColor(HexColor(ColorTexto));

                                CeldaHeader("Fecha");
                                CeldaHeader("Tipo");
                                CeldaHeader("Cuenta Origen");
                                CeldaHeader("Destino / Categoría");
                                CeldaHeader("Descripción");
                                CeldaHeader("Monto");
                            });

                            // Filas de datos con color de fondo según el tipo de movimiento
                            for (int i = 0; i < datos.Count; i++)
                            {
                                var item = datos[i];
                                bool esAlterna = i % 2 != 0;

                                // Color de fondo: verde suave para ingresos, rojo suave para gastos,
                                // azul suave para transferencias, alternando con blanco para la zebra
                                string colorFila;
                                if (item.TipoMovimiento == "Ingreso")
                                    colorFila = esAlterna ? "#DCFCE7" : "#F0FDF4";
                                else if (item.TipoMovimiento == "Gasto")
                                    colorFila = esAlterna ? "#FEE2E2" : "#FFF5F5";
                                else
                                    colorFila = esAlterna ? "#DBEAFE" : "#EFF6FF";

                                void Celda(string texto, bool alinearDer = false)
                                {
                                    var c = tabla.Cell()
                                                 .Background(HexColor(colorFila))
                                                 .BorderBottom(0.5f)
                                                 .BorderColor(HexColor("#E2E8F0"))
                                                 .Padding(4);
                                    if (alinearDer)
                                        c.AlignRight().Text(texto).FontSize(8);
                                    else
                                        c.Text(texto).FontSize(8);
                                }

                                Celda(item.Fecha.ToString("dd/MM/yyyy"));
                                Celda(item.TipoMovimiento);
                                Celda(item.CuentaOrigen);
                                Celda(item.DestinoOCategoria);
                                Celda(item.Descripcion);
                                Celda(item.Monto.ToString("C2"), alinearDer: true);
                            }

                            // Si no hay datos mostramos una fila indicándolo
                            if (datos.Count == 0)
                            {
                                tabla.Cell().ColumnSpan(6)
                                     .Padding(10)
                                     .AlignCenter()
                                     .Text("No se encontraron movimientos para los filtros seleccionados.")
                                     .FontColor(HexColor(ColorGrisMedio));
                            }
                        });
                    });

                    page.Footer().Element(DibujarPiePagina);
                });
            }).GeneratePdf(rutaArchivo);
        }

        // ==================== REPORTE 2 — Gastos por Categoría ====================

        // Genera el PDF del Reporte 2 con el desglose de gastos agrupados por categoría
        public static void GenerarPDFGastosCategorias(
            List<ReporteGastoCategoriaDTO> datos,
            string desde,
            string hasta,
            string nombreUsuario,
            string rutaArchivo)
        {
            decimal totalGlobal = 0;
            foreach (var d in datos)
                totalGlobal += d.TotalGastado;

            Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.Margin(1.5f, Unit.Centimetre);
                    page.DefaultTextStyle(t => t.FontFamily("Segoe UI").FontSize(9));

                    page.Header().Element(h =>
                        DibujarEncabezado(h, "Reporte 2 — Gastos por Categoría y Hábitos de Consumo",
                            $"Periodo: {desde} — {hasta}", nombreUsuario));

                    page.Content().Column(col =>
                    {
                        col.Spacing(10);

                        // Tarjeta resumen total
                        col.Item().Row(row =>
                        {
                            row.Spacing(8);
                            row.RelativeItem().Element(c =>
                                DibujarTarjetaKPI(c, "Total Gastado en el Periodo",
                                    totalGlobal.ToString("C2"), ColorRojo));

                            row.RelativeItem().Element(c =>
                                DibujarTarjetaKPI(c, "Número de Categorías",
                                    datos.Count.ToString(), ColorAzul));

                            row.RelativeItem().Element(c =>
                                DibujarTarjetaKPI(c, "Total Transacciones",
                                    datos.Sum(d => d.CantidadTransacciones).ToString(), ColorGrisMedio));
                        });

                        col.Item()
                           .Text("Desglose por categoría")
                           .Bold().FontSize(10).FontColor(HexColor(ColorTexto));

                        // Tabla de categorías
                        col.Item().Table(tabla =>
                        {
                            tabla.ColumnsDefinition(cols =>
                            {
                                cols.RelativeColumn(2.5f); // Categoría
                                cols.RelativeColumn(1.5f); // Total Gastado
                                cols.RelativeColumn(1f);   // % del total
                                cols.RelativeColumn(1f);   // N° transacciones
                                cols.RelativeColumn(1.5f); // Promedio
                            });

                            // Encabezado de la tabla
                            tabla.Header(h =>
                            {
                                void CeldaH(string texto) =>
                                    h.Cell().Background(HexColor(ColorGrisClaro))
                                      .Padding(5).Text(texto)
                                      .Bold().FontSize(8).FontColor(HexColor(ColorTexto));

                                CeldaH("Categoría");
                                CeldaH("Total Gastado");
                                CeldaH("% del Total");
                                CeldaH("N° Transacciones");
                                CeldaH("Promedio");
                            });

                            // Filas con color de acento de la categoría a la izquierda
                            for (int i = 0; i < datos.Count; i++)
                            {
                                var cat = datos[i];
                                string bgFila = i % 2 == 0 ? ColorBlancoZebra : ColorFilaAlterna;

                                // Celda del nombre con barra de color de la categoría
                                tabla.Cell()
                                     .Background(HexColor(bgFila))
                                     .BorderBottom(0.5f).BorderColor(HexColor("#E2E8F0"))
                                     .Padding(4)
                                     .Row(r =>
                                     {
                                         // Cuadrito de color de la categoría
                                         r.ConstantItem(10)
                                          .Height(10)
                                          .Background(HexColor(cat.ColorHex));

                                         r.ConstantItem(6); // espacio

                                         r.RelativeItem()
                                          .Text(cat.Categoria)
                                          .FontSize(8);
                                     });

                                void CeldaD(string texto, bool der = false)
                                {
                                    var c = tabla.Cell()
                                                 .Background(HexColor(bgFila))
                                                 .BorderBottom(0.5f).BorderColor(HexColor("#E2E8F0"))
                                                 .Padding(4);
                                    if (der) c.AlignRight().Text(texto).FontSize(8);
                                    else c.Text(texto).FontSize(8);
                                }

                                CeldaD(cat.TotalGastado.ToString("C2"), der: true);
                                CeldaD($"{cat.Porcentaje:F1}%", der: true);
                                CeldaD(cat.CantidadTransacciones.ToString(), der: true);
                                CeldaD(cat.PromedioPorTransaccion.ToString("C2"), der: true);
                            }

                            if (datos.Count == 0)
                            {
                                tabla.Cell().ColumnSpan(5)
                                     .Padding(10).AlignCenter()
                                     .Text("Sin datos para el periodo seleccionado.")
                                     .FontColor(HexColor(ColorGrisMedio));
                            }
                        });

                        // Fila de totales al pie de la tabla
                        if (datos.Count > 0)
                        {
                            col.Item()
                               .Background(HexColor(ColorGrisClaro))
                               .Padding(8)
                               .Row(row =>
                               {
                                   row.RelativeItem()
                                      .Text("TOTAL GENERAL")
                                      .Bold().FontSize(9).FontColor(HexColor(ColorTexto));

                                   row.ConstantItem(100)
                                      .AlignRight()
                                      .Text(totalGlobal.ToString("C2"))
                                      .Bold().FontSize(9).FontColor(HexColor(ColorRojo));
                               });
                        }
                    });

                    page.Footer().Element(DibujarPiePagina);
                });
            }).GeneratePdf(rutaArchivo);
        }

        // ==================== REPORTE 3 — Estado General de Cuentas ====================

        // Genera el PDF del Reporte 3 con la fotografía actual de todas las cuentas del usuario
        public static void GenerarPDFEstadoCuentas(
            List<ReporteEstadoCuentaDTO> datos,
            string nombreUsuario,
            string rutaArchivo)
        {
            decimal liquidez   = 0m;
            decimal deudaTotal = 0m;
            foreach (var c in datos)
            {
                if (c.TipoCuenta != "Crédito")
                    liquidez += c.SaldoActual;
                deudaTotal += c.DeudaActual;
            }
            decimal patrimonio = liquidez - deudaTotal;

            Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.Letter.Landscape());
                    page.Margin(1.5f, Unit.Centimetre);
                    page.DefaultTextStyle(t => t.FontFamily("Segoe UI").FontSize(9));

                    page.Header().Element(h =>
                        DibujarEncabezado(h, "Reporte 3 — Estado General de Cuentas",
                            $"Corte al: {DateTime.Now:dd/MM/yyyy}", nombreUsuario));

                    page.Content().Column(col =>
                    {
                        col.Spacing(10);

                        // Tarjetas KPI de liquidez, deuda y patrimonio neto
                        col.Item().Row(row =>
                        {
                            row.Spacing(8);
                            row.RelativeItem().Element(c =>
                                DibujarTarjetaKPI(c, "Liquidez Total",
                                    liquidez.ToString("C2"), ColorVerde));

                            row.RelativeItem().Element(c =>
                                DibujarTarjetaKPI(c, "Deuda Total (Tarjetas)",
                                    deudaTotal.ToString("C2"), ColorRojo));

                            row.RelativeItem().Element(c =>
                                DibujarTarjetaKPI(c, "Patrimonio Neto",
                                    patrimonio.ToString("C2"),
                                    patrimonio >= 0 ? ColorVerde : ColorRojo));
                        });

                        col.Item()
                           .Text($"Detalle de cuentas ({datos.Count} registros)")
                           .Bold().FontSize(10).FontColor(HexColor(ColorTexto));

                        // Tabla de cuentas
                        col.Item().Table(tabla =>
                        {
                            tabla.ColumnsDefinition(cols =>
                            {
                                cols.RelativeColumn(2f);   // Nombre
                                cols.RelativeColumn(1.3f); // Tipo
                                cols.RelativeColumn(0.8f); // Moneda
                                cols.RelativeColumn(1.3f); // Saldo Actual
                                cols.RelativeColumn(1.3f); // Límite Crédito
                                cols.RelativeColumn(1.3f); // Deuda Actual
                                cols.RelativeColumn(1.3f); // Crédito Disponible
                                cols.RelativeColumn(0.7f); // Estado
                            });

                            // Encabezado
                            tabla.Header(h =>
                            {
                                void CH(string t) =>
                                    h.Cell().Background(HexColor(ColorGrisClaro))
                                      .Padding(5).Text(t)
                                      .Bold().FontSize(8).FontColor(HexColor(ColorTexto));

                                CH("Cuenta");
                                CH("Tipo");
                                CH("Moneda");
                                CH("Saldo Actual");
                                CH("Límite Crédito");
                                CH("Deuda Actual");
                                CH("Crédito Disponible");
                                CH("Estado");
                            });

                            // Filas de datos
                            for (int i = 0; i < datos.Count; i++)
                            {
                                var cuenta  = datos[i];
                                string bg   = i % 2 == 0 ? ColorBlancoZebra : ColorFilaAlterna;

                                void CD(string texto, bool der = false, string? colorTexto = null)
                                {
                                    var celda = tabla.Cell()
                                                     .Background(HexColor(bg))
                                                     .BorderBottom(0.5f).BorderColor(HexColor("#E2E8F0"))
                                                     .Padding(4);
                                    var txt = der ? celda.AlignRight().Text(texto).FontSize(8)
                                                  : celda.Text(texto).FontSize(8);
                                    if (colorTexto != null)
                                        txt.FontColor(HexColor(colorTexto));
                                }

                                CD(cuenta.Nombre);
                                CD(cuenta.TipoCuenta);
                                CD(cuenta.Moneda);
                                CD(cuenta.SaldoActual.ToString("C2"), der: true,
                                   colorTexto: cuenta.SaldoActual >= 0 ? ColorVerde : ColorRojo);
                                CD(cuenta.LimiteCredito > 0
                                    ? cuenta.LimiteCredito.ToString("C2") : "—", der: true);
                                CD(cuenta.DeudaActual > 0
                                    ? cuenta.DeudaActual.ToString("C2") : "—", der: true,
                                   colorTexto: cuenta.DeudaActual > 0 ? ColorRojo : null);
                                CD(cuenta.CreditoDisponible > 0
                                    ? cuenta.CreditoDisponible.ToString("C2") : "—", der: true,
                                   colorTexto: cuenta.CreditoDisponible > 0 ? ColorVerde : null);
                                CD(cuenta.Estado ? "Activa" : "Inactiva",
                                   colorTexto: cuenta.Estado ? ColorVerde : ColorGrisMedio);
                            }

                            if (datos.Count == 0)
                            {
                                tabla.Cell().ColumnSpan(8)
                                     .Padding(10).AlignCenter()
                                     .Text("No hay cuentas registradas.")
                                     .FontColor(HexColor(ColorGrisMedio));
                            }
                        });

                        // Fila de totales al pie
                        col.Item()
                           .Background(HexColor(ColorGrisClaro))
                           .Padding(8)
                           .Row(row =>
                           {
                               row.RelativeItem()
                                  .Text("TOTALES")
                                  .Bold().FontSize(9).FontColor(HexColor(ColorTexto));

                               row.ConstantItem(200)
                                  .AlignRight()
                                  .Text($"Liquidez: {liquidez:C2}  |  Deuda: {deudaTotal:C2}  |  Patrimonio: {patrimonio:C2}")
                                  .Bold().FontSize(8)
                                  .FontColor(HexColor(patrimonio >= 0 ? ColorVerde : ColorRojo));
                           });
                    });

                    page.Footer().Element(DibujarPiePagina);
                });
            }).GeneratePdf(rutaArchivo);
        }
    }
}
