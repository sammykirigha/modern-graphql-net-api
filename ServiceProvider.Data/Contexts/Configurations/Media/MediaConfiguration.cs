using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models.Medias;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class MediasConfiguration : IEntityTypeConfiguration<Media>
{
	public void Configure(EntityTypeBuilder<Media> entity)
	{
		entity.ToTable($"SP_{nameof(Media)}");
		entity.HasKey(x => x.Id);
	}
}