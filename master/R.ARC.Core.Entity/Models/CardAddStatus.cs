using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class CardAddStatus
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string BinNumber { get; set; }
        public DateTime? Ts { get; set; }
        public string CardType { get; set; }
        public string CardAssociation { get; set; }
        public string CardFamilyName { get; set; }
        public bool? Force3ds { get; set; }
        public string VendorErrorCode { get; set; }
        public string VendorErrorMessage { get; set; }
        public bool? Success { get; set; }
        public string BankName { get; set; }
        public string VendorErrorGroup { get; set; }
    }
}
