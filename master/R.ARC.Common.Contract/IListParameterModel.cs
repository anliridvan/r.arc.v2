namespace R.ARC.Common.Contract
{
    public interface IListParameterModel
    {
        int? PageIndex { get; set; }
        short? PageSize { get; set; }

        string SortOrder { get; set; }
        string SortProperty { get; set; }

        string FilterValue { get; set; }
        string FilterKey { get; set; }
    }
}
