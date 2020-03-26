using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class SwappableBatteryStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Order { get; set; }
    }
}
