namespace Dawstin_CPW221_BaseballShop.Models
{
    /// <summary>
    /// Represents the details of an order, linking products to their respective orders.
    /// </summary>
    public class OrderDetail
    {
        /// <summary>
        /// Gets or sets the unique identifier for the order detail record.
        /// </summary>
        public int OrderDetailID { get; set; }

        /// <summary>
        /// Gets or sets the foreign key reference to the associated order.
        /// </summary>
        public int OrderID { get; set; }

        /// <summary>
        /// Gets or sets the foreign key reference to the purchased product.
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the product purchased in this order.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets the subtotal amount for this order detail entry,
        /// calculated as the product price multiplied by the quantity purchased.
        /// </summary>
        public decimal Subtotal => Product != null ? Product.Price * Quantity : 0;

        /// <summary>
        /// Gets or sets the navigation property to access the related order.
        /// </summary>
        public Order Order { get; set; }

        /// <summary>
        /// Gets or sets the navigation property to access the associated product.
        /// </summary>
        public Product Product { get; set; }
    }
}