﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.polyconsole
{
    public class Basket
    {
        private List<IProduct> products = new List<IProduct>();

        
        
        public void AddProduct(IProduct product)
        {
            products.Add(product);
        }
        
        
        
        public List<IProduct> Products { get {  return products; } }
    }
}
