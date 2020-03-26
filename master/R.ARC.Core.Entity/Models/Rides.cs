using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class Rides
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? ScooterId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Distance { get; set; }
        public decimal? ChargedPrice { get; set; }
        public int? CreditCardId { get; set; }
        public string PaymentServicePaymentToken { get; set; }
        public string[] MapData { get; set; }
        public bool? PaymentSuccessful { get; set; }
        public string Photo { get; set; }
        public int? ApprovedUserId { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApprovedNote { get; set; }
        public bool? IsApproved { get; set; }
        public decimal? ActualPrice { get; set; }
        public string LastRidePoint { get; set; }
        public string PaymentServiceTransactionId { get; set; }
        public int? GeofenceGroup { get; set; }
        public string ProvisionTransaction { get; set; }
        public string AdditionalPaymentTransaction { get; set; }
        public int? UserId { get; set; }
        public int? CampaignId { get; set; }
        public int ReservationId { get; set; }
        public decimal ReservationPrice { get; set; }
        public long? StartMileage { get; set; }
        public long? EndMileage { get; set; }
        public bool? RideRefundedByMileage { get; set; }
        public decimal? TotalPrice { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Scooters Scooter { get; set; }
    }
}
