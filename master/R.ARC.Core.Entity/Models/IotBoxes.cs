using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class IotBoxes
    {
        public int Id { get; set; }
        public string SerialNo { get; set; }
        public int Life { get; set; }
        public int? ScooterId { get; set; }
        public int? Status { get; set; }
        public int? BodyVersionId { get; set; }
        public int WarehouseId { get; set; }
        public decimal? Price { get; set; }
        public string StockCode { get; set; }
    }
}
