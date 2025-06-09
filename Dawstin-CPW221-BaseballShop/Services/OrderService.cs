using Dawstin_CPW221_BaseballShop.Models;
using Dawstin_CPW221_BaseballShop.Baseball_Data;

namespace Dawstin_CPW221_BaseballShop.Services
{
    /// <summary>
    /// Provides functionality for creating orders in the Baseball Shop system.
    /// </summary>
    public class OrderService
    {
        private readonly BaseballShop _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderService"/> class.
        /// </summary>
        /// <param name="context">The database context for managing order data.</param>
        public OrderService(BaseballShop context)
        {
            _context = context;
        }

        /// <summary>
        /// Creates a new order with the given customer name and total price.
        /// </summary>
        /// <param name="customerName">The name of the customer placing the order.</param>
        /// <param name="totalPrice">The total price of the order.</param>
        /// <returns>The newly created order.</returns>
        public Order CreateOrder(string customerName, decimal totalPrice)
        {
            var order = new Order
            {
                CustomerName = customerName,
                TotalPrice = totalPrice,
                Status = "Pending"
            };
            _context.Orders.Add(order);
            _context.SaveChanges();
            return order;
        }
    }
}