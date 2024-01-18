using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.inheritcons.Products
{
    public class Drums : Product
    {
        public override double CalculateDiscount()
        {
            return this.Price - this.Discount;
        }
    }
}
