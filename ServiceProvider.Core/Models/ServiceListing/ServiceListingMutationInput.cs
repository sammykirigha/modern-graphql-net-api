using HotChocolate;
using ServiceProvider.Core.Attributes;
using ServiceProvider.Core.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServiceProvider.Core.Models;

public record ServiceListingMutationInput(
	[property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> Id, 
	[property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> CustomServiceId,
	[property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> ServiceProviderId,
	[property: DefaultValue(0.00)] Optional<double> BasePrice,
	[property: DefaultValue(PaymentModes.Custom)] Optional<string> PaymentMode,
	[property: DefaultValue("")] Optional<string> BusinessName,
	[property: DefaultValue("")] Optional<string> BusinessDescription,
	
	[property: Required]
	IEnumerable<Guid> ServiceIds,

[property: DefaultDateValue] Optional<DateTime> DateCreated,
	[property: DefaultDateValue] Optional<DateTime> DateModified);