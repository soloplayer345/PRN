using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Product
    {

        public int ProductId { get; set; }
        public required string ProductName { get; set; }
        public int CategoryId { get; set; }
        public required string Weight { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public int OrderDetailId { get; set; }
        public OrderDetail? OrderDetail { get; set; }
    }
}
