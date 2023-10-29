using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Data.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryX_Transactional.Data.Configuration;

public class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(c => c.CategoryId);

        builder.Property(c => c.Name)
            .HasMaxLength(30)
            .IsUnicode(false)
            .IsRequired();

        builder.Property(c => c.Description)
            .HasMaxLength(300)
            .IsRequired();

        builder.Property(c => c.IsDeleted)
            .HasDefaultValue(false)
            .IsRequired();

        builder.Property(c => c.CreatedBy)
            .IsRequired();

        builder.Property(c => c.CreatedAt)
            .ValueGeneratedOnAdd();

        builder.Property(c => c.ModifiedAt)
            .ValueGeneratedOnUpdate();

        builder.ToTable(nameof(Category));
    }
}
