using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IsPrimeNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, IsPrimeNumber.Solution.NumberPrime(3));
            Assert.AreEqual(true, IsPrimeNumber.Solution.NumberPrime(5));
            Assert.AreEqual(false, IsPrimeNumber.Solution.NumberPrime(6));
        }
    }
}
