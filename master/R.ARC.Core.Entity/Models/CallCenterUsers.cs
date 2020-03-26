using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class CallCenterUsers
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string AgentId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
