using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class RideAccidents
    {
        public int Id { get; set; }
        public int RideId { get; set; }
        public int CreatedBy { get; set; }
        public int? ResponseUserId { get; set; }
        public string Address { get; set; }
        public DateTime AccidentDate { get; set; }
        public int AccidentReason { get; set; }
        public int AccidentType { get; set; }
        public string AccidentTypeNote { get; set; }
        public bool ExternalSourcesExist { get; set; }
        public bool SeenOnMedia { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
