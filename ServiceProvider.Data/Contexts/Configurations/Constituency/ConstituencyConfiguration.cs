using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class ConstituencyConfiguration : IEntityTypeConfiguration<Constituency>
{
	public void Configure(EntityTypeBuilder<Constituency> entity)
	{
		entity.ToTable($"SP_{nameof(Constituency)}");
		entity.HasKey(x => x.Id);
        
	}
}