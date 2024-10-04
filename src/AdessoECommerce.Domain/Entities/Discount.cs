using AdessoECommerce.Domain.Enums;
using AdessoECommerce.Shared.Domain.Entities;

namespace AdessoECommerce.Domain.Entities;

public class Discount : BaseEntity
{
    public string Name { get; set; }  
    public decimal? Amount { get; set; }  
    public decimal? Percentage { get; set; }  
    public DateTimeOffset StartDate { get; set; }  
    public DateTimeOffset EndDate { get; set; } 

    public DiscountType DiscountType { get; set; }

    // Foreign Key (Optional)
    public Guid? ProductId { get; set; }
    public Guid? CategoryId { get; set; }
    
    // Navigation Properties
    public Product Product { get; set; }
    public Category Category { get; set; }
}