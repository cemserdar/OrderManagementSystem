﻿using Microsoft.AspNetCore.Mvc;
using OrderManagementSystem.Application.Interfaces;

namespace OrderManagementSystem.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]

        public IActionResult GetAllCustomers()
        {
            var customers = _customerService.GetAllCustomers();
            return Ok(customers);
        }
    }
}
