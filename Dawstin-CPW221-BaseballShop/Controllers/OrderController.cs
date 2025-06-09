using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Dawstin_CPW221_BaseballShop.Baseball_Data;
using Dawstin_CPW221_BaseballShop.Models;
using Microsoft.EntityFrameworkCore;

namespace Dawstin_CPW221_BaseballShop.Controllers
{
    /// <summary>
    /// Manages order-related operations in the BaseballShop system.
    /// </summary>
    [Authorize] // Ensures only authenticated users can access this controller by default
    public class OrderController : Controller
    {
        private readonly BaseballShop _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderController"/> class.
        /// </summary>
        /// <param name="context">The database context for accessing order data.</param>
        public OrderController(BaseballShop context)
        {
            _context = context;
        }

        /// <summary>
        /// Displays the order list view, allowing guests to view available orders.
        /// </summary>
        /// <returns>The view containing all orders.</returns>
        [AllowAnonymous] // Guests can view this action without authentication
        public IActionResult Index()
        {
            var orders = _context.Orders.ToList(); // Retrieves all orders (guest access allowed)
            return View(orders);
        }

        /// <summary>
        /// Displays the order management page, allowing only authenticated users to view their orders.
        /// </summary>
        /// <returns>The view containing only the logged-in user's orders.</returns>
        [Authorize] // Authentication required to access personal order details
        public IActionResult ManageOrders()
        {
            var orders = _context.Orders
                .Where(o => o.UserID == GetCurrentUserID()) // Filters orders based on logged-in user
                .ToList();

            return View(orders);
        }

        /// <summary>
        /// Retrieves the unique identifier for the currently authenticated user.
        /// </summary>
        /// <returns>The user's ID as an integer.</returns>
        private int GetCurrentUserID()
        {
            return int.Parse(User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value ?? "0");
        }
    }
}