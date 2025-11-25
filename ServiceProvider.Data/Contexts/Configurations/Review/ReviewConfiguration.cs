using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> entity)
    {
        entity.ToTable($"SP_{nameof(Review)}");
        entity.HasKey(x => x.Id);
        entity.Property(x => x.Comments).HasMaxLength(1000);
        entity.HasOne(x => x.Service).WithMany(x => x.Reviews).HasForeignKey(x => x.ServiceId).OnDelete(DeleteBehavior.Restrict);
        entity.HasOne(x => x.User).WithMany(x => x.Reviews).HasForeignKey(x => x.CustomerId).OnDelete(DeleteBehavior.Restrict);

    }
}