using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class CreditCards
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string Last4Digits { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string PaymentServiceToken { get; set; }
        public bool? IsDefault { get; set; }
        public string NameOnCard { get; set; }
        public bool? IsActive { get; set; }
        public string UserToken { get; set; }
        public string CcType { get; set; }
        public string CcAssociation { get; set; }
    }
}
