using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OTP.UnitTest
{
    [TestClass]
    public class TotpTest
    {
        [TestMethod]
        public void TestHotp()
        {
            string secret = "HJJZZ4QRPSJIAPAN";
            string totp = OTP.Lib.OTP.GetHotp(secret, 8773256821647312117);
            Assert.AreEqual("879617", totp);
        }

        [TestMethod]
        public void TestHotp_ZeroPadding()
        {
            string secret = "HJJZZ4QRPSJIAPAN";
            string totp = OTP.Lib.OTP.GetHotp(secret, 8773256821647312147);
            Assert.AreEqual("071501", totp);
        }

        [TestMethod]
        public void GivenPasswordForUserIsWrong()
        {
            string secret = "MyUserID";
            string totp = OTP.Lib.OTP.GetHotp(secret, 47516241); 
            Assert.AreNotEqual("095700", totp); 
        }

        [TestMethod]
        public void GivenPasswordForUserIsCorrect()
        {
            string secret = "MyUserID";
            string totp = OTP.Lib.OTP.GetHotp(secret, 47516241); 
            Assert.AreEqual("095711", totp); 
        }
    }
}