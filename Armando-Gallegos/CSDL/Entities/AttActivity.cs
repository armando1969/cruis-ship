using System;
using System.Collections.Generic;

#nullable disable

namespace CSDL.Entities
{
    public partial class AttActivity
    {
        public int AttId { get; set; }
        public int AIdNo { get; set; }

        public virtual Activity AIdNoNavigation { get; set; }
        public virtual Attendant Att { get; set; }
    }
}
