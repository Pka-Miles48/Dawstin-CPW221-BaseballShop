using Dawstin_CPW221_BaseballShop.Models;

namespace Dawstin_CPW221_BaseballShop.Repositories

{
    public interface IProductRepository
    {
        Product GetProductById(int id);
        List<Product> GetAllProducts();
    }
}
