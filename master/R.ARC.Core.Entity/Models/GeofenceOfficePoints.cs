using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class GeofenceOfficePoints
    {
        public int Id { get; set; }
        public int GeofenceId { get; set; }
        public string PlaceName { get; set; }
        public string[] Points { get; set; }
    }
}
