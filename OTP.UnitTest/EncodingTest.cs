using Microsoft.VisualStudio.TestTools.UnitTesting;
using OTP.Lib;

namespace OTP.UnitTest
{
    [TestClass]
    public class EncodingTest
    {
        [TestMethod]
        public void TestBase32Decoding()
        {
            
            string encodedText = "MyUserID";
            byte[] expected = encodedText.ToByteArray();
            byte[] actual = { 102, 41, 34, 69, 3 };
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}