using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class ScooterErrorsBacklog
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public int? Priority { get; set; }
        public DateTime? Ts { get; set; }
        public int Id { get; set; }
    }
}
