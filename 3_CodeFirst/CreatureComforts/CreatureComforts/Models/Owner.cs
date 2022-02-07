using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;

namespace CreatureComforts.Models
{
    public class Owner
    {
        public int OwnerID { get; set; }
        [DisplayName("Owner")]
        public string Name { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Pet> Pets { get; set; }
    }
}