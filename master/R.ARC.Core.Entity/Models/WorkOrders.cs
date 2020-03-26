using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class WorkOrders
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int? CarId { get; set; }
        public int? PersonelId { get; set; }
        public int[] Regions { get; set; }
        public bool? IsCompleted { get; set; }
        public string Note { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int? CompletedUserId { get; set; }
        public int? Total { get; set; }
        public int[] Personel { get; set; }
    }
}
