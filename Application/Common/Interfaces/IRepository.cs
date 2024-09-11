using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T>? List(Expression<Func<T, bool>>? filter = null);
        T? Get(Expression<Func<T, bool>>? filter = null);
        void Add(T entity);
        void Remove(T entity);
    }
}
