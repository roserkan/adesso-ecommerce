using AdessoECommerce.Shared.Domain.Entities;

namespace AdessoECommerce.Domain.Entities;

public class Address : BaseEntity
{
    public string Title { get; set; }
    public string AddressLine { get; set; }
    public string City { get; set; }
    public string District { get; set; }
    public string PhoneNumber { get; set; }
    public string? Description { get; set; }
    public bool IsDefault { get; set; }
    
    // Foreign Key
    public Guid CustomerId { get; set; }
    
    // Navigation Properties
    public Customer Customer { get; set; }
}