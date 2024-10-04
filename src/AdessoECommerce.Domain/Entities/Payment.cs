using AdessoECommerce.Domain.Enums;
using AdessoECommerce.Shared.Domain.Entities;

namespace AdessoECommerce.Domain.Entities;

public class Payment : BaseEntity
{
    public decimal Amount { get; set; }
    public PaymentStatus Status { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public DateTimeOffset PaymentDate { get; set; }
    public string TransactionId { get; set; }
    
    // Foreign Key
    public Guid OrderId { get; set; }
    
    // Navigation Property
    public Order Order { get; set; }
}