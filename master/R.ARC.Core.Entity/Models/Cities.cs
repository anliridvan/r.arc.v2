using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class Cities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int? CountryId { get; set; }
        public string[] GeohashList { get; set; }
    }
}
