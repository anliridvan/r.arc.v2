using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class PbStations
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime? LastSeenAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? LocationId { get; set; }
    }
}
