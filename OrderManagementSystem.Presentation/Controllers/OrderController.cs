using Microsoft.AspNetCore.Mvc;
using OrderManagementSystem.Application.Services;
using OrderManagementSystem.Application.Interfaces;

namespace OrderManagementSystem.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            var orders = _orderService.GetAllOrders();
            return Ok(orders);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetOrderById(string id)
        {
            var orderList = _orderService.GetOrdersByCustomerId(id);
            return Ok(orderList);
        }
    }
}