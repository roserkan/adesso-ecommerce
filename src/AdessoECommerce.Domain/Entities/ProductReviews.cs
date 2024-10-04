using AdessoECommerce.Shared.Domain.Entities;

namespace AdessoECommerce.Domain.Entities;

public class ProductReviews : BaseEntity
{
    public int Rating { get; set; }
    public string Comment { get; set; }
    
    // Foreign Key
    public Guid CustomerId { get; set; }
    public Guid ProductId { get; set; }
    
    // Navigation Properties
    public Customer Customer { get; set; }
    public Product Product { get; set; }
}