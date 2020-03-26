using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class ScooterBodyHistory
    {
        public int Id { get; set; }
        public int ScooterId { get; set; }
        public int? BodyId { get; set; }
        public int? BatteryId { get; set; }
        public int? MotorId { get; set; }
        public int? MotorDriverId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
    }
}
