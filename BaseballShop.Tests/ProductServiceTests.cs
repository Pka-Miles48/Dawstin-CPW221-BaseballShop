using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaseballShop.Services;
using BaseballShop.Models;
using Dawstin_CPW221_BaseballShop.Repositories;

[TestClass]
public class ProductServiceTests
{
    [TestMethod]
    public void GetProductById_Should_Return_Correct_Product()
    {
        // Create a mock repository
        var mockRepo = new Mock<IProductRepository>();

        // Set up mock behavior
        mockRepo.Setup(repo => repo.GetProductById(1))
            .Returns(new Product { ProductID = 1, Name = "Baseball Bat", Price = 49.99m });

        // Inject mock repository into service
        var service = new ProductService(mockRepo.Object);

        // Call method and verify results
        var product = service.GetProductById(1);

        Assert.IsNotNull(product);
        Assert.AreEqual(1, product.ProductID);
        Assert.AreEqual("Baseball Bat", product.Name);
        Assert.AreEqual(49.99m, product.Price);
    }
}