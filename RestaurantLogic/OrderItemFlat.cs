namespace RestaurantLogic;

public class OrderItemFlat
{
    public int ItemId { get; set; }
    public int Count { get; set; }

    public OrderItemFlat(int itemId, int count)
    {
        ItemId = itemId;
        Count = count;
    }
}
