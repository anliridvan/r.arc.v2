using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class CustomerRideDebts
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int RideId { get; set; }
        public int? CardId { get; set; }
        public decimal? Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsSuccess { get; set; }
        public long? UserId { get; set; }
        public string PaymentToken { get; set; }
        public string TransactionToken { get; set; }
    }
}
