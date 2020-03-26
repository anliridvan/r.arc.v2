using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class InventoryParts
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string StockCode { get; set; }
        public string PartName { get; set; }
        public string ManufacturerPartNumber { get; set; }
        public string AssetKey { get; set; }
    }
}
