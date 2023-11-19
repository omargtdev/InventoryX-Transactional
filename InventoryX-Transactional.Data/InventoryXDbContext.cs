using InventoryX_Transactional.Data.Configuration;
using InventoryX_Transactional.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryX_Transactional.Data;
public class InventoryXDbContext : DbContext
{
    public InventoryXDbContext(DbContextOptions<InventoryXDbContext> options) : base(options) { }

    public DbSet<Client> Clients { get; set; }
    public DbSet<Provider> Providers { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductPrice> ProductsPrices { get; set; }
    public DbSet<Receipt> Receipts { get; set; }
    public DbSet<ReceiptProduct> ReceiptsProducts { get; set; }
   
    protected override void OnModelCreating(ModelBuilder modelBuilder) 
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(InventoryXDbContext).Assembly);
        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProviderEntityTypeConfiguration).Assembly);
        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryEntityTypeConfiguration).Assembly);
        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(WarehouseEntityTypeConfiguration).Assembly);
        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductEntityTypeConfiguration).Assembly);
        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductPriceEntityTypeConfiguration).Assembly);
        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ReceiptEntityTypeConfiguration).Assembly);
        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ReceiptProductEntityTypeConfiguration).Assembly);
    }
    }
