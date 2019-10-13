using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoverTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest()
        {
            Assert.AreEqual(new Calculator().Add(1,2), 3);
        }
    }
}
