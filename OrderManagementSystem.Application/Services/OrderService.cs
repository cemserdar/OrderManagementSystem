using OrderManagementSystem.Application.Interfaces;
using OrderManagementSystem.Domain.Models;
using OrderManagementSystem.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly OrderRepository orderRepository;

        public OrderService(OrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public List<Order> GetAllOrders()
        {
            return orderRepository.GetAllOrders();
        }
    }
}
