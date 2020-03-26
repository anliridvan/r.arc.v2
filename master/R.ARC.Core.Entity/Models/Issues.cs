using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class Issues
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? ReportDate { get; set; }
        public string ScooterId { get; set; }
        public string Location { get; set; }
        public string Comment { get; set; }
        public string Photo { get; set; }
        public int? IssueTypeId { get; set; }
        public bool? IsFixed { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int GeofenceGroup { get; set; }
        public DateTime? FixedDate { get; set; }
        public int? UpdateUserId { get; set; }
        public string SolutionDetail { get; set; }
        public int? OriginalIssueId { get; set; }
        public DateTime? CaseStartTime { get; set; }
        public DateTime? CaseEndTime { get; set; }
        public int? CallDuration { get; set; }
        public int? FinalDecisionId { get; set; }
        public int? Status { get; set; }
        public string OtherText { get; set; }
        public int? PreviousIssueId { get; set; }
        public int? Priority { get; set; }
        public DateTime? RedialTime { get; set; }
        public string CosmicRoomNote { get; set; }
    }
}
