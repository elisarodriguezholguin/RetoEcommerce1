using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain.Entities
{
    [Table("pr_categoria")]
    public class Categoria
    {
        [Key]
        public int id_categoria { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string? descripcion { get; set; }
        public bool es_activo { get; set; } = true;
    }
}
