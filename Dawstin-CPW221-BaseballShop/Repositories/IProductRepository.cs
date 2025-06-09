using Dawstin_CPW221_BaseballShop.Models;

namespace Dawstin_CPW221_BaseballShop.Repositories
{
    /// <summary>
    /// Defines operations for retrieving product data in the Baseball Shop.
    /// </summary>
    public interface IProductRepository
    {
        /// <summary>
        /// Retrieves a product by its unique identifier.
        /// </summary>
        /// <param name="id">The unique ID of the product.</param>
        /// <returns>The product matching the given ID.</returns>
        Product GetProductById(int id);

        /// <summary>
        /// Retrieves all available products in the shop.
        /// </summary>
        /// <returns>A list of all products.</returns>
        List<Product> GetAllProducts();
    }
}