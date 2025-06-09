using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaseballShop.Services;
using BaseballShop.Models;
using Dawstin_CPW221_BaseballShop.Repositories;

/// <summary>
/// Unit tests for the <see cref="ProductService"/> class.
/// </summary>
[TestClass]
public class ProductServiceTests
{
    /// <summary>
    /// Tests whether the <see cref="ProductService.GetProductById"/> method 
    /// correctly returns the expected product.
    /// </summary>
    [TestMethod]
    public void GetProductById_Should_Return_Correct_Product()
    {
        // Create a mock repository
        var mockRepo = new Mock<IProductRepository>();

        /// <summary>
        /// Sets up mock behavior to return a predefined product.
        /// </summary>
        mockRepo.Setup(repo => repo.GetProductById(1))
            .Returns(new Product { ProductID = 1, Name = "Baseball Bat", Price = 49.99m });

        // Inject mock repository into service
        var service = new ProductService(mockRepo.Object);

        /// <summary>
        /// Calls the method and verifies the returned product matches expectations.
        /// </summary>
        var product = service.GetProductById(1);

        Assert.IsNotNull(product);
        Assert.AreEqual(1, product.ProductID);
        Assert.AreEqual("Baseball Bat", product.Name);
        Assert.AreEqual(49.99m, product.Price);
    }
}