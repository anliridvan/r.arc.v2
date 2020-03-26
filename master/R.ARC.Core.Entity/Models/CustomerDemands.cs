using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class CustomerDemands
    {
        public int Id { get; set; }
        public long CustomerId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public DateTime Ts { get; set; }
    }
}
