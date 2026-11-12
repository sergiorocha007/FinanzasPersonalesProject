namespace ControlFinanzas.Entity.Entidades
{
    // Esta clase actúa como un DTO (Data Transfer Object) para los totalizadores, 
    // por lo que usamos propiedades con 'set' público para permitir su inicialización directa 
    // desde el SqlDataReader en tu CategoriaDAL.
    public class CategoriaKPI
    {
        public int TotalCategorias { get; set; }

        public int TotalIngresos { get; set; }

        public int TotalGastos { get; set; }
    }
}