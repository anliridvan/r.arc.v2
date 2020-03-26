using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class Cars
    {
        public int Id { get; set; }
        public string Plate { get; set; }
        public string Name { get; set; }
        public int? Driver1 { get; set; }
        public int? Driver2 { get; set; }
        public string PhoneMac { get; set; }
        public int? FenceGroup { get; set; }
        public int[] Drivers { get; set; }
    }
}
