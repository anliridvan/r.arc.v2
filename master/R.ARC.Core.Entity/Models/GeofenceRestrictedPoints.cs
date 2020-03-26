using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class GeofenceRestrictedPoints
    {
        public int Id { get; set; }
        public int? FenceGroup { get; set; }
        public string Points { get; set; }
        public bool? IsEnabled { get; set; }
        public string Name { get; set; }
    }
}
