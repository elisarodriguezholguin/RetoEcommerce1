using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Entities;

public class Auditoria
{
    [Key]
    public int id_auditoria { get; set; }
    public string tabla { get; set; } = string.Empty; // Ejemplo: "pr_producto"
    public string accion { get; set; } = string.Empty; // Ejemplo: "INSERT", "UPDATE"
    public string registro_id { get; set; } = string.Empty;
    public string? datos_anteriores { get; set; } // Formato JSON
    public string? datos_nuevos { get; set; } // Formato JSON
    public string usuario { get; set; } = string.Empty;
    public DateTime fe_evento { get; set; } = DateTime.UtcNow;
}