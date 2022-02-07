using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreatureComforts.Models
{
    public class Pet
    {
        public int PetID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public int PetTypeID { get; set; }
        public int OwnerID { get; set; }
        public virtual PetType PetType { get; set; }
        public virtual Owner Owner { get; set; }
    }
}