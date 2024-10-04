using AdessoECommerce.Shared.Domain.Entities;

namespace AdessoECommerce.Domain.Entities;

public class ShoppingCartItem : BaseEntity
{
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    
    // Foreign Key
    public Guid ShoppingCartId { get; set; }
    public Guid ProductId { get; set; }
    
    // Navigation Properties
    public ShoppingCart ShoppingCart { get; set; }
    public Product Product { get; set; }
}