using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaseballShop.Models;
using BaseballShop.Data;
using Microsoft.EntityFrameworkCore;

[TestClass]
public class OrderServiceTests
{
    [TestMethod]
    public void CreateOrder_Should_Add_Order_To_Database()
    {
        var options = new DbContextOptionsBuilder<BaseballShopContext>()
            .UseInMemoryDatabase(databaseName: "TestDB").Options;
        using (var context = new BaseballShopContext(options))
        {
            var service = new OrderService(context);
            var order = service.CreateOrder("John Doe", 99.99m);

            Assert.IsNotNull(order);
            Assert.AreEqual("John Doe", order.CustomerName);
            Assert.AreEqual(99.99m, order.TotalPrice);
            Assert.AreEqual("Pending", order.Status);
        }
    }
}