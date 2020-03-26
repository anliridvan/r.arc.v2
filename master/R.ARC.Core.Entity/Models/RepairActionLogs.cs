using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class RepairActionLogs
    {
        public int Id { get; set; }
        public int RepairRecordId { get; set; }
        public int UserId { get; set; }
        public int ActionType { get; set; }
        public DateTime ActionTime { get; set; }
        public int? Reason { get; set; }
    }
}
