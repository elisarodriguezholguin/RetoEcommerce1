using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain.Entities
{
    [Table("sc_rol")] // Esto le dice a EF que la tabla se llama así en la DB
    public class Rol
    {
        [Key]
        public int id_rol { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string? descripcion { get; set; }
    }
}
