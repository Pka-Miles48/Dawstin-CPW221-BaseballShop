using Microsoft.AspNetCore.Mvc;
using Dawstin_CPW221_BaseballShop.Models;
using Dawstin_CPW221_BaseballShop.Baseball_Data;

namespace Dawstin_CPW221_BaseballShop.Controllers
{
    public class ShoppingCartController : Controller
    {        
        private readonly BaseballShop _context;

        public ShoppingCartController(BaseballShop context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


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


        public IActionResult RemoveFromCart(int productId)
        {
            return RedirectToAction("Index");
        }
    }

    internal class ShoppingCart
    {
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
