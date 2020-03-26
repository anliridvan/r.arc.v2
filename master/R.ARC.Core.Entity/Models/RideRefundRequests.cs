using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class RideRefundRequests
    {
        public RideRefundRequests()
        {
            RideRefundRequestHistory = new HashSet<RideRefundRequestHistory>();
        }

        public int Id { get; set; }
        public int RideId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Source { get; set; }
        public string Reason { get; set; }

        public virtual ICollection<RideRefundRequestHistory> RideRefundRequestHistory { get; set; }
    }
}
