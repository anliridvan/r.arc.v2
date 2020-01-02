using System;

namespace R.ARC.Common.Contract
{
    public class TokenModel
    {
        public string Token { get; set; }
        public DateTimeOffset ExpiresAt { get; set; }
        public string Email { get; set; }
    }
}
