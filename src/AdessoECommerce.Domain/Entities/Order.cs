using AdessoECommerce.Domain.Enums;
using AdessoECommerce.Shared.Domain.Entities;

namespace AdessoECommerce.Domain.Entities;

public class Order : BaseEntity
{
    public string OrderNumber { get; set; }
    public decimal TotalPrice { get; set; }
    public decimal DiscountedTotalPrice { get; set; }  // İndirimli toplam fiyat
    public OrderStatus Status { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public DateTimeOffset OrderDate { get; set; }
    
    // Foreign Key
    public Guid CustomerId { get; set; }
    public Guid AddressId { get; set; }
    
    // Navigation Properties
    public Customer Customer { get; set; }
    public Address Address { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
    public Discount Discount { get; set; }  // Siparişe uygulanan indirim

}