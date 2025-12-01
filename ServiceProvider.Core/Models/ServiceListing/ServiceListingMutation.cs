using HotChocolate;
using ServiceProvider.Core.Attributes;
using System.ComponentModel;

namespace ServiceProvider.Core.Models;

public record ServiceListingMutation(
	[property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> Id, 
	[property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> BookingId,
	[property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> ServiceId,
	[property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> CustomServiceId,
	[property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> ReviewId,
	[property: DefaultValue(0.00)] Optional<double> BasePrice,

	[property: DefaultDateValue] Optional<DateTime> DateCreated,
	[property: DefaultDateValue] Optional<DateTime> DateModified);