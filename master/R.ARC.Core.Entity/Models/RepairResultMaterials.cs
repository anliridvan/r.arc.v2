using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class RepairResultMaterials
    {
        public int Id { get; set; }
        public int BodyVersion { get; set; }
        public string StockCode { get; set; }
        public bool? IsPart { get; set; }
        public bool HasQuantity { get; set; }
        public int ResultCode { get; set; }
        public string Name { get; set; }
        public bool HasStockEffect { get; set; }
    }
}
