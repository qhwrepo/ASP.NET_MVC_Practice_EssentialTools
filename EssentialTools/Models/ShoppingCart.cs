using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class ShoppingCart
    {
        private IValueCalculator calc;
        //private LinqValueCalculator calc;
        public ShoppingCart(IValueCalculator calcParam)//LinqValueCalculator calcParam)
        {
            calc = calcParam;
        }

        public IEnumerable<Product> Products { get; set; }

        public decimal CalculateProductTotal()
        {
            //LinqValueCalculator calc = new LinqValueCalculator();
            return calc.ValueProducts(Products);
        }
    }
}