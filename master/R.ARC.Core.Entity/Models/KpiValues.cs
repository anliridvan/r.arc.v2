using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class KpiValues
    {
        public int Id { get; set; }
        public DateTime? KpiDate { get; set; }
        public int? FenceGroup { get; set; }
        public int? TotalDeployed { get; set; }
        public int? TotalCount { get; set; }
        public decimal? AvgRideSeconds { get; set; }
        public decimal? AvgAvailableSeconds { get; set; }
        public int? RideCount { get; set; }
    }
}
