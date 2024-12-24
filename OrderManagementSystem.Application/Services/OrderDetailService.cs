using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagementSystem.Application.Interfaces;
using OrderManagementSystem.Domain.Models;
using OrderManagementSystem.Infrastructure.Repositories;

namespace OrderManagementSystem.Application.Services
{
    public class OrderDetailService : IOrderDetailService
    {

        private readonly OrderDetailRepository _repository;

        public OrderDetailService(OrderDetailRepository repository)
        {
            this._repository = repository;
        }
        public List<OrderDetails> GetAllOrderDetails()
        {
            return _repository.GetOrderDetails();
        }

        public List<OrderDetails> GetOrderDetailsByOrderId(int id)
        {
            return _repository.GetOrderDetailsByOrderId(id);
        }
    }
}
