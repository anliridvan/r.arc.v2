using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class TaxOffices
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CityId { get; set; }
        public int? DistrictId { get; set; }
        public string Code { get; set; }
    }
}
