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
    public class ProductService : IProductService
    {

        private readonly ProductRepository _repository;

        public ProductService(ProductRepository repository)
        {
            _repository = repository;
        }

        public List<Product> GetAllProducts()
        {
            return _repository.GetProducts();
        }

    }
}
