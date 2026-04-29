using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    // 1. REGISTRO DE DBSets (Las "puertas" de acceso a las tablas)
    public DbSet<Producto> Productos { get; set; }
    public DbSet<Rol> Roles { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Auditoria> Auditorias { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // CONFIGURACIÓN DE TABLA: PRODUCTO (Ya la tenías)
        modelBuilder.Entity<Producto>()
            .ToTable("pr_producto")
            .HasKey(p => p.id_producto);


        // CONFIGURACIÓN DE TABLA: CATEGORÍA (Nueva)
        modelBuilder.Entity<Categoria>()
            .ToTable("pr_categoria")
            .HasKey(c => c.id_categoria);

        // CONFIGURACIÓN DE TABLA: ROL (Nueva)
        modelBuilder.Entity<Rol>()
            .ToTable("sc_rol")
            .HasKey(r => r.id_rol);
        modelBuilder.Entity<Usuario>()
            .ToTable("sc_usuario")
            .HasKey(u => u.id_usuario);
        modelBuilder.Entity<Cliente>()
            .ToTable("gn_cliente")
            .HasKey(c => c.id_cliente);
        modelBuilder.Entity<Auditoria>()
            .ToTable("gn_auditoria")
            .HasKey(a => a.id_auditoria);
    }
}
