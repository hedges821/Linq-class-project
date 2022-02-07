using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeStore.Models
{
    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Product> Products
        {
            get { return context.Products.Include("Category"); }
        }

        public IEnumerable<Category> Categories
        {
            get { return context.Categories; }
        }

    }
}