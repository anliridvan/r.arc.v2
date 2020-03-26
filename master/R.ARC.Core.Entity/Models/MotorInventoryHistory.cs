using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class MotorInventoryHistory
    {
        public int Id { get; set; }
        public int ScooterId { get; set; }
        public int MotorId { get; set; }
        public int Life { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
