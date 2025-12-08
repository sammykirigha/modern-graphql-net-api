using System.Text.Json.Serialization;

namespace ServiceProvider.Core.Models.Mpesa;

public class DarajaError
{
	/// <summary>
	///     This is a unique requestID for the payment request
	/// </summary>
	[JsonPropertyName("requestId")]
	public string? RequestId { get; set; }
	/// <summary>
	///     This is a Numeric status code that indicates the type of error that occurred during the transaction submission.
	/// </summary>
	[JsonPropertyName("errorCode")]
	public string? ErrorCode { get; set; }

	/// <summary>
	///     This is a message from the API that gives a description of the error that occurred during the transaction submission.
	/// </summary>
	[JsonPropertyName("errorMessage")]
	public string? ErrorMessage { get; set; }
}