using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class UserActionReasons
    {
        public int Id { get; set; }
        public string Reason { get; set; }
        public string ActionType { get; set; }
        public string Key { get; set; }
    }
}
