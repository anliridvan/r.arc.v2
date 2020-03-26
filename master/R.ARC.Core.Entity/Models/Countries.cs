using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class Countries
    {
        public int Id { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string IsoCode { get; set; }
        public string Icon { get; set; }
        public int? Order { get; set; }
    }
}
