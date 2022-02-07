using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxCalculatorVS2019.Models
{
    public class CurrentTaxCalculator : ITaxCalculator
    {
        public decimal FindTaxAmount(decimal income)
        {
            decimal taxAmount;
            decimal stDedSingle = 6350;
            decimal persDedSingle = 4050;
            income = income - stDedSingle - persDedSingle;
            if (income < 9326)
            {
                taxAmount = income * .1M;
            }
            else if (income < 37951)
            {
                taxAmount = 932.50M + (income - 9325) * .15M;
            }
            else if (income < 91901)
            {
                taxAmount = 5226.25M + (income - 37950) * .25M;
            }
            else if (income < 191651)
            {
                taxAmount = 18713.75M + (income - 91900) * .28M;
            }

            else if (income < 416701)
            {
                taxAmount = 46643.75M + (income - 191650) * .33M;
            }

            else if (income < 418401)
            {
                taxAmount = 120910.25M + (income - 416700) * .35M;
            }
            else
            {
                taxAmount = 121505.25M + (income - 418400) * .396M;
            }

            return taxAmount;
        }

    }
}