using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class ScooterLockCodeHistory
    {
        public int Id { get; set; }
        public int? ScooterId { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
