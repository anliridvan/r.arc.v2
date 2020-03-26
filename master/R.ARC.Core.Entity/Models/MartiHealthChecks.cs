using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class MartiHealthChecks
    {
        public int Id { get; set; }
        public string MqttStatus { get; set; }
        public string FotaStatus { get; set; }
        public string LambdaStatus { get; set; }
        public string MqttHelperStatus { get; set; }
        public string CcStatus { get; set; }
        public DateTime? Ts { get; set; }
    }
}
