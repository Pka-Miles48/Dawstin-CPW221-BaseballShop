using BaseballShop.Models;
using BaseballShop.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BaseballShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAllProducts()
        {
            return Ok(_productRepository.GetAllProducts());
        }

        [HttpPost]
        public ActionResult CreateProduct([FromBody] Product product)
        {
            _productRepository.CreateProduct(product);
            return CreatedAtAction(nameof(GetProductById), new { id = product.ProductID }, product);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id, [FromBody] Product updatedProduct)
        {
            var existingProduct = _productRepository.GetProductById(id);
            if (existingProduct == null) return NotFound();

            _productRepository.UpdateProduct(updatedProduct);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null) return NotFound();

            _productRepository.DeleteProduct(id);
            return NoContent();
        }
    }
}