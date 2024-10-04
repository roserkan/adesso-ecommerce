namespace AdessoECommerce.Shared.Domain.Entities;

public interface ISoftDeletable
{
    bool IsDeleted { get; set; }
}