using InventoryX_Transactional.Data.Models;

namespace InventoryX_Transactional.Repository.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    // Repositories
    IGenericRepository<Client> Clients { get; }
    IGenericRepository<Provider> Providers { get; }
    Task SaveAsync();
}
