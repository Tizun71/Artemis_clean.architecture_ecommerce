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
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void CreateProduct(Product product)
        {
            _unitOfWork.Product.Add(product);
            _unitOfWork.Save();
        }

        public bool DeleteProduct(int id)
        {
            try
            {
                Product? product = _unitOfWork.Product.Get(p => p.ProductID == id);
                _unitOfWork.Product.Remove(product);
                _unitOfWork.Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _unitOfWork.Product.List();
        }

        public Product? GetProductById(int id)
        {
            return _unitOfWork.Product.Get(p => p.ProductID == id);
        }

        public void UpdateProduct(Product product)
        {
            _unitOfWork.Product.Update(product);
        }
    }
}
