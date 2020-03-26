using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class UserGeofences
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? GeofenceGroup { get; set; }
    }
}
