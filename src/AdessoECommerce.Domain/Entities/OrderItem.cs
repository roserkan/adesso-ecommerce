using AdessoECommerce.Shared.Domain.Entities;

namespace AdessoECommerce.Domain.Entities;

public class OrderItem : BaseEntity
{
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    
    // Foreign Key
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    
    // Navigation Properties
    public Order Order { get; set; }
    public Product Product { get; set; }
}