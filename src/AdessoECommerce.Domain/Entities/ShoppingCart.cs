using AdessoECommerce.Shared.Domain.Entities;

namespace AdessoECommerce.Domain.Entities;

public class ShoppingCart : BaseEntity
{
    public Guid CustomerId { get; set; }
    public decimal TotalPrice { get; set; }
    
    // Navigation Properties
    public Customer Customer { get; set; }
    public ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }
}