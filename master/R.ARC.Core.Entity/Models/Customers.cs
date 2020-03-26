using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Reservations = new HashSet<Reservations>();
            Rides = new HashSet<Rides>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobilePhoneCountryCode { get; set; }
        public string MobilePhone { get; set; }
        public string SmsCode { get; set; }
        public string AccessToken { get; set; }
        public bool? IsEnabled { get; set; }
        public string Language { get; set; }
        public string OneSignalId { get; set; }
        public bool? SkipVerification { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastSignedinAt { get; set; }
        public bool FreeTier { get; set; }
        public string Tckn { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Notes { get; set; }
        public bool IsKvkkRead { get; set; }
        public DateTime? KvkkDate { get; set; }
        public bool? TcknValidated { get; set; }
        public string IdPhoto { get; set; }

        public virtual ICollection<Reservations> Reservations { get; set; }
        public virtual ICollection<Rides> Rides { get; set; }
    }
}
