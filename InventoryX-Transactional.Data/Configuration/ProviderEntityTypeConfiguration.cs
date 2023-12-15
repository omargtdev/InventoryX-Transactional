using InventoryX_Transactional.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryX_Transactional.Data.Configuration;

public class ProviderEntityTypeConfiguration : IEntityTypeConfiguration<Provider>
{
    public void Configure(EntityTypeBuilder<Provider> builder)
    {
        builder.HasKey(c => c.ProviderId);
        builder.Property(c => c.BusinessName)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(c => c.RUC)
            .HasMaxLength(20)
            .IsUnicode(false)
            .IsRequired();

        builder.Property(c => c.ContactEmail)
            .HasMaxLength(200)
            .IsUnicode(false)
            .IsRequired();

        builder.Property(c => c.ContactPhone)
            .HasMaxLength(20)
            .IsUnicode(false)
            .IsRequired();

        builder.Property(c => c.Address)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(c => c.IsDeleted)
            .HasDefaultValue(false)
            .IsRequired();

        builder.Property(c => c.CreatedBy)
            .IsRequired();

        builder.Property(c => c.CreatedAt)
            .IsRequired();

        builder.ToTable(nameof(Provider));
    }
}
