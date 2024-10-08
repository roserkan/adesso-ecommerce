using AdessoECommerce.Shared.Domain.Entities;

namespace AdessoECommerce.Domain.Entities;

public class Attribute : BaseEntity
{
    public string Name { get; set; }
    public ICollection<ProductAttribute> ProductAttributes { get; set; }
}