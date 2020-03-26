using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class GovernmentUsers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int? DistrictId { get; set; }
        public string City { get; set; }
        public bool? IsEnabled { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }
    }
}
