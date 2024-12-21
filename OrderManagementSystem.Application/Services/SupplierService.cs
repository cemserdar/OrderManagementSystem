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
    public class SupplierService : ISupplierService
    {

        private readonly SupplierRepository _repository;

        public SupplierService(SupplierRepository repository)
        {
            this._repository = repository;
        }

        public List<Supplier> GetAllSuppliers()
        {
            return _repository.GetAll();
        }
    }
}
