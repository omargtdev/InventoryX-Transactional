using InventoryX_Transactional.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryX_Transactional.Data.Configuration;

public class WarehouseEntityTypeConfiguration : IEntityTypeConfiguration<Warehouse>
{
    public void Configure(EntityTypeBuilder<Warehouse> builder)
    {
        builder.HasKey(w => w.WarehouseId);

        builder.Property(w => w.WarehouseId)
            .IsUnicode(false)
            .IsRequired();
        
        builder.Property(w => w.MaxStock)
            .IsRequired();
        
        builder.Property(w => w.Address)
            .IsRequired();

        builder.Property(w => w.District)
            .IsRequired();

        builder.Property(w => w.Province)
            .IsRequired();

        builder.Property(w => w.City)
            .IsRequired();

        builder.Property(c => c.IsDeleted)
            .HasDefaultValue(false)
            .IsRequired();

        builder.Property(c => c.CreatedBy)
            .IsRequired();

        builder.Property(c => c.CreatedAt)
            .HasDefaultValue(DateTime.Now)
            .IsRequired();

        builder.ToTable(nameof(Warehouse));
    }
}
