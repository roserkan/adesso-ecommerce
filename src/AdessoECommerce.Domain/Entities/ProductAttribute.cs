using AdessoECommerce.Shared.Domain.Entities;

namespace AdessoECommerce.Domain.Entities;

public class ProductAttribute : BaseEntity
{
    public string Value { get; set; }

    // Foreign Keys
    public Guid ProductId { get; set; }
    public Guid AttributeId { get; set; }

    // Navigation Properties
    public Product Product { get; set; }
    public Attribute Attribute { get; set; }
}