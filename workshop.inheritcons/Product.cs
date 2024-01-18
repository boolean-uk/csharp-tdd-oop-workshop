using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.inheritcons
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }

        public virtual double CalculateDiscount()
        {
            return this.Price - ((this.Discount / 100) * this.Price);
        }
    }
}
