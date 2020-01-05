using System;
using System.Collections.Generic;
using System.Text;

namespace R.ARC.Common.Contract
{
    public class LoginModel
    {
        /// <summary>
        ///     User Name
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        ///     Password (Min 5 characters)
        /// </summary>
        public string Password { get; set; }
    }
}
