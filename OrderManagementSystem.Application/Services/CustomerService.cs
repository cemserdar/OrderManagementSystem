using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagementSystem.Application.Interfaces;
using OrderManagementSystem.Domain.Models;

namespace OrderManagementSystem.Application.Services
{
    internal class CustomerService
    {
        private readonly ICustomerService _customerService;

        public List<Customer> GetAllCustomers()
        {
            return _customerService.GetAllCustomers();
        }


    }
}
