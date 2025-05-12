namespace Dawstin_CPW221_BaseballShop.Models
{
    /// <summary>
    /// Represents a customer's order in the Baseball Shop system.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets the unique identifier for the order.
        /// </summary>
        public int OrderID { get; set; }

        /// <summary>
        /// Gets or sets the foreign key reference to the customer who placed the order.
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the date the order was placed.
        /// Defaults to the current date and time.
        /// </summary>
        public DateTime OrderDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets the total cost of the order.
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Gets or sets the status of the order.
        /// Example values: "Pending", "Completed", "Canceled".
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the associated customer.
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Gets or sets the name of the customer who placed the order.
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the total price of the order, including all purchased items.
        /// </summary>
        public decimal TotalPrice { get; set; }
    }
}
