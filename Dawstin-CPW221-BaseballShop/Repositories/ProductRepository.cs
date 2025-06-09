using Dawstin_CPW221_BaseballShop.Baseball_Data;
using Dawstin_CPW221_BaseballShop.Models;

namespace Dawstin_CPW221_BaseballShop.Repositories
{
    /// <summary>
    /// Provides methods for retrieving product data in the Baseball Shop database.
    /// </summary>
    public class ProductRepository : IProductRepository
    {
        private readonly BaseballShop _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductRepository"/> class.
        /// </summary>
        /// <param name="context">The database context for managing product data.</param>
        public ProductRepository(BaseballShop context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves a product by its unique identifier.
        /// </summary>
        /// <param name="id">The unique ID of the product.</param>
        /// <returns>The product matching the given ID.</returns>
        public Product GetProductById(int id)
        {
            return _context.Products.Find(id);
        }

        /// <summary>
        /// Retrieves all available products from the database.
        /// </summary>
        /// <returns>A list of all products.</returns>
        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }
    }
}