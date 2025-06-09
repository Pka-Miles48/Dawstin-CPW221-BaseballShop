using Dawstin_CPW221_BaseballShop.Baseball_Data;
using Dawstin_CPW221_BaseballShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace Dawstin_CPW221_BaseballShop.Repositories
{
    /// <summary>
    /// Provides methods for managing orders in the Baseball Shop database.
    /// </summary>
    public class OrderRepository : IOrderRepository
    {
        private readonly BaseballShop _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRepository"/> class.
        /// </summary>
        /// <param name="context">The database context for managing order data.</param>
        public OrderRepository(BaseballShop context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves an order by its unique identifier.
        /// </summary>
        /// <param name="id">The unique ID of the order.</param>
        /// <returns>The order matching the given ID.</returns>
        public Order GetOrderById(int id)
        {
            return _context.Orders.Find(id);
        }

        /// <summary>
        /// Retrieves all orders from the database.
        /// </summary>
        /// <returns>A list of all orders.</returns>
        public List<Order> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        /// <summary>
        /// Creates a new order in the database.
        /// </summary>
        /// <param name="order">The order to be added.</param>
        public void CreateOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        /// <summary>
        /// Updates an existing order in the database.
        /// </summary>
        /// <param name="order">The order with updated information.</param>
        public void UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        /// <summary>
        /// Deletes an order by its unique identifier.
        /// </summary>
        /// <param name="id">The ID of the order to be deleted.</param>
        public void DeleteOrder(int id)
        {
            var order = _context.Orders.Find(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }
    }
}