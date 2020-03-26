using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class Coupons
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public long? CustomerId { get; set; }
        public bool IsUsed { get; set; }
        public long? RideId { get; set; }
        public decimal Amount { get; set; }
        public DateTime? UsedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ExpiresAt { get; set; }
        public long UserId { get; set; }
        public DateTime? CustomerExpiresAt { get; set; }
        public string BatchKey { get; set; }
    }
}
