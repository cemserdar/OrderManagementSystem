using OrderManagementSystem.Domain.Models;
using OrderManagementSystem.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem.Infrastructure.Repositories
{
    public class CustomerRepository
    {
        private readonly AppDbContext _context;

        public CustomerRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public Customer GetCustomerById(string id)
        {
            return _context.Customers.FirstOrDefault(c=>c.CustomerID == id);
        }
        

        // public string DeleteCustomer(string id)
        // {
        //     var customer =  _context.Customers.FirstOrDefault(c=>c.CustomerID==id);
        //     return _context.Customers.Remove(customer).ToString();
        // }
    }
}
