using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class PbRentReviewCategories
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public int[] Stars { get; set; }
        public bool ShowNote { get; set; }
    }
}
