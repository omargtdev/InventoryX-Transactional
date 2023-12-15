using InventoryX_Transactional.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryX_Transactional.Data;

public class IssueEntityTypeConfiguration : IEntityTypeConfiguration<Issue>
{
    public void Configure(EntityTypeBuilder<Issue> builder)
    {
        builder.HasKey(r => r.IssueId);

        builder.Property(r => r.CreatedAt);

        builder
            .HasMany(r => r.IssueProducts)
            .WithOne(r => r.Issue)
            .IsRequired();

        builder
            .HasOne(r => r.Client)
            .WithMany(p => p.Issues)
            .IsRequired();

        builder.ToTable(nameof(Issue));
    }
}
