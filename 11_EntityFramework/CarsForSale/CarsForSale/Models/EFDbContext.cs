using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CarsForSale.Models
{
    public class EFDbContext:DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}