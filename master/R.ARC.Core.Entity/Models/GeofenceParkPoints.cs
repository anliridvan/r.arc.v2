using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class GeofenceParkPoints
    {
        public int Id { get; set; }
        public int GeofenceGroup { get; set; }
        public string Hash { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
    }
}
