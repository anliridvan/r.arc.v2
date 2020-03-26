using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class Warehouses
    {
        public int Id { get; set; }
        public string WarehouseName { get; set; }
        public int? GeofenceGroup { get; set; }
        public bool? IsActive { get; set; }
        public int CarId { get; set; }
        public bool IsDefault { get; set; }
    }
}
