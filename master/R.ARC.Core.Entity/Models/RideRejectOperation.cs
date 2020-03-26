using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class RideRejectOperation
    {
        public int Id { get; set; }
        public int RideId { get; set; }
        public bool? IsNotified { get; set; }
        public int? NotificationId { get; set; }
        public bool? IsPenaltyFeeAdded { get; set; }
        public bool? IsBlackListAdded { get; set; }
        public decimal? PenaltyFee { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
