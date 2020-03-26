using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class OperatorLocationLogs
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Location { get; set; }
        public DateTime? Time { get; set; }
    }
}
