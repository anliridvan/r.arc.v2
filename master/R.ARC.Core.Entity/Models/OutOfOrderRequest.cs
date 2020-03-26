using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class OutOfOrderRequest
    {
        public int Id { get; set; }
        public int RepairId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedNote { get; set; }
        public bool? IsApproved { get; set; }
        public int? ApprovedBy { get; set; }
    }
}
