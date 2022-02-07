using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DILabStarterFile.Models
{
    public class BlackFridaySalePrice : IPriceCalculator
    {
        public decimal CalcSalesPrice(decimal origPrice)
        {
            return origPrice * .75M;
        }
    }
}