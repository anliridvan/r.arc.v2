using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class Regions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsEnabled { get; set; }
        public string MapData { get; set; }
        public int? FenceId { get; set; }
    }
}
