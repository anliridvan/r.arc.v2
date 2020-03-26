using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class Popups
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int UserId { get; set; }
    }
}
