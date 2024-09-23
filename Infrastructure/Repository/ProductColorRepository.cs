using Application.Common.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ProductColorRepository : Repository<ProductColor>, IProductColorRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductColorRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(ProductColor entity)
        {
            _context.Update(entity);
        }
    }
}
