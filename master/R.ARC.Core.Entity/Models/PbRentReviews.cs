using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class PbRentReviews
    {
        public int Id { get; set; }
        public int RentId { get; set; }
        public int? PointsGiven { get; set; }
        public string Review { get; set; }
        public int[] TagList { get; set; }
    }
}
