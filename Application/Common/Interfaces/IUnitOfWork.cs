using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IUnitOfWork
    {
        IProductRepository Product {  get; }
        IProductColorRepository ProductColor { get; }
        ICategoryRepository Category { get; }
        void Save();
    }
}
