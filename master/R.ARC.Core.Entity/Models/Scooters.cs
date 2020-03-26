using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class Scooters
    {
        public Scooters()
        {
            Reservations = new HashSet<Reservations>();
            Rides = new HashSet<Rides>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public int Version { get; set; }
        public int? StatusId { get; set; }
        public int? BatteryStatus { get; set; }
        public string LastKnownPoint { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public int? ModuleBatteryStatus { get; set; }
        public string LockCode { get; set; }
        public string SimCardNo { get; set; }
        public bool? IsAvailable { get; set; }
        public int Timezone { get; set; }
        public int? LastRideId { get; set; }
        public DateTime? LastStolenTime { get; set; }
        public string MqttPassword { get; set; }
        public string FirmwareVersion { get; set; }
        public string BtMac { get; set; }
        public float Hdop { get; set; }
        public bool Attention { get; set; }
        public int GeofenceGroup { get; set; }
        public bool? NeedRepair { get; set; }
        public string NeedRepairNote { get; set; }
        public bool? GsmAvailable { get; set; }
        public string GsmLocation { get; set; }
        public string MobilePhoneNumber { get; set; }
        public long? TotalKm { get; set; }
        public DateTime LastFotaTime { get; set; }
        public long? SubStatus { get; set; }
        public int? ChargingStationId { get; set; }
        public int? ScooterBodyVersionId { get; set; }
        public decimal? StartingPrice { get; set; }
        public decimal? RecurringPrice { get; set; }
        public bool IotLocked { get; set; }
        public DateTime? LastLockedTime { get; set; }
        public int Life { get; set; }
        public decimal ReservationPrice { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<Reservations> Reservations { get; set; }
        public virtual ICollection<Rides> Rides { get; set; }
    }
}
