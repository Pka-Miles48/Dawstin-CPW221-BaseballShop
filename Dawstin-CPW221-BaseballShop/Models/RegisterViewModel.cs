namespace Dawstin_CPW221_BaseballShop.Models
{
    /// <summary>
    /// Represents the view model for user registration.
    /// </summary>
    public class RegisterViewModel
    {
        /// <summary>
        /// Gets or sets the email address of the registering user.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the chosen password of the user.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the confirmation password for validation.
        /// </summary>
        public string ConfirmPassword { get; set; }
    }
}