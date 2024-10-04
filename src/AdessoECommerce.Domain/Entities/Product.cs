using AdessoECommerce.Domain.Enums;
using AdessoECommerce.Shared.Domain.Entities;

namespace AdessoECommerce.Domain.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public ProductStatus Status { get; set; }
    
    // Foreign Key
    public Guid CategoryId { get; set; }
    public Guid BrandId { get; set; }
    
    // Navigation Properties
    public Brand Brand { get; set; }
    public ICollection<ProductAttribute> ProductAttributes { get; set; }
    public ICollection<ProductImage> ProductImages { get; set; }
    public ICollection<ProductReviews> Reviews { get; set; }
    public ICollection<Discount> Discounts { get; set; }
}