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
	public class ProductColorService : IProductColorService
	{
		private readonly IUnitOfWork UnitOfWork;

		public ProductColorService(IUnitOfWork unitOfWork)
		{
			this.UnitOfWork = unitOfWork;
		}
		public void CreateProductColor(ProductColor productColor)
		{
			UnitOfWork.ProductColor.Add(productColor);
			UnitOfWork.Save();
		}

		public bool DeleteProductColor(int id)
		{
			try
			{
				ProductColor? productColor = UnitOfWork.ProductColor.Get(pc => pc.ColorID == id);
				UnitOfWork.ProductColor.Remove(productColor);
				UnitOfWork.Save();
				return true;
			}
			catch (Exception ex){ 
				return false;
			}
		}

		public IEnumerable<ProductColor> GetAllProductColor()
		{
			return UnitOfWork.ProductColor.List();
		}

		public ProductColor? GetProductColorById(int id)
		{
			return UnitOfWork.ProductColor.Get(pc => pc.ColorID == id);
		}

		public void UpdateProductColor(ProductColor productColor)
		{
			UnitOfWork.ProductColor.Update(productColor);
			UnitOfWork.Save();
		}
	}
}
