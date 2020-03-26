using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class RoleRights
    {
        public int Id { get; set; }
        public string SecurityKey { get; set; }
        public int? RoleId { get; set; }
        public bool? Value { get; set; }
    }
}
