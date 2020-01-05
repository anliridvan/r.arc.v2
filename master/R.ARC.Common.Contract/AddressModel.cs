using R.ARC.Common.Helper.Enums;
using System.Collections.Generic;

namespace R.ARC.Common.Contract
{
    public class AddressModel : BaseModel
    {
        public AddressType AddressType { get; set; }
        public string Address { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public int ZipCode { get; set; }
        public List<string> Level { get; set; }
        public List<string> LevelCode { get; set; }

    }
}
