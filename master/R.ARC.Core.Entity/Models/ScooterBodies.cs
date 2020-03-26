using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class ScooterBodies
    {
        public int Id { get; set; }
        public long ScooterId { get; set; }
        public int ScooterBodyVersionId { get; set; }
        public int Life { get; set; }
    }
}
