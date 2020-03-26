using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class InventoryComponentCounts
    {
        public int Id { get; set; }
        public string ComponentStockCode { get; set; }
        public int? StockCount { get; set; }
        public int? WarehouseId { get; set; }
    }
}
