using System;
using System.Collections.Generic;

#nullable disable

namespace CSDL.Entities
{
    public partial class PassangerRestaurant
    {
        public int PcabinNo { get; set; }
        public string PassName { get; set; }
        public int RIdNo { get; set; }
        public string RestName { get; set; }

        public virtual Passanger PcabinNoNavigation { get; set; }
        public virtual Restaurant RIdNoNavigation { get; set; }
    }
}
