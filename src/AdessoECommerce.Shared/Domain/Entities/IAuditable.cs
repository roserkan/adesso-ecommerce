namespace AdessoECommerce.Shared.Domain.Entities;

public interface IAuditable
{
    Guid? CreatedBy { get; set; }
    Guid? UpdatedBy { get; set; }
}