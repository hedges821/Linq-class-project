﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeStore.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}