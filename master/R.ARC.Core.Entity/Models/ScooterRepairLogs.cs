using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class ScooterRepairLogs
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ScooterId { get; set; }
        public int? ScooterRepairCategoryId { get; set; }
        public string Note { get; set; }
        public string Photo { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ScooterRepairResultCategoryId { get; set; }
        public int? ScooterRepairTypeId { get; set; }
        public int? RepairLogId { get; set; }
    }
}
