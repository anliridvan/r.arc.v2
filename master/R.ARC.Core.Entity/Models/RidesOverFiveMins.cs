using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class RidesOverFiveMins
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public long RideId { get; set; }
        public bool IsFixed { get; set; }
    }
}
