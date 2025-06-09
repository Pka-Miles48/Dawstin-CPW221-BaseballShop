namespace Dawstin_CPW221_BaseballShop.Models
{
    /// <summary>
    /// Represents the view model for the admin dashboard, containing product and order lists.
    /// </summary>
    internal class AdminDashboardViewModel
    {
        /// <summary>
        /// Gets or sets the list of products displayed on the admin dashboard.
        /// </summary>
        public List<Product> Products { get; set; }

        /// <summary>
        /// Gets or sets the list of orders displayed on the admin dashboard.
        /// </summary>
        public List<Order> Orders { get; set; }
    }
}