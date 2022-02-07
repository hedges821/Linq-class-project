﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.Models
{
    public interface IValueCalculator
    {
        decimal ValueProducts(IEnumerable<Product> products);

    }
}
