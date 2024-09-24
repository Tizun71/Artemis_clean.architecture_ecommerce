using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class ProductPhoto
	{
		[Key]
		public int PhotoID { get; set; }
		public string PhotoDescription {  get; set; }
		[ForeignKey("Product")]
		public int ProductID { get; set; }
		public int DisplayOrder {  get; set; }
	}
}
