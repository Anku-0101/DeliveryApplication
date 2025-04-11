using FoodDeliveryApplication.DeliveryService;
using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IDeliveryService _service;

        public OrderController(IDeliveryService service)
        {
            _service = service;
        }

        [HttpPost("generate")]
        public IActionResult GenerateOrder()
        {
            var order = _service.GenerateOrder();
            Console.WriteLine($"Generated Order: From ({order.FromX}, {order.FromY}) To ({order.ToX}, {order.ToY})");
            return Ok(order);
        }

        [HttpGet("orders")]
        public IActionResult GetOrders()
        {
            var orders = _service.GetOrders();
            Console.WriteLine($"Total Orders: {orders.Count}");
            return Ok(orders);
        } 
    }
}
