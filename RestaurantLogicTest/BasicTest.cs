using AspRestaurant;
using RestaurantLogic;
using RestaurantLogic.Models;

namespace RestaurantLogicTest;

public class BasicTest
{
    [SetUp]
    public void Setup()
    {
        InitUtil.ResetTables();
    }

    [Test]
    public void TestResetTables()
    {
        using var context = new RestaurantContext(MyConfig.ConnStr);
        Assert.That(context.Tables.Count, Is.Positive);
    }

    [Test]
    public void TestNewOrder()
    {
        int tableId = 2;
        List<OrderItemFlat> orderItems = [new OrderItemFlat(1, 2), new OrderItemFlat(3, 1)];

        var domain = new DomainLogic(MyConfig.ConnStr);
        domain.NewOrder(tableId, orderItems);
        var order = domain.GetCurrentOrder(tableId);

        Assert.That(order.TableId, Is.EqualTo(tableId));
        Assert.That(order.OrderItems.Count, Is.EqualTo(orderItems.Count));
    }
}