namespace ControlFinanzas.Entity.ObjetosTransferenciaDatos
{
    // DTO para representar el gasto de cada categoría y su porcentaje para la gráfica de pastel/dona
    public class GastoPorCategoriaDTO
    {
        // Nombre de la categoría de gasto
        public string Categoria { get; set; } = string.Empty;

        // Color hexadecimal asignado a la categoría
        public string ColorHex { get; set; } = "#808080";

        // Monto total gastado en esta categoría
        public decimal TotalGasto { get; set; }

        // Porcentaje que representa respecto al gasto total del mes
        public decimal Porcentaje { get; set; }
    }
}
