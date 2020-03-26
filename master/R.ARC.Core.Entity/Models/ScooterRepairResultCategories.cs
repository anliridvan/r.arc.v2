using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class ScooterRepairResultCategories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ResultCode { get; set; }
    }
}
