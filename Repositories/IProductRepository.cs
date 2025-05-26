namespace BaseballShop.Repositories
{
    public interface IProductRepository
    {
        Product GetProductById(int id);
        List<Product> GetAllProducts();
    }
}
