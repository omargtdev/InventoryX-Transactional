using InventoryX_Transactional.Data;
using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Repository.Common;
using Microsoft.EntityFrameworkCore;

namespace InventoryX_Transactional.Repository;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(InventoryXDbContext context) : base(context) { }

    public async Task<IEnumerable<Product>> GetAll()
    {
        return await _context.Products
            .Where(p => !p.IsDeleted)
            .Include(p => p.Warehouse)
            .Include(p => p.Category)
            .ToListAsync();
    }

    public async Task<Product?> GetByIdAsync(int id)
    {
        return await _context.Products
            .Where(p => !p.IsDeleted)
            .Include(p => p.Warehouse)
            .Include(p => p.Category)
            .FirstOrDefaultAsync(p => p.ProductId == id);
    }

    public async Task SaveAsync() => await _context.SaveChangesAsync();
}
