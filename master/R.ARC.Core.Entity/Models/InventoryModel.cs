using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class InventoryModel
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public int? ScooterBodyVersionId { get; set; }
        public int? BomVersion { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
