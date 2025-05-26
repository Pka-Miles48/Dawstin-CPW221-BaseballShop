public class ProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Product GetProductById(int id)
    {
        return _productRepository.GetProductById(id);
    }
}
