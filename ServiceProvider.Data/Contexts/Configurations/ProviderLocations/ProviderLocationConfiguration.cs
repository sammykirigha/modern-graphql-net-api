using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class ProviderLocationsConfiguration : IEntityTypeConfiguration<ProviderLocations>
{
	public void Configure(EntityTypeBuilder<ProviderLocations> entity)
	{
		entity.ToTable($"SP_{nameof(ProviderLocations)}");
		entity.HasKey(x => new {x.ServiceProviderId, x.LocationId});
        
	}
}