using Dawstin_CPW221_BaseballShop.Models;

namespace Dawstin_CPW221_BaseballShop.Repositories
{
    public interface IOrderRepository
    {
        Order GetOrderById(int id);
        List<Order> GetAllOrders();
        void CreateOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int id);
    }
}