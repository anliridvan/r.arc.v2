using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class CustomerCheckmobiPins
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string CheckmobiId { get; set; }
        public bool IsVerified { get; set; }
    }
}
