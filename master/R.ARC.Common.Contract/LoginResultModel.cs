using System;
using System.Collections.Generic;
using System.Text;

namespace R.ARC.Common.Contract
{
    public class LoginResultModel
    {
        public string AuthToken { get; set; }
        public UserModel CurrentUser { get; set; }
    }
}
