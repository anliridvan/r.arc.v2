using System;
using System.Collections.Generic;
using System.Text;

namespace R.ARC.Common.Contract
{
    public class UserModel: BaseModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

    }
}
