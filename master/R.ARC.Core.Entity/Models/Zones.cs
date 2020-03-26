using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class Zones
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool? IsEnabled { get; set; }
        public int? ScooterCount { get; set; }
        public int? RegionId { get; set; }
    }
}
