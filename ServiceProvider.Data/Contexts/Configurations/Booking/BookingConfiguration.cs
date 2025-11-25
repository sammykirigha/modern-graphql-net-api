using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class BookingConfiguration : IEntityTypeConfiguration<Booking>
{
    public void Configure(EntityTypeBuilder<Booking> entity)
    {
        entity.ToTable($"SP_{nameof(Booking)}");
        entity.HasKey(x => x.Id);

        entity.HasOne(x => x.Service).WithMany(x => x.Bookings).HasForeignKey(x => x.ServiceId).OnDelete(DeleteBehavior.Restrict);
        entity.HasOne(x => x.ServiceProvider).WithMany(x => x.Bookings).HasForeignKey(x => x.ServiceProviderId).OnDelete(DeleteBehavior.Restrict);
    }
}