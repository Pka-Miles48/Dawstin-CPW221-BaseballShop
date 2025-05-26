using BaseballShop.Models;
using BaseballShop.Data;

public class OrderService
{
    private readonly BaseballShopContext _context;

    public OrderService(BaseballShopContext context)
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
