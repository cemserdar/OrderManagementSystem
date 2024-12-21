using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagementSystem.Application.Interfaces;
using OrderManagementSystem.Domain.Models;

namespace OrderManagementSystem.Application.Services
{
    internal class CategoryService
    {
        private readonly ICategoryService _categoryService;
        public List<Category> GetAllCategories()
        { 
            return _categoryService.GetAllCategories();
        }
    }
}

