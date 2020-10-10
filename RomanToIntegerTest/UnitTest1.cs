using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanToIntegerTest
{
    [TestClass]
    public class UnitTest1
    {
        public string S;
        [TestMethod]
        public void TestMethod1()
        {
            S = "MCMXCIV";
            Assert.AreEqual(1994, RomanToInteger.Solution.RomanToInt(S));
        }
    }
}
