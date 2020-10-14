using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IsPalindromeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, IsPalindrome.Class1.IsPalindrome("Racecar"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(false, IsPalindrome.Class1.IsPalindrome("palindrome"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(false, IsPalindrome.Class1.IsPalindrome("Gustavo"));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(true, IsPalindrome.Class1.IsPalindrome("R ac E/Car"));
        }
    }
}
