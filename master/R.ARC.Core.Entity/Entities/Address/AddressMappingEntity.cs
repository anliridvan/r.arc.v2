using R.ARC.Common.Helper.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace R.ARC.Core.Entity
{
    public class AddressMappingEntity
    {
        public string CountryCode { get; set; }

        public int Depth { get; set; }

        public int?  RegionSequence { get; set; }

        public int?  CitySequence  { get; set; }

        public int? CountySequence { get; set; }
    }
}
