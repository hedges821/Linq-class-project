using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;

namespace CreatureComforts.Models
{
    public class PetType
    {
        public int PetTypeID { get; set; }
        [DisplayName("Pet Type")]
        public string PetTypeName { get; set; }
        public virtual ICollection<Pet> Pets {get; set;}
    }
}