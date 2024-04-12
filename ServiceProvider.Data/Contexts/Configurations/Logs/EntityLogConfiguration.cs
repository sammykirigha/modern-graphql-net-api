using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class EntityLogConfiguration : IEntityTypeConfiguration<EntityLog>
{
    public void Configure(EntityTypeBuilder<EntityLog> entity)
    {
        entity.ToTable($"SP_{nameof(EntityLog)}");
        entity.HasKey(x => x.Id);

        entity.Property(x => x.Entity).HasMaxLength(50);
        //entity.Property(x => x.LoggedInUser).HasMaxLength(100);
        entity.Property(x => x.ActiveUserName).HasMaxLength(100);
        entity.Property(x => x.ChangeTrigger).HasMaxLength(500);
        entity.Property(x => x.ChangeReason).HasMaxLength(500);

        entity.HasOne(x => x.ActiveUser)
              .WithMany(x => x.EntityLogsActive);
        //entity.HasOne(x => x.LoggedInUser)
           // .WithMany(x => x.EntityLogsLoggedIn);
    }
}

