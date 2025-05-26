using BaseballShop.Data;
using BaseballShop.Models;

namespace BaseballShop.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly BaseballShopContext _context;

        public ProductRepository(BaseballShopContext context)
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
