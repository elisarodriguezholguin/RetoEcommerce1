using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Entities;

public class Usuario
{
    [Key]
    public int id_usuario { get; set; }
    public string usuario { get; set; } = string.Empty;
    public string correo { get; set; } = string.Empty;
    public string clave_hash { get; set; } = string.Empty;
    public int id_rol { get; set; }
    public bool es_activo { get; set; } = true;
    public DateTime fe_creacion { get; set; } = DateTime.UtcNow;

    // Relación con Rol
    public Rol? Rol { get; set; }
}