using OrderManagementSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem.Application.Interfaces
{
    public interface IOrderService
    {
        List<Order> GetAllOrders();

        List<Order> GetOrdersByCustomerId(string id);
    }
    
    
}
