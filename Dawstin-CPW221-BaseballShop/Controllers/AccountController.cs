using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Dawstin_CPW221_BaseballShop.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Dawstin_CPW221_BaseballShop.Controllers
{
    /// <summary>
    /// Manages user authentication, registration, and account-related actions.
    /// </summary>
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountController"/> class.
        /// </summary>
        /// <param name="userManager">Manages user authentication and identity-related operations.</param>
        /// <param name="signInManager">Handles user sign-in and authentication status.</param>
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        /// <summary>
        /// Displays the login page.
        /// </summary>
        /// <returns>The login view.</returns>
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login() => View();

        /// <summary>
        /// Attempts to log the user in with provided email and password.
        /// </summary>
        /// <param name="email">The user's email address.</param>
        /// <param name="password">The user's password.</param>
        /// <returns>Redirects to the home page if successful; otherwise, displays the login view with an error message.</returns>
        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, password, false, false);
                if (result.Succeeded) return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View();
        }

        /// <summary>
        /// Displays the registration page.
        /// </summary>
        /// <returns>The registration view.</returns>
        [HttpGet]
        public IActionResult Register() => View();

        /// <summary>
        /// Registers a new user with provided email and password.
        /// </summary>
        /// <param name="email">The user's email address.</param>
        /// <param name="password">The user's chosen password.</param>
        /// <returns>Redirects to the login page if successful; otherwise, displays the registration view.</returns>
        [HttpPost]
        public async Task<IActionResult> Register(string email, string password)
        {
            var user = new ApplicationUser { UserName = email, Email = email };
            var result = await _userManager.CreateAsync(user, password);
            if (result.Succeeded) return RedirectToAction("Login");
            return View();
        }

        /// <summary>
        /// Logs out the currently authenticated user.
        /// </summary>
        /// <returns>Redirects to the home page after logout.</returns>
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// Displays the login page and stores the return URL.
        /// </summary>
        /// <param name="returnUrl">The URL to return to after login.</param>
        /// <returns>The login view with the return URL set.</returns>
        public IActionResult Login(string returnUrl = "/")
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }
    }
}