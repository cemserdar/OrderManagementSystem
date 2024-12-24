using OrderManagementSystem.Domain.Models;
using OrderManagementSystem.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem.Infrastructure.Repositories
{
    public class OrderRepository
    {

        private readonly AppDbContext appDbContext;

        public OrderRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public List<Order> GetAllOrders()
        {
            return appDbContext.Orders.ToList();
        }

        public List<Order> GetOrdersByCustomerId(string id)
        {
            var customer = appDbContext.Customers.Find(id);
            // var order = appDbContext.Orders.FirstOrDefault(c=>c.CustomerID == customer.CustomerID);
            var orderList = appDbContext.Orders.Where(c => c.CustomerID == customer.CustomerID);
            
            return orderList.ToList();
        }
        
        
    }
}
