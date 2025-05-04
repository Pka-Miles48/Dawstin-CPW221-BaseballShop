using Microsoft.AspNetCore.Mvc;
using Dawstin_CPW221_BaseballShop.Models;
using Dawstin_CPW221_BaseballShop.Services;
using Dawstin_CPW221_BaseballShop.Baseball_Data;

namespace Dawstin_CPW221_BaseballShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ShoppingCartService _cartService;
        private readonly BaseballShop _context;

        public ShoppingCartController(ShoppingCartService cartService, BaseballShop context)
        {
            _cartService = cartService;
            _context = context;
        }

        public IActionResult Index()
        {
            var cartItems = _cartService.GetCart();
            return View(cartItems);
        }

        public IActionResult AddToCart(int productId)
        {
            var product = _context.Products.Find(productId);
            if (product != null)
                _cartService.AddToCart(product, 1);

            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromCart(int productId)
        {
            _cartService.RemoveFromCart(productId);
            return RedirectToAction("Index");
        }
    }
}
