using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class RidingPaymentErrors
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? RideId { get; set; }
        public DateTime? ErrorTime { get; set; }
        public int? CreditCardId { get; set; }
        public string Reason { get; set; }
        public bool? IsFixed { get; set; }
    }
}
