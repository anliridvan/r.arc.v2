using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class Banks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public bool IsActive { get; set; }
        public bool IsEnabled { get; set; }
        public string EftCode { get; set; }
    }
}
