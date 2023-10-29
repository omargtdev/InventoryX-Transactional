using InventoryX_Transactional.Data;
using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Repository.Common;

namespace InventoryX_Transactional.Repository;

public class WarehouseRepository : GenericRepository<Warehouse>, IWarehouseRepository
{
    public WarehouseRepository(InventoryXDbContext context) : base(context)
    {
    }

    public async Task SaveAsync() => await _context.SaveChangesAsync();
}
