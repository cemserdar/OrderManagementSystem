﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagementSystem.Domain.Models;

namespace OrderManagementSystem.Application.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomers();
        // Customer DeleteCustomer(string id);
        Customer GetCustomerById(string id);
    }
}
