using Microsoft.AspNetCore.Mvc;

namespace R.ARC.Common.Contract
{
    public class ListParameterModel : IListParameterModel
    {
        [FromQuery(Name = "pageindex")]
        public int? PageIndex { get; set; }
        [FromQuery(Name = "pagesize")]
        public short? PageSize { get; set; }
        [FromQuery(Name = "sortorder")]
        public string SortOrder { get; set; }
        [FromQuery(Name = "sortproperty")]
        public string SortProperty { get; set; }
        [FromQuery(Name = "filter")]
        public string FilterValue { get; set; }
        [FromQuery(Name = "filterkey")]
        public string FilterKey { get; set; }
    }
}
