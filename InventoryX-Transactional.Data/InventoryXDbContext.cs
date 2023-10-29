using InventoryX_Transactional.Data.Configuration;
using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Data.Seeds;
using Microsoft.EntityFrameworkCore;

namespace InventoryX_Transactional.Data;
public class InventoryXDbContext : DbContext
{
    public InventoryXDbContext(DbContextOptions<InventoryXDbContext> options) : base(options) { }

    public DbSet<Client> Clients { get; set; }
    public DbSet<Provider> Providers { get; set; }
    public DbSet<Category> Categories { get; set; }
   
    protected override void OnModelCreating(ModelBuilder modelBuilder) 
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ClientEntityTypeConfiguration).Assembly);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProviderEntityTypeConfiguration).Assembly);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryEntityTypeConfiguration).Assembly);
    }
}
