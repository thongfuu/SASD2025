using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLogic.Models;

public partial class Item
{
    public Item(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}

public partial class Table
{
    public Table(int id, int status)
    {
        Id = id;
        Status = status;
    }
}

public partial class Order
{
    public Order(int tableId, DateTime openAt)
    {
        TableId = tableId;
        OpenAt = openAt;
    }
}

public partial class OrderItem
{
    public OrderItem(int orderId, int itemId, int count, bool isPrinted)
    {
        OrderId = orderId;
        ItemId = itemId;
        Count = count;
        IsPrinted = isPrinted;
    }
}