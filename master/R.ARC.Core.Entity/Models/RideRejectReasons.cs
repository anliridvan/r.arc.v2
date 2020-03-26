using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class RideRejectReasons
    {
        public int Id { get; set; }
        public string MessageTr { get; set; }
        public string MessageEn { get; set; }
        public string Reason { get; set; }
    }
}
