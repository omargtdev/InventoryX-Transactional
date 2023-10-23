using InventoryX_Transactional.Data;
using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Repository.Common;

namespace InventoryX_Transactional.Repository.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly InventoryXDbContext _context;

    public UnitOfWork(
        InventoryXDbContext context,
        IGenericRepository<Client> clientRepository,
        IGenericRepository<Provider> providerRepository)
    {
        _context = context;
        Clients = clientRepository;
        Providers = providerRepository;
    }

    public IGenericRepository<Client> Clients { get; }
    public IGenericRepository<Provider> Providers { get; }
    public async Task SaveAsync() => await _context.SaveChangesAsync();

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing) 
    {
        if(disposing)
            _context.Dispose();
    }
}
