using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class ScooterSubstatus
    {
        public int Id { get; set; }
        public int? StatusId { get; set; }
        public string Name { get; set; }
        public int? OrderNo { get; set; }
        public bool? IsActive { get; set; }

        public virtual ScooterStatus Status { get; set; }
    }
}
