using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class ScooterUpdateLog
    {
        public int Id { get; set; }
        public DateTime? Ts { get; set; }
        public int OkCount { get; set; }
        public int ErrorCount { get; set; }
    }
}
