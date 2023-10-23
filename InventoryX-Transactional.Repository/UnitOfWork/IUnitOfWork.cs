using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Repository.Common;

namespace InventoryX_Transactional.Repository.UnitOfWork;

public interface IUnitOfWork : ISaveRepository, IDisposable
{
    // Repositories
    IGenericRepository<Client> Clients { get; }
    IGenericRepository<Provider> Providers { get; }
}
