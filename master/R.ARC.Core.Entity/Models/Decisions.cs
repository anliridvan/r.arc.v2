using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class Decisions
    {
        public Decisions()
        {
            InverseParent = new HashSet<Decisions>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Order { get; set; }
        public int? ParentId { get; set; }

        public virtual Decisions Parent { get; set; }
        public virtual ICollection<Decisions> InverseParent { get; set; }
    }
}
