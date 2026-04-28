using Ecommerce.Domain.Entities;
using Ecommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Repositories
{
    public class ProductoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> GuardarProducto(Producto producto)
        {
            _context.pr_producto.Add(producto);
            return await _context.SaveChangesAsync();
        }
    }
}