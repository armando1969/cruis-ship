using System;
using System.Collections.Generic;

#nullable disable

namespace CSDL.Entities
{
    public partial class Activity
    {
        public int AShip { get; set; }
        public int AId { get; set; }
        public string AName { get; set; }
        public string ADescription { get; set; }
        public string AInstructor { get; set; }
        public int ASpots { get; set; }
    }
}
