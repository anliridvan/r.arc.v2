using NUnit.Framework;
using R.ARC.Common.Helper.Crypto;

namespace R.ARC.Core.Test
{
    public class CommonHelperTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void HashHelperTest()
        {
            string password = "admin";
            byte[] passwordHash, passwordSalt;
            HashHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            Assert.True(HashHelper.VerifyPasswordHash(password, passwordHash, passwordSalt));
        }

        //[Test]
        //public void Test2()
        //{
        //    Assert.Pass();
        //}
    }
}