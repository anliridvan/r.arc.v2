using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class UserShifts
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime ShiftDate { get; set; }
        public int ShiftNo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? CarId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int WarehouseId { get; set; }
        public int? FenceGroup { get; set; }
    }
}
