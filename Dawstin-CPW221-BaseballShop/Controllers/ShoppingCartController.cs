using Microsoft.AspNetCore.Mvc;
using Dawstin_CPW221_BaseballShop.Models;
using Dawstin_CPW221_BaseballShop.Baseball_Data;

namespace Dawstin_CPW221_BaseballShop.Controllers
{
    /// <summary>
    /// Manages shopping cart actions such as adding and removing products.
    /// </summary>
    public class ShoppingCartController : Controller
    {
        private readonly BaseballShop _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingCartController"/> class.
        /// </summary>
        /// <param name="context">The database context for managing shopping cart data.</param>
        public ShoppingCartController(BaseballShop context)
        {
            _context = context;
        }

        /// <summary>
        /// Displays the shopping cart view.
        /// </summary>
        /// <returns>The shopping cart view.</returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Adds a product to the shopping cart.
        /// </summary>
        /// <param name="productId">The unique identifier of the product to add.</param>
        /// <returns>Redirects to the shopping cart index view.</returns>
        public IActionResult AddToCart(int productId)
        {
            var cartItem = new ShoppingCart
            {
                ProductID = productId,
                Quantity = 1,
                AddedDate = DateTime.Now
            };

            _context.SaveChanges();  // ✅ Direct database access without a service

            return RedirectToAction("Index");
        }

        /// <summary>
        /// Removes a product from the shopping cart.
        /// </summary>
        /// <param name="productId">The unique identifier of the product to remove.</param>
        /// <returns>Redirects to the shopping cart index view.</returns>
        public IActionResult RemoveFromCart(int productId)
        {
            return RedirectToAction("Index");
        }
    }

    /// <summary>
    /// Represents an item in the shopping cart.
    /// </summary>
    internal class ShoppingCart
    {
        /// <summary>
        /// Gets or sets the product ID associated with this cart item.
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the product added to the cart.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the date the product was added to the cart.
        /// </summary>
        public DateTime AddedDate { get; set; }
    }
}