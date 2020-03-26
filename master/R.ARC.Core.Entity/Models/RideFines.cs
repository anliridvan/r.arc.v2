using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class RideFines
    {
        public int Id { get; set; }
        public int? RideId { get; set; }
        public int? Amount { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Note { get; set; }
        public int? CardId { get; set; }
    }
}
