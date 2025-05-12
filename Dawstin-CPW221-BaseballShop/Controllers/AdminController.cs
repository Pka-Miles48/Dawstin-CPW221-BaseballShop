using Dawstin_CPW221_BaseballShop.Baseball_Data;
using Dawstin_CPW221_BaseballShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dawstin_CPW221_BaseballShop.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly BaseballShop _context;

        public AdminController(BaseballShop context)
        {
            _context = context;
        }

        public IActionResult Dashboard()
        {
            var products = _context.Products.ToList();
            var orders = _context.Orders.ToList();
            return View(new AdminDashboardViewModel { Products = products, Orders = orders });
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        public IActionResult DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            return RedirectToAction("Dashboard");
        }        
    }
}
