﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeStore.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<Category> Categories { get; }

    }
}
