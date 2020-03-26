using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class ScooterRepairCategories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Order { get; set; }
        public int[] ResultCodes { get; set; }
        public string GroupName { get; set; }
    }
}
