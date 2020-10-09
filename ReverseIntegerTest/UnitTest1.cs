using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseInteger;

namespace ReverseIntegerTest
{
    [TestClass]
    public class UnitTest1
    {
        public int x;

        [TestMethod]
        public void TestMethod1()
        {
            x = 123;
            Assert.AreEqual(321, ReverseInteger.Solution.Reverse(x));
        }

        [TestMethod]
        public void TestMethod2()
        {
            x = -123;
            Assert.AreEqual(-321, ReverseInteger.Solution.Reverse(x));
        }

        [TestMethod]
        public void TestMethod3()
        {
            x = 120;
            Assert.AreEqual(21, ReverseInteger.Solution.Reverse(x));
        }

        [TestMethod]
        public void TestMethod4()
        {
            x = 0;
            Assert.AreEqual(0, ReverseInteger.Solution.Reverse(x));
        }
    }
}
