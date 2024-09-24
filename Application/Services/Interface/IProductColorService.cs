using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interface
{
	public interface IProductColorService
	{
		IEnumerable<ProductColor> GetAllProductColor();
		ProductColor? GetProductColorById(int id);
		void CreateProductColor(ProductColor productColor);
		void UpdateProductColor(ProductColor productColor);
		bool DeleteProductColor(int id);
	}
}
