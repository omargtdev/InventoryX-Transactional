using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Repository.Common;

namespace InventoryX_Transactional.Repository.UnitOfWork;

public interface IUnitOfWork : ISaveRepository, IDisposable
{
    // Repositories
    IGenericRepository<Client> Clients { get; }
    IGenericRepository<Provider> Providers { get; }
    IGenericRepository<Category> Categories { get; }
    IGenericRepository<Warehouse> Warehouses { get; }
    IProductRepository Products { get; }
    IReceiptRepository Receipts { get; }
    IIssueRepository Issues { get; }
}
