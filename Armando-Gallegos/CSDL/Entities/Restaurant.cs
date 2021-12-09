using System;
using System.Collections.Generic;

#nullable disable

namespace CSDL.Entities
{
    public partial class Restaurant
    {
        public int RShip { get; set; }
        public int RId { get; set; }
        public string RName { get; set; }
        public string RDescription { get; set; }
        public int RTables { get; set; }
    }
}
