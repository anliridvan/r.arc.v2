using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class ScooterRepairRecords
    {
        public int Id { get; set; }
        public int ScooterId { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public int RepairTypeId { get; set; }
        public int RepairCategoryId { get; set; }
        public string RepairNote { get; set; }
        public int? CloseUser { get; set; }
        public DateTime? CloseDate { get; set; }
        public int? RepairResultCategoryId { get; set; }
        public bool IsFixed { get; set; }
        public int? StatusId { get; set; }
        public string Photo { get; set; }
        public DateTime? StartTime { get; set; }
        public bool IsChecked { get; set; }
        public int? WarehouseId { get; set; }
        public bool IsCanceled { get; set; }
        public int? RepairUserId { get; set; }
    }
}
