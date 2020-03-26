using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class IotLockInventoryHistory
    {
        public int Id { get; set; }
        public int ScooterId { get; set; }
        public int IotLockId { get; set; }
        public int Life { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
