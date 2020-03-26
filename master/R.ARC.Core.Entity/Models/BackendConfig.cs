using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class BackendConfig
    {
        public int Id { get; set; }
        public string AndroidVer { get; set; }
        public string IosVer { get; set; }
        public string CurrentFwVersion { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string MsgEn { get; set; }
        public string MsgTr { get; set; }
        public string BgColor { get; set; }
        public string ImgUrl { get; set; }
        public string Icon { get; set; }
        public string StartingPrice { get; set; }
        public string PricePerMinute { get; set; }
        public int? FineAmount { get; set; }
        public string ProvisionPrice { get; set; }
        public int? RateUsRideCount { get; set; }
        public int? RateUsPeriod { get; set; }
        public string AndroidOperatorVer { get; set; }
        public string AndroidServiceVer { get; set; }
        public string IosOperatorVer { get; set; }
        public string IosServiceVer { get; set; }
        public int MaxRideDebtValue { get; set; }
        public string AndroidServiceUrl { get; set; }
        public string AndroidOperatorUrl { get; set; }
        public string IosServiceUrl { get; set; }
        public string IosOperatorUrl { get; set; }
        public int ReservationNotificationMinutes { get; set; }
        public int? ListAvailablesZoomLevel { get; set; }
        public string PbRentPrice { get; set; }
        public string PbProvisionPrice { get; set; }
    }
}
