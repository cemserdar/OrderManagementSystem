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
    public class CustomerService : ICustomerService
    {
        private readonly CustomerRepository _repository;

        public CustomerService(CustomerRepository repository)
        {
            _repository = repository;
        }

        public List<Customer> GetAllCustomers()
        {
            return _repository.GetAllCustomers();
        }
        
        
        public Customer GetCustomerById(string id)
        {
            return _repository.GetCustomerById(id);
        }
        

        // public Customer DeleteCustomer(string id)
        // {
        //     // Önce 'id' ile müşteriyi buluyoruz.
        //     var customer = _repository.GetCustomerById(id);
        //
        //     if (customer == null)
        //     {
        //         throw new Exception("Customer not found");
        //     }
        //
        //     // Ardından müşteriyi siliyoruz.
        //     _repository.DeleteCustomer(customer);
        //
        //     return customer; // Silinen müşteriyi döndürmek mantıklı olabilir.
        // }
        //
        
    }
}
