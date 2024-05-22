using ServiceProvider.Core.Enums;
using ServiceProvider.Core.Interfaces.Models;
using System.Text.Json.Serialization;
using System.Transactions;

namespace ServiceProvider.Core.Models;

public partial class Payment: IEntity
{
    /// <summary>
    /// Primary key
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// TransactionCode
    /// </summary>
    public string TransactionCode {get; set;} = "";
    /// <summary>
    /// Amount
    /// </summary>
    public decimal Amount {get; set;}
    /// <summary>
    /// PaymentDate  record changed
    /// </summary>
    public DateTime PaymentDate  { get; set; } = DateTime.UtcNow;
    /// <summary>
    /// PaymentMethod
    /// </summary>
    public PaymentMethod PaymentMethod  { get; set; }
    /// <summary>
    /// PaymentMethod
    /// </summary>
    public PaymentStatus Status { get; set; }
    /// <summary>
    /// Currency
    /// </summary>
    public Currency Currency { get; set; }
    /// <summary>
    /// User Id foreign key
    /// </summary>
    public Guid UserId  { get; set; }
    /// <summary>
    /// Date/time record created
    /// </summary>
    public DateTime DateModified { get; set; }

    /// <summary>
    /// Last date/time record changed
    /// </summary>
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    [JsonIgnore] public virtual User User { get; set; }

}