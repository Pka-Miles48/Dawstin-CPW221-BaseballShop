using BaseballShop.Models;
using BaseballShop.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BaseballShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet("{id}")]
        public ActionResult<Order> GetOrderById(int id)
        {
            var order = _orderRepository.GetOrderById(id);
            if (order == null) return NotFound();
            return Ok(order);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetAllOrders()
        {
            return Ok(_orderRepository.GetAllOrders());
        }

        [HttpPost]
        public ActionResult CreateOrder([FromBody] Order order)
        {
            _orderRepository.CreateOrder(order);
            return CreatedAtAction(nameof(GetOrderById), new { id = order.OrderID }, order);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateOrder(int id, [FromBody] Order updatedOrder)
        {
            var existingOrder = _orderRepository.GetOrderById(id);
            if (existingOrder == null) return NotFound();

            _orderRepository.UpdateOrder(updatedOrder);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int id)
        {
            var order = _orderRepository.GetOrderById(id);
            if (order == null) return NotFound();

            _orderRepository.DeleteOrder(id);
            return NoContent();
        }
    }
}