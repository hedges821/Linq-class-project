using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;

namespace CIS275_Test1.Models
{
    public class Dealership
    {
        public int DealershipID { get; set; }
        [DisplayName("Dealership Name")]
        public string DealershipName{get; set;}
        public string Phone { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Car> Cars { get; set; }

    }
}