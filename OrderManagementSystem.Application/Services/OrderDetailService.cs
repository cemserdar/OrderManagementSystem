using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagementSystem.Application.Interfaces;
using OrderManagementSystem.Domain.Models;

namespace OrderManagementSystem.Application.Services
{
    internal class OrderDetailService
    {

        private readonly IOrderDetailService _orderDetailService;

        public List<OrderDetail> GetAllOrderDetails()
        {
            return _orderDetailService.GetAllOrderDetails();
        }
    }
}
