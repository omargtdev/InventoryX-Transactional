using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Repository.Common;

namespace InventoryX_Transactional.Repository;

public interface IProviderRepository : IGenericRepository<Provider>, ISaveRepository
{

}
