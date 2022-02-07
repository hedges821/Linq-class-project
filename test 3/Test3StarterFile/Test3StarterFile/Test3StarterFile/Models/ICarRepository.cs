using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3StarterFile.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> Cars { get; }

    }
}
