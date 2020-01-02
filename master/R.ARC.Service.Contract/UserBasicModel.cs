using System;
using System.Collections.Generic;
using System.Text;

namespace R.ARC.Common.Contract
{
    public class UserBasicModel : BaseBasicModel
    {
        public string Email { get; set; }

        public string Role { get; set; }
    }
}
