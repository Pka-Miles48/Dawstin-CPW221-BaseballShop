using Dawstin_CPW221_BaseballShop.Baseball_Data;
using Dawstin_CPW221_BaseballShop.Models;

namespace Dawstin_CPW221_BaseballShop.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly BaseballShop _context;

        public ProductRepository(BaseballShop context)
        {
            _context = context;
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Find(id);
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }
    }
}
