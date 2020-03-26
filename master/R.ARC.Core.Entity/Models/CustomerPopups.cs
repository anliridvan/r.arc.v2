using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class CustomerPopups
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public int? UserId { get; set; }
        public bool IsRead { get; set; }
        public int PopupId { get; set; }
        public DateTime? ReadDate { get; set; }
    }
}
