using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Product
    {

        public int productId { get; set; }
        public required string productName { get; set; }
        public int categoryId { get; set; }
        public required string Weight { get; set; }
        public int unitPrice { get; set; }
        public int unitsInStock { get; set; }

        public OrderDetail? OrderDetail { get; set; }
    }
}
