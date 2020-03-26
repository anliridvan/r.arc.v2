using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class PbRents
    {
        public int Id { get; set; }
        public int? StationId { get; set; }
        public int? PowerbankId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal? ChargedPrice { get; set; }
        public decimal? ActualPrice { get; set; }
        public string ProvisionToken { get; set; }
        public string ProvisionTransactionToken { get; set; }
        public string AdditionalPaymentToken { get; set; }
        public string AdditionalTransactionToken { get; set; }
        public int? ReturnStationId { get; set; }
        public bool? IsSuccess { get; set; }
        public long? CustomerId { get; set; }
        public bool? IsApproved { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? FromSlot { get; set; }
        public int? ToSlot { get; set; }
        public decimal? TotalPrice { get; set; }
    }
}
