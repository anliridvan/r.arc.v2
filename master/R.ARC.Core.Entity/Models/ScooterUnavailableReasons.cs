using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class ScooterUnavailableReasons
    {
        public int Id { get; set; }
        public int? ScooterId { get; set; }
        public string Reason { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
