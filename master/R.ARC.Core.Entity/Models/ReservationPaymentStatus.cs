using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class ReservationPaymentStatus
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int? Order { get; set; }
    }
}
