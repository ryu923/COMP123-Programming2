using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide07_10
{
    // Slide 12
    public class Product2 : IComparable<Product>
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }


        // Other members
        public int CompareTo(Product other) =>
            this.Code.CompareTo(other.Code);
    }
}
