using Dawstin_CPW221_BaseballShop.Baseball_Data;
using Dawstin_CPW221_BaseballShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dawstin_CPW221_BaseballShop.Controllers
{
    /// <summary>
    /// Controller responsible for administrative actions such as managing products and orders.
    /// </summary>
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly BaseballShop _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminController"/> class.
        /// </summary>
        /// <param name="context">The database context for accessing product and order data.</param>
        public AdminController(BaseballShop context)
        {
            _context = context;
        }

        /// <summary>
        /// Displays the admin dashboard, including product and order lists.
        /// </summary>
        /// <returns>The dashboard view populated with product and order data.</returns>
        public IActionResult Dashboard()
        {
            var products = _context.Products.ToList();
            var orders = _context.Orders.ToList();
            return View(new AdminDashboardViewModel { Products = products, Orders = orders });
        }

        /// <summary>
        /// Adds a new product to the store.
        /// </summary>
        /// <param name="product">The product to be added.</param>
        /// <returns>Redirects to the dashboard upon successful addition.</returns>
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        /// <summary>
        /// Deletes an existing product by ID.
        /// </summary>
        /// <param name="id">The unique identifier of the product to be deleted.</param>
        /// <returns>Redirects to the dashboard after deletion.</returns>
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