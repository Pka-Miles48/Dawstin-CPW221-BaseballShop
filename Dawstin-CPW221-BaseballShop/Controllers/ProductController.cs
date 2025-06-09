using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Dawstin_CPW221_BaseballShop.Baseball_Data;
using Dawstin_CPW221_BaseballShop.Models;

namespace Dawstin_CPW221_BaseballShop.Controllers
{
    /// <summary>
    /// Manages product-related actions, including filtering and displaying available products.
    /// </summary>
    public class ProductController : Controller
    {
        private readonly BaseballShop _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductController"/> class.
        /// </summary>
        /// <param name="context">The database context for product data.</param>
        public ProductController(BaseballShop context)
        {
            _context = context;
        }

        /// <summary>
        /// Displays a list of products, optionally filtering by category and price range.
        /// </summary>
        /// <param name="category">The category of products to filter by.</param>
        /// <param name="minPrice">The minimum price filter.</param>
        /// <param name="maxPrice">The maximum price filter.</param>
        /// <returns>A filtered list of products.</returns>
        public IActionResult Index(string category, decimal? minPrice, decimal? maxPrice)
        {
            var products = _context.Products.AsQueryable();

            // Filtering logic (commented out)
            //if (!string.IsNullOrEmpty(category))
            //{
            //    products = products.Where(p => p.Category.Name == category);
            //}

            if (minPrice.HasValue)
            {
                products = products.Where(p => p.Price >= minPrice.Value);
            }
            if (maxPrice.HasValue)
            {
                products = products.Where(p => p.Price <= maxPrice.Value);
            }

            /// <summary>
            /// Retrieves distinct product categories for filtering options.
            /// </summary>
            ViewBag.Categories = _context.Categories.Select(c => c.Name).Distinct().ToList();

            return View(products.ToList());
        }
    }
}