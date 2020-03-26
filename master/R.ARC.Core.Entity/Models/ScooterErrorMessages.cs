using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class ScooterErrorMessages
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
        public int? Priority { get; set; }
        public DateTime? Ts { get; set; }
    }
}
