using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class Expenses
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Amount { get; set; }
        public string Description { get; set; }
    }
}
