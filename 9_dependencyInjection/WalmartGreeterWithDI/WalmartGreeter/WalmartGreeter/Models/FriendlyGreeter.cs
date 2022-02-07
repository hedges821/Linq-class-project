using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WalmartGreeter.Models;

namespace WalmartGreeter
{
    public class FriendlyGreeter : IGreeter
    {
        public string SayHi()
        {
            return "Welcome to Walmart!  How are you doing today?";
        }
        public string TheImagePath()
        {
            return "Images\\FriendlyGuy.jpg";
        }
    }
}