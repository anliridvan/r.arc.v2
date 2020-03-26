using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class ChargeStations
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int? GeofenceId { get; set; }
    }
}
