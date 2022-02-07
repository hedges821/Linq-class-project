﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCartApp.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}