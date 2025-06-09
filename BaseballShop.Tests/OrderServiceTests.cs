using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaseballShop.Models;
using BaseballShop.Data;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// Unit tests for the <see cref="OrderService"/> class.
/// </summary>
[TestClass]
public class OrderServiceTests
{
    /// <summary>
    /// Tests whether the <see cref="OrderService.CreateOrder"/> method correctly adds an order to the database.
    /// </summary>
    [TestMethod]
    public void CreateOrder_Should_Add_Order_To_Database()
    {
        var options = new DbContextOptionsBuilder<BaseballShopContext>()
            .UseInMemoryDatabase(databaseName: "TestDB").Options;

        using (var context = new BaseballShopContext(options))
        {
            var service = new OrderService(context);

            /// <summary>
            /// Creates an order and verifies its properties.
            /// </summary>
            var order = service.CreateOrder("John Doe", 99.99m);

            Assert.IsNotNull(order);
            Assert.AreEqual("John Doe", order.CustomerName);
            Assert.AreEqual(99.99m, order.TotalPrice);
            Assert.AreEqual("Pending", order.Status);
        }
    }
}