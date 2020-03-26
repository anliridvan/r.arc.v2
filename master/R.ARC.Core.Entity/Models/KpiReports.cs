using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class KpiReports
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int? ScootersDeployed { get; set; }
        public decimal? OperationalHours { get; set; }
        public decimal? GrossScootersAvailableHours { get; set; }
        public decimal? ScooterAvailabilityPercent { get; set; }
        public decimal? NetScooterHoursAvailable { get; set; }
        public int? TotalRides { get; set; }
        public decimal? RidesPerScooter { get; set; }
        public decimal? RidesPerScooterPerHour { get; set; }
        public decimal? GrossRevenueTl { get; set; }
        public decimal? DiscountsTl { get; set; }
        public decimal? DiscountsPercent { get; set; }
        public decimal? NetRevenueTl { get; set; }
        public decimal? DollarTl { get; set; }
        public decimal? GrossRevenueDollar { get; set; }
        public decimal? DiscountsDollar { get; set; }
        public decimal? NetRevenueDollar { get; set; }
        public decimal? GrossRevenuePerRideTl { get; set; }
        public decimal? NetRevenuePerRideTl { get; set; }
        public decimal? GrossRevenuePerRideDollar { get; set; }
        public decimal? NetRevenuePerRideDollar { get; set; }
        public decimal? GrossRevenuePerScooterTl { get; set; }
        public decimal? NetRevenuePerScooterTl { get; set; }
        public decimal? GrossRevenuePerScooterDollar { get; set; }
        public decimal? NetRevenuePerScooterDollar { get; set; }
        public int? TotalRideMinutes { get; set; }
        public decimal? AvgRideTime { get; set; }
        public int? ScootersLost { get; set; }
        public decimal? ScootersLostPercent { get; set; }
        public int? ScootersDamagedRecoverable { get; set; }
        public decimal? ScootersDamagedRecoverablePercent { get; set; }
        public int? ScootersDamagedNotRecoverable { get; set; }
        public decimal? ScootersDamagedNotRecoverablePercent { get; set; }
        public int? ScooterRecovered { get; set; }
        public decimal? UnrecoverableRatePercent { get; set; }
        public int? Registrations { get; set; }
        public int? TotalRegistrations { get; set; }
        public int? UniqueUsersWhoCompletedRides { get; set; }
        public decimal? ShareOfRepeatUsersAmongUniqueUsers { get; set; }
        public int? TotalUniqueUsersWhoCompletedRides { get; set; }
        public decimal? TotalRegistrationsUniqueUsersCompletedRidesConversion { get; set; }
        public decimal? RidesPerUniqueUser { get; set; }
        public decimal? TotalRideKm { get; set; }
        public decimal? KmPerRide { get; set; }
        public int RollingWeeklyUniqueRiders { get; set; }
        public int RepairCount { get; set; }
        public int? GeofenceGroup { get; set; }
    }
}
