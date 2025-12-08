using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class ServiceListingsServicesConfiguration : IEntityTypeConfiguration<ServiceListingsServices>
{
	public void Configure(EntityTypeBuilder<ServiceListingsServices> entity)
	{
		entity.ToTable($"SP_{nameof(ServiceListingsServices)}");
		entity.HasKey(x => x.Id);
	}
}