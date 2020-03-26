using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class CancellationRequests
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProviderType { get; set; }
        public int? Status { get; set; }
        public int RequestedBy { get; set; }
        public DateTime RequestedAt { get; set; }
        public int? ProcessedBy { get; set; }
        public DateTime? ProcessedAt { get; set; }
        public string RejectReason { get; set; }
        public string RequestReason { get; set; }
        public bool? IsReported { get; set; }
        public DateTime? ReportedAt { get; set; }
        public int RideId { get; set; }
    }
}
