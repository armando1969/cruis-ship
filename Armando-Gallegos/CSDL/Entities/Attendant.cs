using System;
using System.Collections.Generic;

#nullable disable

namespace CSDL.Entities
{
    public partial class Attendant
    {
        public int AttShip { get; set; }
        public int AttId { get; set; }
        public string AttName { get; set; }
        public string AttSpecialties { get; set; }
    }
}
