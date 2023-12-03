using InventoryX_Transactional.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryX_Transactional.Data;

public class ReceiptEntityTypeConfiguration : IEntityTypeConfiguration<Receipt>
{
    public void Configure(EntityTypeBuilder<Receipt> builder)
    {
        builder.HasKey(r => r.ReceiptId);

        builder.Property(r => r.RegistrationDate)
            .IsRequired();

        builder.Property(r => r.ReferralGuideFileName)
           .IsRequired();

        builder.Property(r => r.CreatedBy)
            .IsRequired();

        builder.Property(r => r.CreatedAt)
            .IsRequired();

        builder
            .HasMany(r => r.ReceiptProducts)
            .WithOne(r => r.Receipt)
            .IsRequired();

        builder
            .HasOne(r => r.Provider)
            .WithMany(p => p.Receipts)
            .IsRequired();

        builder.ToTable(nameof(Receipt));
    }
}
