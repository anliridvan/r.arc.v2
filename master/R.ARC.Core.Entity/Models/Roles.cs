using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class Roles
    {
        public Roles()
        {
            RoleClaims = new HashSet<RoleClaims>();
            UserRoles = new HashSet<UserRoles>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsEnabled { get; set; }
        public bool? IsSystemRole { get; set; }
        public string Description { get; set; }

        public virtual ICollection<RoleClaims> RoleClaims { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
