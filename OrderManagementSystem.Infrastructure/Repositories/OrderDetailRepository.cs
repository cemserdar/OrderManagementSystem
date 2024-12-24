using OrderManagementSystem.Domain.Models;
using OrderManagementSystem.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem.Infrastructure.Repositories
{
    public class OrderDetailRepository
    {
        private readonly AppDbContext _context;

        public OrderDetailRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<OrderDetails> GetOrderDetails()
        {
            return _context.OrderDetails.ToList();
        }

        public List<OrderDetails> GetOrderDetailsByOrderId(int id)
        {
            var order = _context.Orders.FirstOrDefault(x=>x.OrderID==id);
            var orderDetails = _context.OrderDetails.Where(x=>x.OrderID == order.OrderID).ToList();
            return orderDetails.ToList();
        }
    }
}
