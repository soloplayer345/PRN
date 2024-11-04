using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
