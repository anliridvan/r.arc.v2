using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class AwsdmsDdlAudit
    {
        public long CKey { get; set; }
        public DateTime? CTime { get; set; }
        public string CUser { get; set; }
        public string CTxn { get; set; }
        public string CTag { get; set; }
        public int? COid { get; set; }
        public string CName { get; set; }
        public string CSchema { get; set; }
        public string CDdlqry { get; set; }
    }
}
