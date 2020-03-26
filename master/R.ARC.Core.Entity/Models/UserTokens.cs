using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class UserTokens
    {
        public string LoginProvider { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public string Value { get; set; }

        public virtual Users User { get; set; }
    }
}
