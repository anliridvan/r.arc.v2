using System;

namespace R.ARC.Common.Contract
{
    public class BaseModel : BaseBasicModel
    {
        public string CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
