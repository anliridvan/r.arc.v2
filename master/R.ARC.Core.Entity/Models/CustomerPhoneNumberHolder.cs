using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class CustomerPhoneNumberHolder
    {
        public int? CustomerId { get; set; }
        public string TempPhoneCountryCode { get; set; }
        public string TempPhoneNumber { get; set; }
    }
}
