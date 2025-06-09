namespace Dawstin_CPW221_BaseballShop.Models
{
    /// <summary>
    /// Represents the view model for user login functionality.
    /// </summary>
    public class LoginViewModel
    {
        /// <summary>
        /// Gets or sets the email address of the user attempting to log in.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the password of the user attempting to log in.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user wishes to remain logged in.
        /// </summary>
        public bool RememberMe { get; set; }
    }
}