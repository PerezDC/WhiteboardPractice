using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanToInteger;

namespace RomanToIntegerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = "MCMXCIV";
            Assert.AreEqual(1994, RomanToInteger.Solution.RomanToInt(s));
        }
    }
}
