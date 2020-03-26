using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class CampaignsCustomers
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public int CustomerId { get; set; }
    }
}
