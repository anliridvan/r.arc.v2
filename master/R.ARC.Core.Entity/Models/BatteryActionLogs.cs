using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class BatteryActionLogs
    {
        public int Id { get; set; }
        public int BatteryId { get; set; }
        public int? ToScooterId { get; set; }
        public int? FromScooterId { get; set; }
        public int UserId { get; set; }
        public int FromStatus { get; set; }
        public int ToStatus { get; set; }
        public DateTime ActionTime { get; set; }
        public int? GeofenceGroup { get; set; }
        public string Location { get; set; }
        public int? WarehouseId { get; set; }
    }
}
