using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Dawstin_CPW221_BaseballShop.Baseball_Data;
using Dawstin_CPW221_BaseballShop.Models;

namespace Dawstin_CPW221_BaseballShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly BaseballShop _context;

        public ProductController(BaseballShop context)
        {
            _context = context;
        }

        // Action for listing products
        public IActionResult Index(string category, decimal? minPrice, decimal? maxPrice)
        {
            var products = _context.Products.AsQueryable();

            // Filtering logic (same as before)
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

            // Get distinct categories for filtering
            ViewBag.Categories = _context.Categories.Select(c => c.Name).Distinct().ToList();

            return View(products.ToList());
        }

    }
}
