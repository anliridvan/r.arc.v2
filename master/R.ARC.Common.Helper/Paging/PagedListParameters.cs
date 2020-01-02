using System.Collections.Generic;

namespace R.ARC.Common.Helper.Paging
{
    public class PagedListParameters
    {
        public IList<Order> Orders { get; set; } = new List<Order>();

        public Page Page { get; set; } = new Page();

        public Filter Filter { get; set; }
    }
}
