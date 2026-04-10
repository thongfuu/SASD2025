using Microsoft.EntityFrameworkCore;
using RestaurantLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLogic;

public class DomainLogic
{
    string connectionString;
    public DomainLogic(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public Order GetCurrentOrder(int tableId)
    {
        using var context = new RestaurantContext(connectionString);
        var order = context.Orders
            .Where(o => o.TableId == tableId)
            .OrderByDescending(o => o.Id)
            .Include(o => o.OrderItems)     // need this
            .First();
        return order;
    }

    // precondition : table.Status is 0-Available
    public void NewOrder(int tableId, List<OrderItemFlat> items)
    {
        using var context = new RestaurantContext(connectionString);
        context.Database.BeginTransaction();

        var table = context.Tables.Where(t => t.Id == tableId).Single();
        if (table.Status != 0)
            throw new Exception("New order cannot be done: Table is not 'Available'.");

        var order = new Order(tableId, DateTime.Now);
        for (int i = 0; i < items.Count; i++)
            order.OrderItems.Add(new OrderItem(0, items[i].ItemId, items[i].Count, false));
        context.Orders.Add(order);
        context.SaveChanges();

        context.Database.CommitTransaction();
    }

    // precondition : table.Status is 1-Occupied
    public void AddToExistOrder(int tableId, List<OrderItemFlat> items)
    {
        // todo:
    }
}
