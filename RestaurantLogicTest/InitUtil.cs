using RestaurantLogic.Models;
using Microsoft.EntityFrameworkCore;

namespace AspRestaurant;

public static class InitUtil
{
    public static void ResetTables()
    {
        ClearAllOrders();
        InitTablesAndItems();
    }
    private static void InitTablesAndItems()
    {
        using var context = new RestaurantContext(MyConfig.ConnStr);
        context.Tables.ExecuteDelete();
        context.Items.ExecuteDelete();

        context.Tables.AddRange([
            new Table(1, 0),
            new Table(2, 0),
            new Table(3, 0),
            new Table(4, 0),
        ]);
        context.Items.AddRange([
            new Item(1, "Steak", 120m),
            new Item(2, "Noodle", 60m),
            new Item(3, "Fried Rice", 80m),
        ]);
        context.SaveChanges();
    }

    private static void ClearAllOrders()
    {
        using var context = new RestaurantContext(MyConfig.ConnStr);
        context.OrderItems.ExecuteDelete();
        context.Orders.ExecuteDelete();
    }
}
