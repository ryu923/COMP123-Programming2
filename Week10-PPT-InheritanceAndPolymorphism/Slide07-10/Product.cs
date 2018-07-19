using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide07_10
{
    // Slide 9 ~ 10
    public class Product
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product(string code, string description, decimal price)
        {
            this.Code = code;
            this.Description = description;
            this.Price = price;
        }

        // Add CONSTRUCTOR
        public Product()
        {

        }

        public string GetDisplayText(string sep) =>
            this.Code + sep +
            this.Description + sep +
            this.Price.ToString("c");

        public object Clone()
        {
            Product p = new Product();
            p.Code = this.Code;
            p.Description = this.Description;
            p.Price = this.Price;

            return p;
        }
    }
}
