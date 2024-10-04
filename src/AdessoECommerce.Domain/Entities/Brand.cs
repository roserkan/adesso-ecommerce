using AdessoECommerce.Shared.Domain.Entities;

namespace AdessoECommerce.Domain.Entities;

public class Brand : BaseEntity
{
    public string Name { get; set; }
    public ICollection<Product> Products { get; set; }
}