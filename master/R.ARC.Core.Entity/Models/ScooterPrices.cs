using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class ScooterPrices
    {
        public int Id { get; set; }
        public int? GeofenceGroup { get; set; }
        public int? ScooterBodyVersionId { get; set; }
        public decimal? StartingPrice { get; set; }
        public decimal? RecurringPrice { get; set; }
        public decimal? ReservationPrice { get; set; }
    }
}
