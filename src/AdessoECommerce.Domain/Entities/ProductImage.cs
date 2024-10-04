using AdessoECommerce.Shared.Domain.Entities;

namespace AdessoECommerce.Domain.Entities;

public class ProductImage : BaseEntity
{
    public string Url { get; set; }
    
    // Foreign Key
    public Guid ProductId { get; set; }
    
    // Navigation Property
    public Product Product { get; set; }
}