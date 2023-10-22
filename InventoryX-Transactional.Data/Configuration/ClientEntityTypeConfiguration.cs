using InventoryX_Transactional.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryX_Transactional.Data.Configuration;

public class ClientEntityTypeConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.HasKey(c => c.ClientId);
        builder.Property(c => c.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(c => c.DocumentType)
            .IsRequired();

        builder.Property(c => c.DocumentNumber)
            .HasMaxLength(20)
            .IsUnicode(false)
            .IsRequired();

        builder.Property(c => c.Email)
            .HasMaxLength(200)
            .IsUnicode(false)
            .IsRequired();

        builder.Property(c => c.Phone)
            .HasMaxLength(20)
            .IsUnicode(false)
            .IsRequired();

        builder.Property(c => c.Address)
            .HasMaxLength(200);

        builder.Property(c => c.IsLegal)
            .IsRequired();

        builder.Property(c => c.IsDeleted)
            .HasDefaultValue(false)
            .IsRequired();

        builder.Property(c => c.CreatedBy)
            .IsRequired();

        builder.Property(c => c.CreatedAt)
            .HasDefaultValue(DateTime.Now)
            .IsRequired();

        builder.ToTable(nameof(Client));
    }
}
