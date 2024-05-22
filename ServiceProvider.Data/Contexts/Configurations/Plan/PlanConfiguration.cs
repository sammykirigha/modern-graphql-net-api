using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class PlanConfiguration : IEntityTypeConfiguration<Plan>
{
    public void Configure(EntityTypeBuilder<Plan> entity)
    {
        entity.ToTable($"SP_{nameof(Plan)}");
        entity.HasKey(x => x.Id);

        entity.Property(x => x.Name).HasMaxLength(50);

    }
}