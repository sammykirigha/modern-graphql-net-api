using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Seeding;

public static partial class LocationSeeding
{
	public static void AddLocationSeeding(ModelBuilder builder)
	{
		builder.Entity<Location>().HasData(
		new Location()
		{
			Id = Guid.NewGuid(),
			LocationName = "Claycity",
			ConstituencyId = EntityIds.KasaraniGuid,
			DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
			DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
		},
		new Location()
		{
			Id = Guid.NewGuid(),
			LocationName = "Mwiki",
			ConstituencyId = EntityIds.KasaraniGuid,
			DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
			DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
		},
		new Location()
		{
			Id = Guid.NewGuid(),
			LocationName = "Ruai",
			ConstituencyId = EntityIds.KasaraniGuid,
			DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
			DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
		},
		new Location()
		{
			Id = Guid.NewGuid(),
			LocationName = "Njiru",
			ConstituencyId = EntityIds.KasaraniGuid,
			DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
			DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
		},
		new Location()
		{
			Id = Guid.NewGuid(),
			LocationName = "Kasarani",
			ConstituencyId = EntityIds.KasaraniGuid,
			DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
			DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
		}
		);
	}
}