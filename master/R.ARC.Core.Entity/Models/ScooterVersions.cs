using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class ScooterVersions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CurrentFirmwareVersion { get; set; }
        public bool IsDefault { get; set; }
    }
}
