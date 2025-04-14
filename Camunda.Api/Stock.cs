using System.Collections.ObjectModel;

namespace CamundaApi;


public static class Stock 
{
    private static readonly IReadOnlyCollection<StockItem> _items = InitializeStock();

    private static StockItem[] InitializeStock()
    {
        return
        [
            new StockItem(ItemType.Keyboard, 5),
            new StockItem(ItemType.Mouse, 10)
        ];
    }



    internal static bool IsAvailable(StockItem item) 
        => _items.Any(itm => itm.Type == item.Type && itm.Quantity >= item.Quantity);

     internal static bool IsAvailable(IEnumerable<StockItem> items)
        => items.All(itm => IsAvailable(itm)); 
}