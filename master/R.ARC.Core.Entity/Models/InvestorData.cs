using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class InvestorData
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public bool IsEnabled { get; set; }
        public string Name { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
