using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class GeofenceKeys
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PointIndex { get; set; }
        public int? FenceId { get; set; }
    }
}
