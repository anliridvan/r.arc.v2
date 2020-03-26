using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class ReservationRefunds
    {
        public int Id { get; set; }
        public int? ReservationId { get; set; }
        public string PaymentId { get; set; }
        public string ConversationId { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public string Response { get; set; }
        public bool? IsSuccess { get; set; }
    }
}
