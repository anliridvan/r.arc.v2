using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class ScooterAlertDetail
    {
        public int Id { get; set; }
        public long ScooterId { get; set; }
        public int Speed { get; set; }
        public bool GpsError { get; set; }
        public DateTime Timestamp { get; set; }
        public bool IsFixed { get; set; }
    }
}
