using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class OperationWorkOrders
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? IssuedBy { get; set; }
        public DateTime IssuedAt { get; set; }
        public int Status { get; set; }
        public DateTime? CompletedAt { get; set; }
        public int[] Regions { get; set; }
    }
}
