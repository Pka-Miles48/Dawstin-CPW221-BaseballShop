namespace BaseballShop.Repositories
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