using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class InventoryPartCounts
    {
        public int Id { get; set; }
        public string PartStockCode { get; set; }
        public int? StockCount { get; set; }
        public string AssetKey { get; set; }
        public int? WarehouseId { get; set; }
    }
}
