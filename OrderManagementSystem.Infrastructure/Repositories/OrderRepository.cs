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
    }
}
