using BaseballShop.Data;
using BaseballShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace BaseballShop.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly BaseballShopContext _context;

        public OrderRepository(BaseballShopContext context)
        {
            _context = context;
        }

        public Order GetOrderById(int id)
        {
            return _context.Orders.Find(id);
        }

        public List<Order> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public void CreateOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

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