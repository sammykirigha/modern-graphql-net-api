using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class ClientServiceConfiguration : IEntityTypeConfiguration<ClientService>
{
	public void Configure(EntityTypeBuilder<ClientService> entity)
	{
		entity.ToTable($"SP_{nameof(ClientService)}");
		entity.HasKey(x => x.Id);

		entity.HasOne(sl => sl.Service)
			.WithMany(s => s.ClientServices)
			.HasForeignKey(sl => sl.ServiceId)
			.OnDelete(DeleteBehavior.NoAction);

		entity.HasOne(sl => sl.Client)
			.WithMany(l => l.ClientServices)
			.HasForeignKey(sl => sl.ClientId)
			.OnDelete(DeleteBehavior.NoAction);
	}
}