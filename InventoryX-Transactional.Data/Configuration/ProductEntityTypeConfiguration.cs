using InventoryX_Transactional.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryX_Transactional.Data;

public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.ProductId);
        builder.Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(p => p.Code)
            .HasMaxLength(10)
            .IsRequired();

        builder.Property(p => p.Description)
            .HasMaxLength(250)
            .IsRequired();

        builder.Property(p => p.Brand)
            .HasMaxLength(50)
            .IsRequired();
        
        builder
            .HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .IsRequired();

        builder
            .Property(p => p.Stock)
            .HasDefaultValue(0)
            .IsRequired();

        builder
            .HasOne(p => p.Warehouse)
            .WithMany(w => w.Products)
            .IsRequired();

        builder
            .HasMany(p => p.ReceiptProducts)
            .WithOne(r => r.Product)
            .IsRequired();

        builder.Property(p => p.IsDeleted)
            .HasDefaultValue(false)
            .IsRequired();

        builder.Property(p => p.CreatedBy)
            .IsRequired();

        builder.Property(p => p.CreatedAt)
            .HasDefaultValue(DateTime.Now)
            .IsRequired();

        builder.ToTable(nameof(Product));
    }
}
