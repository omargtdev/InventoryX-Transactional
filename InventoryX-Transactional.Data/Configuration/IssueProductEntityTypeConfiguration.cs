using InventoryX_Transactional.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryX_Transactional.Data;

public class IssueProductEntityTypeConfiguration : IEntityTypeConfiguration<IssueProduct>
{
    public void Configure(EntityTypeBuilder<IssueProduct> builder)
    {
        builder.HasKey(r => new { r.IssueId, r.ProductId });

        builder.Property(r => r.UnitPriceForSale)
           .HasColumnType("decimal")
           .HasPrecision(18, 2)
           .IsRequired();

        builder.Property(r => r.Quantity)
            .IsRequired();

        builder.Property(r => r.CreatedBy)
            .IsRequired();

        builder.Property(r => r.CreatedAt)
            .IsRequired();

        builder.ToTable(nameof(IssueProduct));
    }
}
