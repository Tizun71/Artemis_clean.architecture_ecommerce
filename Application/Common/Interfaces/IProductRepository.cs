using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product entity);
        void Save();
    }
}
