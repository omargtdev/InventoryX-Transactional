using InventoryX_Transactional.Data;
using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Repository.Common;

namespace InventoryX_Transactional.Repository;

public class ProviderRepository : GenericRepository<Provider>, IProviderRepository
{
    public ProviderRepository(InventoryXDbContext context) : base(context)
    {
    }

    public async Task SaveAsync() => await _context.SaveChangesAsync();
}
