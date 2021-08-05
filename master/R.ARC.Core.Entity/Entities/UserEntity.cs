﻿
using System.Collections.Generic;

namespace R.ARC.Core.Entity
{
    public class UserEntity : BaseExtendedEntity<UserExt>
    {
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

    }
}
