using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class InventoryCategories
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public string CategoryName { get; set; }
    }
}
