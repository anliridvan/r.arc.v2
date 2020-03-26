using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class RideRefundRequestHistory
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public int Status { get; set; }
        public string Reason { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UserId { get; set; }
        public int? RefundId { get; set; }

        public virtual RideRefunds Refund { get; set; }
        public virtual RideRefundRequests Request { get; set; }
        public virtual Users User { get; set; }
    }
}
