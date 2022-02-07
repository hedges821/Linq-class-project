using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WalmartGreeter.Models;

namespace WalmartGreeter.Models
{
    public class HappyGreeter : IGreeter
    {
        public string SayHi()
        {
            return "Happy to see you. Have a great day!";
        }
        public string TheImagePath()
        {
            return "Images\\HappyGuy.jpg";
        }


    }
}