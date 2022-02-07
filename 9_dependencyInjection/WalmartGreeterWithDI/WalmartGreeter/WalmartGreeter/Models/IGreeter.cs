using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalmartGreeter.Models
{
    public interface IGreeter
    {
        string SayHi();
        string TheImagePath();

    }
}
