using InventoryX_Transactional.Data;
using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Repository.Common;
using Microsoft.EntityFrameworkCore;

namespace InventoryX_Transactional.Repository;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(InventoryXDbContext context) : base(context) { }

    public async Task<bool> ExistProductByCode(string code, int? id = null)
    {
        if (id.HasValue)
            return (await GetByConditionAsync(p => p.Code == code && id != p.ProductId)).FirstOrDefault() is not null;

        return (await GetByConditionAsync(p => p.Code == code)).FirstOrDefault() is not null;
    }

    public async Task<IEnumerable<Product>> GetAll()
    {
        return await _context.Products
            .Where(p => !p.IsDeleted)
            .Include(p => p.Warehouse)
            .Include(p => p.Category)
            .Include(p => p.ProductPrice)
            .ToListAsync();
    }

    public async Task<Product?> GetByCodeAsync(string code)
    {
        return await _context.Products
            .Where(p => !p.IsDeleted && p.Code == code)
            .Include(p => p.Warehouse)
            .Include(p => p.Category)
            .Include(p => p.ProductPrice)
            .FirstOrDefaultAsync();
    }

    public async Task<Product?> GetByIdAsync(int id)
    {
        return await _context.Products
            .Where(p => !p.IsDeleted)
            .Include(p => p.Warehouse)
            .Include(p => p.Category)
            .FirstOrDefaultAsync(p => p.ProductId == id);
    }

    public async Task<int> GetStockSumByWarehouse(int warehouseId)
    {
        return await _context.Products
            .Where(p => p.WarehouseId == warehouseId && !p.IsDeleted)
            .SumAsync(p => p.Stock);
    }

    public async Task SaveAsync() => await _context.SaveChangesAsync();
}
