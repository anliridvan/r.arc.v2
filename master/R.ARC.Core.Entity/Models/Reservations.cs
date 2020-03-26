using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class Reservations
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ScooterId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal? Amount { get; set; }
        public int? PaymentStatus { get; set; }
        public int? CardId { get; set; }
        public DateTime? PaymentTime { get; set; }
        public int? UserId { get; set; }
        public string PaymentServicePaymentToken { get; set; }
        public string PaymentServiceTransactionId { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Scooters Scooter { get; set; }
    }
}
