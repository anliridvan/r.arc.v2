using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class ScooterErrors
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime Ts { get; set; }
        public int? ErrorCode { get; set; }
    }
}
