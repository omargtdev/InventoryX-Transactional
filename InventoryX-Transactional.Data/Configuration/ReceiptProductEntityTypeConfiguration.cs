using InventoryX_Transactional.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryX_Transactional.Data;

public class ReceiptProductEntityTypeConfiguration : IEntityTypeConfiguration<ReceiptProduct>
{
    public void Configure(EntityTypeBuilder<ReceiptProduct> builder)
    {
        builder.HasKey(r => new { r.ReceiptId, r.ProductId });

        builder.Property(r => r.UnitSalesPrice)
            .HasColumnType("decimal")
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(r => r.UnitPurchasePrice)
           .HasColumnType("decimal")
           .HasPrecision(18, 2)
           .IsRequired();

        builder.Property(r => r.Quantity)
            .IsRequired();

        builder.Property(r => r.CreatedBy)
            .IsRequired();

        builder.Property(r => r.CreatedAt)
            .IsRequired();

        builder.ToTable(nameof(ReceiptProduct));
    }
}
