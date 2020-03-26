using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class CustomerScooterRequests
    {
        public int Id { get; set; }
        public long CustomerId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime Ts { get; set; }
    }
}
