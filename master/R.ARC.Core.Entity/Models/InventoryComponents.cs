using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class InventoryComponents
    {
        public int Id { get; set; }
        public int? PartId { get; set; }
        public string ComponentStockCode { get; set; }
        public string ComponentName { get; set; }
        public string ManufacturerPartNumber { get; set; }
        public int QuantityPerScooter { get; set; }
    }
}
