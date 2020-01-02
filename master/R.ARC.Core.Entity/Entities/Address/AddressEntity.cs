using R.ARC.Common.Helper.Attributes;
using R.ARC.Common.Helper.Enums;
using R.ARC.Common.Helper.Extensions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace R.ARC.Core.Entity
{
    public class AddressEntity : BaseEntity
    {
        public AddressType AddressType { get; set; }

        public string Address { get; set; }

        public string County { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string Country { get; set; }
        
        public int ZipCode { get; set; }

        public string LevelCodeStr { get; set; }

        [IgnoreMapping]
        [NotMapped]
        public IEnumerable<string> LevelCode
        {
            get => LevelCodeStr?.ConvertList();
            set => LevelCodeStr = value?.ConvertString();
        }

        public string LevelStr { get; set; }

        [IgnoreMapping]
        [NotMapped]
        public IEnumerable<string> Level
        {
            get => LevelStr?.ConvertList();
            set => LevelStr = value?.ConvertString();
        }

    }
}
