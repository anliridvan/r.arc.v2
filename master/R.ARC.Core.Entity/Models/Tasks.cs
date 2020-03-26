using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class Tasks
    {
        public int Id { get; set; }
        public int? CreatedBy { get; set; }
        public int? TaskOwner { get; set; }
        public int Status { get; set; }
        public int Priority { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? CancelledBy { get; set; }
        public int? ScooterId { get; set; }
        public int TaskType { get; set; }
        public string ToLocation { get; set; }
        public int? TaskCount { get; set; }
        public int? BlockedBy { get; set; }
        public string TaskLocation { get; set; }
        public string BlockedReason { get; set; }
        public int? BatteryId { get; set; }
        public DateTime? ValidUntil { get; set; }
    }
}
