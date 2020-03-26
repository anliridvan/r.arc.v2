using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class Campaigns
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int DiscountValue { get; set; }
        public int DiscountType { get; set; }
        public int DiscountOn { get; set; }
        public int CampaignType { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
        public int DiscountMaxUsableTime { get; set; }
        public string DetailFilePath { get; set; }
    }
}
