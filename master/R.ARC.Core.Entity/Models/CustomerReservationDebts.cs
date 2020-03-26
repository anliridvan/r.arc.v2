using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class CustomerReservationDebts
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ReservationId { get; set; }
        public int CardId { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsSuccess { get; set; }
        public int? UserId { get; set; }
    }
}
