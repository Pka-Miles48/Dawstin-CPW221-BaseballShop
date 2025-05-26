using Dawstin_CPW221_BaseballShop.Models;
using Dawstin_CPW221_BaseballShop.Baseball_Data;

namespace Dawstin_CPW221_BaseballShop.Services
{
    public class OrderService
    {
        private readonly BaseballShop _context;

        public OrderService(BaseballShop context)
        {
            _context = context;
        }

        public Order CreateOrder(string customerName, decimal totalPrice)
        {
            var order = new Order { CustomerName = customerName, TotalPrice = totalPrice, Status = "Pending" };
            _context.Orders.Add(order);
            _context.SaveChanges();
            return order;
        }
    }
}
