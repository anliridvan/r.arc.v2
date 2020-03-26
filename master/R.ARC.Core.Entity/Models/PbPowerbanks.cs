using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class PbPowerbanks
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int StatusId { get; set; }
        public int LastRentId { get; set; }
        public int BatteryLevel { get; set; }
        public DateTime LastSeenAt { get; set; }
        public int? LastSeenStationId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int? CurrentSlot { get; set; }
        public decimal StartingPrice { get; set; }
        public decimal RecurringPrice { get; set; }
        public bool? IsInside { get; set; }
        public bool? NeedRepair { get; set; }
        public string RepairNote { get; set; }
    }
}
