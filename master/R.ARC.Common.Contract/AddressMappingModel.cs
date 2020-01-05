using R.ARC.Common.Helper.Enums;
using System.Collections.Generic;

namespace R.ARC.Common.Contract
{
    public class AddressMappingModel
    {
        public string CountryCode { get; set; }

        public int Depth { get; set; }

        public int? RegionSequence { get; set; }

        public int? CitySequence { get; set; }

        public int? CountySequence { get; set; }

    }
}
