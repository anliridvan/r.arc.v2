using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class GeofenceRegionPoints
    {
        public int Id { get; set; }
        public int? FenceId { get; set; }
        public string MapData { get; set; }
    }
}
