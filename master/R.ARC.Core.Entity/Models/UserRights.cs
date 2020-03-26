using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class UserRights
    {
        public int RightId { get; set; }
        public int UserId { get; set; }
        public int State { get; set; }
        public int Id { get; set; }
    }
}
