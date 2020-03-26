using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class UserBreaks
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int ShiftNo { get; set; }
        public int? BreakReasonId { get; set; }
        public string OtherText { get; set; }
    }
}
