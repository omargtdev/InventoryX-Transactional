using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Repository.Common;

namespace InventoryX_Transactional.Repository;

public interface IProductRepository : IGenericRepository<Product>, ISaveRepository
{
    Task<IEnumerable<Product>> GetAll();
    Task<Product?> GetByIdAsync(int id);
}
