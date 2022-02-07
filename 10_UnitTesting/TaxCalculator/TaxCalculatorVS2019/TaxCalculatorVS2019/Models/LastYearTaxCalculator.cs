using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxCalculatorVS2019.Models
{
    public class LastYearTaxCalculator : ITaxCalculator
    {
        public decimal FindTaxAmount(decimal income)
        {
            decimal taxAmount;
            decimal stDedSingle = 6300;
            decimal persDedSingle = 4050;
            income = income - stDedSingle - persDedSingle;
            if (income < 9276)
            {
                taxAmount = income * .1M;
            }
            else if (income < 37651)
            {
                taxAmount = 927.50M + (income - 9275) * .15M;
            }
            else if (income < 91151)
            {
                taxAmount = 5183.75M + (income - 37650) * .25M;
            }
            else if (income < 190151)
            {
                taxAmount = 18558.75M + (income - 91150) * .28M;
            }

            else if (income < 413351)
            {
                taxAmount = 46278.75M + (income - 190150) * .33M;
            }

            else if (income < 415051)
            {
                taxAmount = 119934.75M + (income - 413350) * .35M;
            }
            else
            {
                taxAmount = 120529.75M + (income - 415050) * .396M;
            }

            return taxAmount;
        }
    }
}