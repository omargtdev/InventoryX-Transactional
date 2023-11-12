using InventoryX_Transactional.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryX_Transactional.Data;

public class ProductPriceEntityTypeConfiguration : IEntityTypeConfiguration<ProductPrice>
{
    public void Configure(EntityTypeBuilder<ProductPrice> builder)
    {
        builder.HasKey(p => p.ProductPriceId);

        builder.Property(p => p.LastReceiptPrice)
            .HasColumnType("decimal")
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(p => p.LastIssuePrice)
            .HasColumnType("decimal")
            .HasPrecision(18, 2)
            .IsRequired();

        builder
            .HasOne(p => p.Product)
            .WithOne(p => p.ProductPrice)
            .HasForeignKey<ProductPrice>(p => p.ProductId)
            .IsRequired();

        builder.Property(p => p.CreatedBy)
            .IsRequired();

        builder.Property(p => p.CreatedAt)
            .HasDefaultValue(DateTime.Now)
            .IsRequired();

        builder.ToTable(nameof(ProductPrice));
    }
}
