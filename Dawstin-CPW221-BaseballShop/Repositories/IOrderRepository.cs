using Dawstin_CPW221_BaseballShop.Models;

namespace Dawstin_CPW221_BaseballShop.Repositories
{
    /// <summary>
    /// Defines operations for managing orders in the Baseball Shop.
    /// </summary>
    public interface IOrderRepository
    {
        /// <summary>
        /// Retrieves an order by its unique identifier.
        /// </summary>
        /// <param name="id">The unique ID of the order.</param>
        /// <returns>The order matching the given ID.</returns>
        Order GetOrderById(int id);

        /// <summary>
        /// Retrieves all orders.
        /// </summary>
        /// <returns>A list of all orders.</returns>
        List<Order> GetAllOrders();

        /// <summary>
        /// Creates a new order.
        /// </summary>
        /// <param name="order">The order to be created.</param>
        void CreateOrder(Order order);

        /// <summary>
        /// Updates an existing order.
        /// </summary>
        /// <param name="order">The order with updated details.</param>
        void UpdateOrder(Order order);

        /// <summary>
        /// Deletes an order by its unique identifier.
        /// </summary>
        /// <param name="id">The unique ID of the order to delete.</param>
        void DeleteOrder(int id);
    }
}