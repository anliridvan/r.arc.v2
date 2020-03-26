using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class CustomerCallRecords
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Surname { get; set; }
        public string Src { get; set; }
        public long? Dst { get; set; }
        public DateTime? Calldate { get; set; }
        public int? Duration { get; set; }
        public string Uid { get; set; }
        public string Uniqueid { get; set; }
    }
}
