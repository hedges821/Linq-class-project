using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculatorVS2019.Models
{
    public interface ITaxCalculator
    {
        decimal FindTaxAmount(decimal income);
    }
}
