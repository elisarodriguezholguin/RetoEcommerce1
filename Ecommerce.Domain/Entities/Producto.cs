namespace Ecommerce.Domain.Entities;

public class Producto
{
    public int id_producto { get; set; }
    public string nombre { get; set; } = string.Empty;
    public decimal precio { get; set; }
}