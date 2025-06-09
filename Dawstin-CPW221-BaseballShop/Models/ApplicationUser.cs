using Microsoft.AspNetCore.Identity;

namespace Dawstin_CPW221_BaseballShop.Models
{
    /// <summary>
    /// Represents a user in the Baseball Shop system, extending IdentityUser for authentication.
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// Gets or sets the user's full name.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the date when the user registered.
        /// </summary>
        public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the user's address.
        /// </summary>
        public string Address { get; set; }
    }
}