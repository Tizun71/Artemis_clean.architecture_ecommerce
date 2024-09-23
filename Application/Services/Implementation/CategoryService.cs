using Application.Common.Interfaces;
using Application.Services.Interface;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void CreateCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category>? GetAllCategories()
        {
            return _unitOfWork.Category.List();
        }

        public Category GetCategoryById(int id)
        {
            return _unitOfWork.Category.Get(c => c.CategoryID == id);
        }

        public void UpdateCategory(Category category)
        {
            _unitOfWork.Category.Update(category);
        }
    }
}
