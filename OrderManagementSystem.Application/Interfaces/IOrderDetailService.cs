using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OrderManagementSystem.Domain.Models;
namespace OrderManagementSystem.Application.Interfaces
{
    public interface IOrderDetailService
    {
        List<OrderDetails> GetAllOrderDetails();
        
        List<OrderDetails> GetOrderDetailsByOrderId(int id);
    }
}
