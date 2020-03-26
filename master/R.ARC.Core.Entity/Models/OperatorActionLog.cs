using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class OperatorActionLog
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ScooterId { get; set; }
        public int? FromStatusId { get; set; }
        public int? ToStatusId { get; set; }
        public string Note { get; set; }
        public DateTime? ActionTime { get; set; }
        public int? WorkOrderId { get; set; }
        public int? CarId { get; set; }
        public string Photo { get; set; }
        public bool? IsValidated { get; set; }
        public int? ValidatedBy { get; set; }
        public DateTime? ValidationDate { get; set; }
        public string Position { get; set; }
        public int? RepairRecordId { get; set; }
    }
}
