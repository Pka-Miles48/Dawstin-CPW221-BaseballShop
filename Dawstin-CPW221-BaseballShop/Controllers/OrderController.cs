using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dawstin_CPW221_BaseballShop.Controllers
{
    [Authorize] // Ensures only authenticated users can access the Order page
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}