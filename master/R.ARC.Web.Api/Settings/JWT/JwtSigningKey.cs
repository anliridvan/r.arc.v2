using Microsoft.IdentityModel.Tokens;

namespace R.ARC.Web.Api.Settings.JWT
{
    public class JwtSigningKey : SymmetricSecurityKey
    {
        public JwtSigningKey(byte[] key) : base(key)
        {
        }
    }
}