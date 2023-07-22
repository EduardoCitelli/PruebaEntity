namespace PruebaEntity.Modelos
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public List<Producto> Productos { get; set; } = new List<Producto>();
    }
}
