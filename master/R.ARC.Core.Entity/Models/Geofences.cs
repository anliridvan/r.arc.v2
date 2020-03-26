using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class Geofences
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsVisible { get; set; }
        public int? GeofenceGroup { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string MsgEn { get; set; }
        public string MsgTr { get; set; }
        public int DiscountAmount { get; set; }
        public bool AlwaysOn { get; set; }
        public string CityName { get; set; }
        public int TaxApplied { get; set; }
        public string Center { get; set; }
        public bool? EnableStartPrice { get; set; }
        public bool? EnableReservation { get; set; }
        public bool? RequireCreditCard { get; set; }
    }
}
