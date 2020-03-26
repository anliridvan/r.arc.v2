using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class RepairResultMaterialsUsage
    {
        public int Id { get; set; }
        public int RepairId { get; set; }
        public int ResultMaterialId { get; set; }
        public int? Quantity { get; set; }
        public string OldSerialNo { get; set; }
        public string NewSerialNo { get; set; }
    }
}
