using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> entity)
    {
        entity.ToTable($"SP_{nameof(Category)}");
        entity.HasKey(x => x.Id);

        entity.Property(x => x.Name).HasMaxLength(50);

        entity.HasMany(x => x.Services)
         .WithOne(x => x.Category);
    }
}