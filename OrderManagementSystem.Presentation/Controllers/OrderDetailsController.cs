using Microsoft.AspNetCore.Mvc;
using OrderManagementSystem.Application.Interfaces;

namespace OrderManagementSystem.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderDetailsController : ControllerBase
    {

        private readonly IOrderDetailService _orderDetailService;

        public OrderDetailsController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }
        [HttpGet]
        public IActionResult GetOrderDetails()
        {
            var orderDetails = _orderDetailService.GetAllOrderDetails();
            return Ok(orderDetails);
        }
        [HttpGet]
        [Route("id")]
        public IActionResult GetOrderDetailsByOrderId(int id)
        {
            var orderDetailsById = _orderDetailService.GetOrderDetailsByOrderId(id);
            return Ok(orderDetailsById);
        }

    }
}
