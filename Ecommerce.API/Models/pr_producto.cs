namespace Ecommerce.Domain.Entities
{
    public class Producto
    {
        public int id_producto { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}