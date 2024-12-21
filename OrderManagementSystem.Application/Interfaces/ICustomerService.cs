using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagementSystem.Domain.Models;

namespace OrderManagementSystem.Application.Interfaces
{
    internal interface ICustomerService
    {
        List<Customer> GetAllCustomers();
    }
}
