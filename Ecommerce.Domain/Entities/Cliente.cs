using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Entities;

public class Cliente
{
    [Key]
    public int id_cliente { get; set; }
    public string nombres { get; set; } = string.Empty;
    public string apellidos { get; set; } = string.Empty;
    public string correo { get; set; } = string.Empty;
    public string? telefono { get; set; }
    public string? direccion { get; set; }
    public string identificacion { get; set; } = string.Empty;
    public bool es_activo { get; set; } = true;
    public DateTime fe_creacion { get; set; } = DateTime.UtcNow;
}