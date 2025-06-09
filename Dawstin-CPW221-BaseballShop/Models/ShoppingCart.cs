namespace Dawstin_CPW221_BaseballShop.Models
{
    /// <summary>
    /// Represents an item in the shopping cart.
    /// </summary>
    public class CartItem
    {
        /// <summary>
        /// Gets or sets the product associated with the cart item.
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the product added to the cart.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets the total price for the cart item.
        /// </summary>
        public decimal TotalPrice => Product != null ? Product.Price * Quantity : 0;
    }
}