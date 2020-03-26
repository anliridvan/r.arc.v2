using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class DailyCurrencies
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
    }
}
