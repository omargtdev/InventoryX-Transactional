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
        IGenericRepository<Provider> providerRepository,
        IGenericRepository<Category> categoryRepository,
        IGenericRepository<Warehouse> warehouseRepository,
        IProductRepository productRepository,
        IReceiptRepository receiptRepository,
        IIssueRepository issueRepository)
    {
        _context = context;
        Clients = clientRepository;
        Providers = providerRepository;
        Categories = categoryRepository;
        Warehouses = warehouseRepository;
        Products = productRepository;
        Receipts = receiptRepository;
        Issues = issueRepository;
    }

    public IGenericRepository<Client> Clients { get; }
    public IGenericRepository<Provider> Providers { get; }
    public IGenericRepository<Category> Categories { get; }
    public IGenericRepository<Warehouse> Warehouses { get; }
    public IProductRepository Products { get; }
    public IReceiptRepository Receipts { get; }
    public IIssueRepository Issues { get; }
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
