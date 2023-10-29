using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Repository.Common;

namespace InventoryX_Transactional.Repository;

public interface ICategoryRepository : IGenericRepository<Category>, ISaveRepository
{

}
