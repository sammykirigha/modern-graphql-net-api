using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Seeding;

public static partial class CountySeeding
{
	public static void AddCountySeeding(ModelBuilder builder)
	{
		// County
		builder.Entity<County>().HasData(
			new County
			{
				Id = EntityIds.MombasaCountyGuid,
				CountyName = "MOMBASA",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.KwaleCountyGuid,
				CountyName = "KWALE",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.KilifiCountyGuid,
				CountyName = "KILIFI",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.TanaRiverCountyGuid,
				CountyName = "TANA RIVER",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.LamuCountyGuid,
				CountyName = "LAMU",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.TaitaTavetaCountyGuid,
				CountyName = "TAITA TAVETA",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.GarissaCountyGuid,
				CountyName = "GARISSA",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.WajirCountyGuid,
				CountyName = "WAJIR",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.ManderaCountyGuid,
				CountyName = "MANDERA",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.MarsabitCountyGuid,
				CountyName = "MARSABIT",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.IsioloCountyGuid,
				CountyName = "ISIOLO",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.MeruCountyGuid,
				CountyName = "MERU",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.TharakaNithiCountyGuid,
				CountyName = "THARAKA-NITHI",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.EmbuCountyGuid,
				CountyName = "EMBU",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.KituiCountyGuid,
				CountyName = "KITUI",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.MachakosCountyGuid,
				CountyName = "MACHAKOS",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.MakueniCountyGuid,
				CountyName = "MAKUENI",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.NyandaruaCountyGuid,
				CountyName = "NYANDARUA",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.NyeriCountyGuid,
				CountyName = "NYERI",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.KirinyagaCountyGuid,
				CountyName = "KIRINYAGA",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.MurangaCountyGuid,
				CountyName = "MURANG'A",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.KiambuCountyGuid,
				CountyName = "KIAMBU",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.TurkanaCountyGuid,
				CountyName = "TURKANA",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.WestPokotCountyGuid,
				CountyName = "WEST POKOT",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.SamburuCountyGuid,
				CountyName = "SAMBURU",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.TransNzoiaCountyGuid,
				CountyName = "TRANS NZOIA",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.UasinGishuCountyGuid,
				CountyName = "UASIN GISHU",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.ElgeyoMarakwetCountyGuid,
				CountyName = "ELGEYO/MARAKWET",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.NandiCountyGuid,
				CountyName = "NANDI",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.BaringoCountyGuid,
				CountyName = "BARINGO",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.LaikipiaCountyGuid,
				CountyName = "LAIKIPIA",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.NakuruCountyGuid,
				CountyName = "NAKURU",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.NarokCountyGuid,
				CountyName = "NAROK",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.KajiadoCountyGuid,
				CountyName = "KAJIADO",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.KerichoCountyGuid,
				CountyName = "KERICHO",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.BometCountyGuid,
				CountyName = "BOMET",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.KakamegaCountyGuid,
				CountyName = "KAKAMEGA",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.VihigaCountyGuid,
				CountyName = "VIHIGA",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.BungomaCountyGuid,
				CountyName = "BUNGOMA",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.BusiaCountyGuid,
				CountyName = "BUSIA",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.SiayaCountyGuid,
				CountyName = "SIAYA",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.KisumuCountyGuid,
				CountyName = "KISUMU",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.HomaBayCountyGuid,
				CountyName = "HOMA BAY",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.MigoriCountyGuid,
				CountyName = "MIGORI",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.KisiiCountyGuid,
				CountyName = "KISII",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.NyamiraCountyGuid,
				CountyName = "NYAMIRA",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			},
			new County
			{
				Id = EntityIds.NairobiCountyGuid,
				CountyName = "NAIROBI",
				DateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
			});
	}
	
	
}