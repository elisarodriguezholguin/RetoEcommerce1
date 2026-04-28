using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Ecommerce.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    // Aquí es donde registraremos nuestras futuras tablas
    // Por ahora lo dejamos listo para los productos
    public DbSet<Producto> Productos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Esto le dice a la base de datos que la tabla se llamará "pr_producto"
        modelBuilder.Entity<Producto>().ToTable("pr_producto").HasKey(p => p.id_producto);
    }
}