using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class CarDeliveries
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int UserId { get; set; }
        public DateTime PickedAt { get; set; }
        public DateTime? DeliveredAt { get; set; }
        public int? PickKm { get; set; }
        public string[] PickingPhotos { get; set; }
        public string[] DeliveringPhotos { get; set; }
        public bool? HasIssue { get; set; }
        public string Issue { get; set; }
        public int? DeliverKm { get; set; }
        public int? AssistantUserId { get; set; }
    }
}
