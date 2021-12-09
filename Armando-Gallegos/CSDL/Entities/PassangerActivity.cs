using System;
using System.Collections.Generic;

#nullable disable

namespace CSDL.Entities
{
    public partial class PassangerActivity
    {
        public int PcabinNo { get; set; }
        public string PassName { get; set; }
        public int AIdNo { get; set; }
        public string ActName { get; set; }

        public virtual Activity AIdNoNavigation { get; set; }
        public virtual Passanger PcabinNoNavigation { get; set; }
    }
}
