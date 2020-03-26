using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class ScooterStatus
    {
        public ScooterStatus()
        {
            ScooterSubstatus = new HashSet<ScooterSubstatus>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public int? OrderNo { get; set; }
        public string GroupName { get; set; }

        public virtual ICollection<ScooterSubstatus> ScooterSubstatus { get; set; }
    }
}
