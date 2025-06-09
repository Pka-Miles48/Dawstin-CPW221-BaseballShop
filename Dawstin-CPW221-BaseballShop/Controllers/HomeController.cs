using System.Diagnostics;
using Dawstin_CPW221_BaseballShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dawstin_CPW221_BaseballShop.Controllers
{
    /// <summary>
    /// Handles general navigation and application-wide pages such as the home and privacy views.
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="logger">The logger instance for tracking application events.</param>
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Displays the home page of the application.
        /// </summary>
        /// <returns>The home view.</returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Displays the privacy policy page.
        /// </summary>
        /// <returns>The privacy view.</returns>
        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// Handles application errors and displays an error page.
        /// </summary>
        /// <returns>The error view containing the request ID.</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}