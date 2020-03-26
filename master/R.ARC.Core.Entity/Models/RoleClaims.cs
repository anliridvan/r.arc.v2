using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class RoleClaims
    {
        public int Id { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public int RoleId { get; set; }

        public virtual Roles Role { get; set; }
    }
}
