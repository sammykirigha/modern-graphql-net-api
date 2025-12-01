using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Seeding;

public static partial class ConstituencySeeding
{
	public static void AddConstituencySeeding(ModelBuilder builder)
	{ 
		builder.Entity<Constituency>().HasData(
		new Constituency
	{
	    Id = EntityIds.ChangamweGuid,
	    CountyId = EntityIds.MombasaCountyGuid,
	    ConstituencyName = "Changamwe",
	    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	},
	new Constituency
	{
	    Id = EntityIds.JomvuGuid,
	    CountyId = EntityIds.MombasaCountyGuid,
	    ConstituencyName = "Jomvu",
	    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	},
	
	new Constituency
	{
	    Id = EntityIds.KisauniGuid,
	    CountyId = EntityIds.MombasaCountyGuid,
	    ConstituencyName = "Kisauni",
	    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	},
	
	new Constituency
	{
	    Id = EntityIds.NyaliGuid,
	    CountyId = EntityIds.MombasaCountyGuid,
	    ConstituencyName = "Nyali",
	    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	},
	
	new Constituency
	{
	    Id = EntityIds.LikoniGuid,
	    CountyId = EntityIds.MombasaCountyGuid,
	    ConstituencyName = "Likoni",
	    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	},
	
	new Constituency
	{
		Id = EntityIds.MvitaGuid,
		CountyId = EntityIds.MombasaCountyGuid,
		ConstituencyName = "Mvita",
		DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
		DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	},
	

	// --- Kwale County ---
			new Constituency
			{
				Id = EntityIds.MsambweniGuid,
				CountyId = EntityIds.KwaleCountyGuid,
				ConstituencyName = "Msambweni",
				DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
			},
			
	new Constituency
	{
		Id = EntityIds.LungalungaGuid,
		CountyId = EntityIds.KwaleCountyGuid,
		ConstituencyName = "Lungalunga",
		DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
		DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	},
	
	new Constituency
	{
		Id = EntityIds.MatugaGuid,
		CountyId = EntityIds.KwaleCountyGuid,
		ConstituencyName = "Matuga",
		DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
		DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	},
	
	new Constituency
	{
		Id = EntityIds.KinangoGuid,
		CountyId = EntityIds.KwaleCountyGuid,
		ConstituencyName = "Kinango",
		DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
		DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	},
	

	// --- Kilifi County ---
			new Constituency
			{
				Id = EntityIds.KilifiNorthGuid,
				CountyId = EntityIds.KilifiCountyGuid,
				ConstituencyName = "Kilifi North",
				DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
				DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
			},
			
	new Constituency
	{
		Id = EntityIds.KilifiSouthGuid,
		CountyId = EntityIds.KilifiCountyGuid,
		ConstituencyName = "Kilifi South",
		DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
		DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	},
	
	new Constituency
	{
		Id = EntityIds.GanzeGuid,
		CountyId = EntityIds.KilifiCountyGuid,
		ConstituencyName = "Ganze",
		DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
		DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	},
	
	new Constituency
	{
		Id = EntityIds.MalindiGuid,
		CountyId = EntityIds.KilifiCountyGuid,
		ConstituencyName = "Malindi",
		DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
		DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	},
	
	new Constituency
	{
		Id = EntityIds.MagariniGuid,
		CountyId = EntityIds.KilifiCountyGuid,
		ConstituencyName = "Magarini",
		DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
		DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	},
	
	new Constituency
	{
		Id = EntityIds.RabaiGuid,
		CountyId = EntityIds.KilifiCountyGuid,
		ConstituencyName = "Rabai",
		DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
		DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	},
	
	
	// --- Tana },
new Constituency
{
    Id = EntityIds.GarsenGuid,
    CountyId = EntityIds.TanaRiverCountyGuid,
    ConstituencyName = "Garsen",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},
	
new Constituency
{
    Id = EntityIds.GaloleGuid,
    CountyId = EntityIds.TanaRiverCountyGuid,
    ConstituencyName = "Galole",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.BuraGuid,
	CountyId = EntityIds.TanaRiverCountyGuid,
	ConstituencyName = "Bura",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Lamu C},
new Constituency
{
    Id = EntityIds.LamuEastGuid,
    CountyId = EntityIds.LamuCountyGuid,
    ConstituencyName = "Lamu East",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.LamuWestGuid,
	CountyId = EntityIds.LamuCountyGuid,
	ConstituencyName = "Lamu West",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Taita Ta},
new Constituency
{
    Id = EntityIds.TavetaGuid,
    CountyId = EntityIds.TaitaTavetaCountyGuid,
    ConstituencyName = "Taveta",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.WundanyiGuid,
    CountyId = EntityIds.TaitaTavetaCountyGuid,
    ConstituencyName = "Wundanyi",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.MwatateGuid,
    CountyId = EntityIds.TaitaTavetaCountyGuid,
    ConstituencyName = "Mwatate",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.VoiGuid,
	CountyId = EntityIds.TaitaTavetaCountyGuid,
	ConstituencyName = "Voi",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Garissa },
new Constituency
{
    Id = EntityIds.DaadabGuid,
    CountyId = EntityIds.GarissaCountyGuid,
    ConstituencyName = "Daadab",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.GarissaTownGuid,
    CountyId = EntityIds.GarissaCountyGuid,
    ConstituencyName = "Garissa Township",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.BalambalaGuid,
    CountyId = EntityIds.GarissaCountyGuid,
    ConstituencyName = "Balambala",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.LagderaGuid,
    CountyId = EntityIds.GarissaCountyGuid,
    ConstituencyName = "Lagdera",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.FafiGuid,
    CountyId = EntityIds.GarissaCountyGuid,
    ConstituencyName = "Fafi",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.IjaraGuid,
	CountyId = EntityIds.GarissaCountyGuid,
	ConstituencyName = "Ijara",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Wajir Co},
new Constituency
{
    Id = EntityIds.WajirNorthGuid,
    CountyId = EntityIds.WajirCountyGuid,
    ConstituencyName = "Wajir North",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.WajirEastGuid,
    CountyId = EntityIds.WajirCountyGuid,
    ConstituencyName = "Wajir East",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.TarbajGuid,
    CountyId = EntityIds.WajirCountyGuid,
    ConstituencyName = "Tarbaj",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.WajirWestGuid,
    CountyId = EntityIds.WajirCountyGuid,
    ConstituencyName = "Wajir West",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.EldasGuid,
    CountyId = EntityIds.WajirCountyGuid,
    ConstituencyName = "Eldas",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.WajirSouthGuid,
	CountyId = EntityIds.WajirCountyGuid,
	ConstituencyName = "Wajir South",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Mandera},
new Constituency
{
    Id = EntityIds.ManderaWestGuid,
    CountyId = EntityIds.ManderaCountyGuid,
    ConstituencyName = "Mandera West",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.BanissaGuid,
    CountyId = EntityIds.ManderaCountyGuid,
    ConstituencyName = "Banissa",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.ManderaNorthGuid,
    CountyId = EntityIds.ManderaCountyGuid,
    ConstituencyName = "Mandera North",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.ManderaSouthGuid,
    CountyId = EntityIds.ManderaCountyGuid,
    ConstituencyName = "Mandera South",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.ManderaEastGuid,
    CountyId = EntityIds.ManderaCountyGuid,
    ConstituencyName = "Mandera East",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.LafeyGuid,
	CountyId = EntityIds.ManderaCountyGuid,
	ConstituencyName = "Lafey",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Marsabit},
new Constituency
{
    Id = EntityIds.MoyaleGuid,
    CountyId = EntityIds.MarsabitCountyGuid,
    ConstituencyName = "Moyale",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.NorthHorrGuid,
    CountyId = EntityIds.MarsabitCountyGuid,
    ConstituencyName = "North Horr",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.SakuGuid,
    CountyId = EntityIds.MarsabitCountyGuid,
    ConstituencyName = "Saku",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.LaisamisGuid,
	CountyId = EntityIds.MarsabitCountyGuid,
	ConstituencyName = "Laisamis",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Isiolo Co},
new Constituency
{
    Id = EntityIds.IsioloNorthGuid,
    CountyId = EntityIds.IsioloCountyGuid,
    ConstituencyName = "Isiolo North",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.IsioloSouthGuid,
	CountyId = EntityIds.IsioloCountyGuid,
	ConstituencyName = "Isiolo South",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Meru Co},
new Constituency
{
    Id = EntityIds.IgembeSouthGuid,
    CountyId = EntityIds.MeruCountyGuid,
    ConstituencyName = "Igembe South",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.IgembeCentralGuid,
    CountyId = EntityIds.MeruCountyGuid,
    ConstituencyName = "Igembe Central",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.IgembeNorthGuid,
    CountyId = EntityIds.MeruCountyGuid,
    ConstituencyName = "Igembe North",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.TiganiaWestGuid,
    CountyId = EntityIds.MeruCountyGuid,
    ConstituencyName = "Tigania West",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.TiganiaEastGuid,
    CountyId = EntityIds.MeruCountyGuid,
    ConstituencyName = "Tigania East",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.NorthImentiGuid,
    CountyId = EntityIds.MeruCountyGuid,
    ConstituencyName = "North Imenti",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.BuuriGuid,
    CountyId = EntityIds.MeruCountyGuid,
    ConstituencyName = "Buuri",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.CentralImentiGuid,
    CountyId = EntityIds.MeruCountyGuid,
    ConstituencyName = "Central Imenti",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.SouthImentiGuid,
	CountyId = EntityIds.MeruCountyGuid,
	ConstituencyName = "South Imenti",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Tharaka},
new Constituency
{
    Id = EntityIds.MaaraGuid,
    CountyId = EntityIds.TharakaNithiCountyGuid,
    ConstituencyName = "Maara",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.ChukaIgambangombeGuid,
    CountyId = EntityIds.TharakaNithiCountyGuid,
    ConstituencyName = "Chuka/Igambang'ombe",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.TharakaGuid,
	CountyId = EntityIds.TharakaNithiCountyGuid,
	ConstituencyName = "Tharaka",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Embu C},
new Constituency
{
    Id = EntityIds.ManyattaGuid,
    CountyId = EntityIds.EmbuCountyGuid,
    ConstituencyName = "Manyatta",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.RunyenjesGuid,
    CountyId = EntityIds.EmbuCountyGuid,
    ConstituencyName = "Runyenjes",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.MbeereSouthGuid,
    CountyId = EntityIds.EmbuCountyGuid,
    ConstituencyName = "Mbeere South",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.MbeereNorthGuid,
	CountyId = EntityIds.EmbuCountyGuid,
	ConstituencyName = "Mbeere North",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Kitui Co},
new Constituency
{
    Id = EntityIds.MwingiNorthGuid,
    CountyId = EntityIds.KituiCountyGuid,
    ConstituencyName = "Mwingi North",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.MwingiCentralGuid,
    CountyId = EntityIds.KituiCountyGuid,
    ConstituencyName = "Mwingi Central",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.MwingiWestGuid,
    CountyId = EntityIds.KituiCountyGuid,
    ConstituencyName = "Mwingi West",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.KituiWestGuid,
    CountyId = EntityIds.KituiCountyGuid,
    ConstituencyName = "Kitui West",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.KituiRuralGuid,
    CountyId = EntityIds.KituiCountyGuid,
    ConstituencyName = "Kitui Rural",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.KituiCentralGuid,
    CountyId = EntityIds.KituiCountyGuid,
    ConstituencyName = "Kitui Central",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.KituiEastGuid,
    CountyId = EntityIds.KituiCountyGuid,
    ConstituencyName = "Kitui East",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.KituiSouthGuid,
	CountyId = EntityIds.KituiCountyGuid,
	ConstituencyName = "Kitui South",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Machako; County ---
new Constituency
{
    Id = EntityIds.KathianiGuid,
    CountyId = EntityIds.MachakosCountyGuid,
    ConstituencyName = "Kathiani",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.MavokoGuid,
    CountyId = EntityIds.MachakosCountyGuid,
    ConstituencyName = "Mavoko",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.MachakosTownGuid,
    CountyId = EntityIds.MachakosCountyGuid,
    ConstituencyName = "Machakos Town",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.MasingaGuid,
    CountyId = EntityIds.MachakosCountyGuid,
    ConstituencyName = "Masinga",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.YattaGuid,
    CountyId = EntityIds.MachakosCountyGuid,
    ConstituencyName = "Yatta",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.KangundoGuid,
    CountyId = EntityIds.MachakosCountyGuid,
    ConstituencyName = "Kangundo",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.MatunguluGuid,
    CountyId = EntityIds.MachakosCountyGuid,
    ConstituencyName = "Matungulu",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.MwalaGuid,
	CountyId = EntityIds.MachakosCountyGuid,
	ConstituencyName = "Mwala",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Makueni ;ounty ---
new Constituency
{
    Id = EntityIds.KibweziWestGuid,
    CountyId = EntityIds.MakueniCountyGuid,
    ConstituencyName = "Kibwezi West",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.KibweziEastGuid,
    CountyId = EntityIds.MakueniCountyGuid,
    ConstituencyName = "Kibwezi East",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.KaitiGuid,
    CountyId = EntityIds.MakueniCountyGuid,
    ConstituencyName = "Kaiti",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.MakueniGuid,
    CountyId = EntityIds.MakueniCountyGuid,
    ConstituencyName = "Makueni",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.KilomeGuid,
    CountyId = EntityIds.MakueniCountyGuid,
    ConstituencyName = "Kilome",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.MbooniGuid,
	CountyId = EntityIds.MakueniCountyGuid,
	ConstituencyName = "Mbooni",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Nyandar;a County ---
new Constituency
{
    Id = EntityIds.KipipiriGuid,
    CountyId = EntityIds.NyandaruaCountyGuid,
    ConstituencyName = "Kipipiri",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.OlKalouGuid,
    CountyId = EntityIds.NyandaruaCountyGuid,
    ConstituencyName = "Ol Kalou",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.OlJorokGuid,
    CountyId = EntityIds.NyandaruaCountyGuid,
    ConstituencyName = "Ol Jorok",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.NdaragwaGuid,
	CountyId = EntityIds.NyandaruaCountyGuid,
	ConstituencyName = "Ndaragwa",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Nyeri Co;nty ---
new Constituency
{
    Id = EntityIds.TetuGuid,
    CountyId = EntityIds.NyeriCountyGuid,
    ConstituencyName = "Tetu",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.KieniGuid,
    CountyId = EntityIds.NyeriCountyGuid,
    ConstituencyName = "Kieni",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.MathiraGuid,
    CountyId = EntityIds.NyeriCountyGuid,
    ConstituencyName = "Mathira",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.OthayaGuid,
    CountyId = EntityIds.NyeriCountyGuid,
    ConstituencyName = "Othaya",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.MukurweiniGuid,
    CountyId = EntityIds.NyeriCountyGuid,
    ConstituencyName = "Mukurweini",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.NyeriTownGuid,
	CountyId = EntityIds.NyeriCountyGuid,
	ConstituencyName = "Nyeri Town",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Kirinyaga;County ---
new Constituency
{
    Id = EntityIds.MweaGuid,
    CountyId = EntityIds.KirinyagaCountyGuid,
    ConstituencyName = "Mwea",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.GichuguGuid,
    CountyId = EntityIds.KirinyagaCountyGuid,
    ConstituencyName = "Gichugu",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.NdiaGuid,
    CountyId = EntityIds.KirinyagaCountyGuid,
    ConstituencyName = "Ndia",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.KirinyagaCentralGuid,
	CountyId = EntityIds.KirinyagaCountyGuid,
	ConstituencyName = "Kirinyaga Central",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Murang'a;County ---
new Constituency
{
    Id = EntityIds.KangemaGuid,
    CountyId = EntityIds.MurangaCountyGuid,
    ConstituencyName = "Kangema",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.MathioyaGuid,
    CountyId = EntityIds.MurangaCountyGuid,
    ConstituencyName = "Mathioya",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.KiharuGuid,
    CountyId = EntityIds.MurangaCountyGuid,
    ConstituencyName = "Kiharu",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.KigumoGuid,
    CountyId = EntityIds.MurangaCountyGuid,
    ConstituencyName = "Kigumo",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.MaragwaGuid,
    CountyId = EntityIds.MurangaCountyGuid,
    ConstituencyName = "Maragwa",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.KandaraGuid,
    CountyId = EntityIds.MurangaCountyGuid,
    ConstituencyName = "Kandara",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.GatangaGuid,
	CountyId = EntityIds.MurangaCountyGuid,
	ConstituencyName = "Gatanga",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Kiambu C;unty ---
new Constituency
{
    Id = EntityIds.GatunduSouthGuid,
    CountyId = EntityIds.KiambuCountyGuid,
    ConstituencyName = "Gatundu South",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.GatunduNorthGuid,
    CountyId = EntityIds.KiambuCountyGuid,
    ConstituencyName = "Gatundu North",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.JujaGuid,
    CountyId = EntityIds.KiambuCountyGuid,
    ConstituencyName = "Juja",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.ThikaTownGuid,
    CountyId = EntityIds.KiambuCountyGuid,
    ConstituencyName = "Thika Town",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.RuiruGuid,
    CountyId = EntityIds.KiambuCountyGuid,
    ConstituencyName = "Ruiru",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.GithunguriGuid,
    CountyId = EntityIds.KiambuCountyGuid,
    ConstituencyName = "Githunguri",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.KiambaaGuid,
    CountyId = EntityIds.KiambuCountyGuid,
    ConstituencyName = "Kiambaa",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.KabeteGuid,
    CountyId = EntityIds.KiambuCountyGuid,
    ConstituencyName = "Kabete",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.KikuyuGuid,
    CountyId = EntityIds.KiambuCountyGuid,
    ConstituencyName = "Kikuyu",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.LimuruGuid,
    CountyId = EntityIds.KiambuCountyGuid,
    ConstituencyName = "Limuru",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.LariGuid,
    CountyId = EntityIds.KiambuCountyGuid,
    ConstituencyName = "Lari",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.KiambuGuid,
	CountyId = EntityIds.KiambuCountyGuid,
	ConstituencyName = "Kiambu",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Turkana ;ounty ---
new Constituency
{
    Id = EntityIds.TurkanaNorthGuid,
    CountyId = EntityIds.TurkanaCountyGuid,
    ConstituencyName = "Turkana North",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.TurkanaWestGuid,
    CountyId = EntityIds.TurkanaCountyGuid,
    ConstituencyName = "Turkana West",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.TurkanaCentralGuid,
    CountyId = EntityIds.TurkanaCountyGuid,
    ConstituencyName = "Turkana Central",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.LoimaGuid,
    CountyId = EntityIds.TurkanaCountyGuid,
    ConstituencyName = "Loima",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.TurkanaSouthGuid,
    CountyId = EntityIds.TurkanaCountyGuid,
    ConstituencyName = "Turkana South",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.TurkanaEastGuid,
	CountyId = EntityIds.TurkanaCountyGuid,
	ConstituencyName = "Turkana East",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- West Pok;t County ---
new Constituency
{
    Id = EntityIds.KapenguriaGuid,
    CountyId = EntityIds.WestPokotCountyGuid,
    ConstituencyName = "Kapenguria",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.SigorGuid,
    CountyId = EntityIds.WestPokotCountyGuid,
    ConstituencyName = "Sigor",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.KachelibaGuid,
    CountyId = EntityIds.WestPokotCountyGuid,
    ConstituencyName = "Kacheliba",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.PokotSouthGuid,
	CountyId = EntityIds.WestPokotCountyGuid,
	ConstituencyName = "Pokot South",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Samburu;County ---
new Constituency
{
    Id = EntityIds.SamburuWestGuid,
    CountyId = EntityIds.SamburuCountyGuid,
    ConstituencyName = "Samburu West",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.SamburuNorthGuid,
    CountyId = EntityIds.SamburuCountyGuid,
    ConstituencyName = "Samburu North",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.SamburuEastGuid,
	CountyId = EntityIds.SamburuCountyGuid,
	ConstituencyName = "Samburu East",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Trans Nz;ia County ---
new Constituency
{
    Id = EntityIds.KwanzaGuid,
    CountyId = EntityIds.TransNzoiaCountyGuid,
    ConstituencyName = "Kwanza",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.EndebessGuid,
    CountyId = EntityIds.TransNzoiaCountyGuid,
    ConstituencyName = "Endebess",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.SabotiGuid,
    CountyId = EntityIds.TransNzoiaCountyGuid,
    ConstituencyName = "Saboti",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.KimininiGuid,
    CountyId = EntityIds.TransNzoiaCountyGuid,
    ConstituencyName = "Kiminini",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.CheranganyGuid,
	CountyId = EntityIds.TransNzoiaCountyGuid,
	ConstituencyName = "Cherangany",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Uasin Gis;u County ---
new Constituency
{
    Id = EntityIds.SoyGuid,
    CountyId = EntityIds.UasinGishuCountyGuid,
    ConstituencyName = "Soy",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.TurboGuid,
    CountyId = EntityIds.UasinGishuCountyGuid,
    ConstituencyName = "Turbo",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.MoibenGuid,
    CountyId = EntityIds.UasinGishuCountyGuid,
    ConstituencyName = "Moiben",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.AinabkoiGuid,
    CountyId = EntityIds.UasinGishuCountyGuid,
    ConstituencyName = "Ainabkoi",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.KapseretGuid,
    CountyId = EntityIds.UasinGishuCountyGuid,
    ConstituencyName = "Kapseret",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.KessesGuid,
	CountyId = EntityIds.UasinGishuCountyGuid,
	ConstituencyName = "Kesses",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Elgeyo M;rakwet County ---
new Constituency
{
    Id = EntityIds.MarakwetEastGuid,
    CountyId = EntityIds.ElgeyoMarakwetCountyGuid,
    ConstituencyName = "Marakwet East",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.MarakwetWestGuid,
    CountyId = EntityIds.ElgeyoMarakwetCountyGuid,
    ConstituencyName = "Marakwet West",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.KeiyoNorthGuid,
    CountyId = EntityIds.ElgeyoMarakwetCountyGuid,
    ConstituencyName = "Keiyo North",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.KeiyoSouthGuid,
	CountyId = EntityIds.ElgeyoMarakwetCountyGuid,
	ConstituencyName = "Keiyo South",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Nandi Co;nty ---
new Constituency
{
    Id = EntityIds.TinderetGuid,
    CountyId = EntityIds.NandiCountyGuid,
    ConstituencyName = "Tinderet",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.NandiHillsGuid,
    CountyId = EntityIds.NandiCountyGuid,
    ConstituencyName = "Nandi Hills",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.ChesumeiGuid,
    CountyId = EntityIds.NandiCountyGuid,
    ConstituencyName = "Chesumei",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.EmgwenGuid,
    CountyId = EntityIds.NandiCountyGuid,
    ConstituencyName = "Emgwen",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.AldaiGuid,
    CountyId = EntityIds.NandiCountyGuid,
    ConstituencyName = "Aldai",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.MosopGuid,
	CountyId = EntityIds.NandiCountyGuid,
	ConstituencyName = "Mosop",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Baringo ;ounty ---
new Constituency
{
    Id = EntityIds.BaringoNorthGuid,
    CountyId = EntityIds.BaringoCountyGuid,
    ConstituencyName = "Baringo North",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.BaringoCentralGuid,
    CountyId = EntityIds.BaringoCountyGuid,
    ConstituencyName = "Baringo Central",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.BaringoSouthGuid,
    CountyId = EntityIds.BaringoCountyGuid,
    ConstituencyName = "Baringo South",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.MogotioGuid,
    CountyId = EntityIds.BaringoCountyGuid,
    ConstituencyName = "Mogotio",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.EldamaRavineGuid,
	CountyId = EntityIds.BaringoCountyGuid,
	ConstituencyName = "Eldama Ravine",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

// --- Laikipia ;ounty ---
new Constituency
{
    Id = EntityIds.LaikipiaWestGuid,
    CountyId = EntityIds.LaikipiaCountyGuid,
    ConstituencyName = "Laikipia West",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.LaikipiaEastGuid,
    CountyId = EntityIds.LaikipiaCountyGuid,
    ConstituencyName = "Laikipia East",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.LaikipiaNorthGuid,
	CountyId = EntityIds.LaikipiaCountyGuid,
	ConstituencyName = "Laikipia North",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},


// --- Nakuru C;unty ---
new Constituency
{
    Id = EntityIds.MoloGuid,
    CountyId = EntityIds.NakuruCountyGuid,
    ConstituencyName = "Molo",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.NjoroGuid,
    CountyId = EntityIds.NakuruCountyGuid,
    ConstituencyName = "Njoro",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.NaivashaGuid,
    CountyId = EntityIds.NakuruCountyGuid,
    ConstituencyName = "Naivasha",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.GilgilGuid,
    CountyId = EntityIds.NakuruCountyGuid,
    ConstituencyName = "Gilgil",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
    Id = EntityIds.KuresoiSouthGuid,
    CountyId = EntityIds.NakuruCountyGuid,
    ConstituencyName = "Kuresoi South",
    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
    DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.KuresoiNorthGuid,
	CountyId = EntityIds.NakuruCountyGuid,
	ConstituencyName = "Kuresoi North",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},



// --- Nakuru C;unty ---
new Constituency
{
	Id = EntityIds.WestlandsGuid,
	CountyId = EntityIds.NairobiCountyGuid,
	ConstituencyName = "Westlands",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.DagorettiNorthGuid,
	CountyId = EntityIds.NairobiCountyGuid,
	ConstituencyName = "Dagoretti North",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.DagorettiSouthGuid,
	CountyId = EntityIds.NairobiCountyGuid,
	ConstituencyName = "Dagoretti South",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.LangataGuid,
	CountyId = EntityIds.NairobiCountyGuid,
	ConstituencyName = "Langata",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.KibraGuid,
	CountyId = EntityIds.NairobiCountyGuid,
	ConstituencyName = "Kibra",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.RoysambuGuid,
	CountyId = EntityIds.NairobiCountyGuid,
	ConstituencyName = "Roysambu",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.KasaraniGuid,
	CountyId = EntityIds.NairobiCountyGuid,
	ConstituencyName = "Kasarani",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.RuarakaGuid,
	CountyId = EntityIds.NairobiCountyGuid,
	ConstituencyName = "Ruaraka",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.EmbakasiNorthGuid,
	CountyId = EntityIds.NairobiCountyGuid,
	ConstituencyName = "Embakasi North",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},
new Constituency
{
	Id = EntityIds.EmbakasiSouthGuid,
	CountyId = EntityIds.NairobiCountyGuid,
	ConstituencyName = "Embakasi South",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},
new Constituency
{
	Id = EntityIds.EmbakasiCentralGuid,
	CountyId = EntityIds.NairobiCountyGuid,
	ConstituencyName = "Embakasi Central",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},
new Constituency
{
	Id = EntityIds.EmbakasiEastGuid,
	CountyId = EntityIds.NairobiCountyGuid,
	ConstituencyName = "Embakasi East",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},

new Constituency
{
	Id = EntityIds.EmbakasiWestGuid,
	CountyId = EntityIds.NairobiCountyGuid,
	ConstituencyName = "Embakasi West",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},
new Constituency
{
	Id = EntityIds.MakadaraGuid,
	CountyId = EntityIds.NairobiCountyGuid,
	ConstituencyName = "Makadara",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},
new Constituency
{
	Id = EntityIds.StareheGuid,
	CountyId = EntityIds.NairobiCountyGuid,
	ConstituencyName = "Starehe",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},
new Constituency
{
	Id = EntityIds.KamukunjiGuid,
	CountyId = EntityIds.NairobiCountyGuid,
	ConstituencyName = "Kamukunji",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
},
new Constituency
{
	Id = EntityIds.MathareGuid,
	CountyId = EntityIds.NairobiCountyGuid,
	ConstituencyName = "Mathare",
	DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
	DateModified = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
}
);

	}
}