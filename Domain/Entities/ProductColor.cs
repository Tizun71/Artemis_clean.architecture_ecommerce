using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductColor
    {
        [Key]
        public int ColorID { get; set; }
        public string ColorName { get; set; } = string.Empty;
        public string ColorCode { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
    }
}
