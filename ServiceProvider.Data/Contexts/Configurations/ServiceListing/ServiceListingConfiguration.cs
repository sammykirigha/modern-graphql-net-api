using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public class ServiceListingConfiguration: IEntityTypeConfiguration<ServiceListing>
{
	public void Configure(EntityTypeBuilder<ServiceListing> entity)
	{
		entity.ToTable($"SP_{nameof(ServiceListing)}");
		entity.HasKey(x => x.Id);
		entity.HasMany(x => x.Reviews).WithOne(x => x.ServiceListing).HasForeignKey(x => x.ServiceListingId);
		entity.HasMany(x => x.Bookings).WithOne(x => x.ServiceListing).HasForeignKey(x => x.ServiceListingId);
		entity.HasOne(x => x.ServiceProvider).WithMany(x => x.ServiceListings).HasForeignKey(x => x.ServiceProviderId);

	}

}