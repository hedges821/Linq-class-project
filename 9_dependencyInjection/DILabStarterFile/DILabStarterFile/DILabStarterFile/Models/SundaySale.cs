using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace DILabStarterFile.Models
{
    public class SundaySale : IPriceCalculator
    {
        public decimal CalcSalesPrice(decimal origPrice)
        {
            return origPrice * .95M;
        }
    }
}
