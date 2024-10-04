using AdessoECommerce.Shared.Utils.Pagination;

namespace AdessoECommerce.Shared.Utils.Responses;

public class PaginatedResponse<T> : BasePageableModel
{
    public IList<T> Items
    {
        get => _items ??= new List<T>();
        set => _items = value;
    }

    private IList<T>? _items;
}