using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCartApp.Models
{
    public class ValueAfterDiscountCalculator : IValueCalculator
    {
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            decimal fullPrice = products.Sum(p => p.Price);

            if(fullPrice < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (fullPrice > 200)
            {
                return fullPrice * 0.9M;
            }
            else if (fullPrice >= 100 && fullPrice <= 200)
            {
                return fullPrice * 0.95M;
            }
            else
            {
                return fullPrice;
            }
        }
    }
}