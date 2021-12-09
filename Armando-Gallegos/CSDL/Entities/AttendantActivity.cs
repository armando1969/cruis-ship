using System;
using System.Collections.Generic;

#nullable disable

namespace CSDL.Entities
{
    public partial class AttendantActivity
    {
        public int AttId { get; set; }
        public string AttName { get; set; }
        public int AIdNo { get; set; }
        public string ActName { get; set; }

        public virtual Activity AIdNoNavigation { get; set; }
        public virtual Attendant Att { get; set; }
    }
}
