using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test3StarterFile.Models
{
    public class EFCarRepository : ICarRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Car> Cars
        {
            get { return context.Cars; }
        }
    }
}