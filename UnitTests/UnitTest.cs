using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void FirstTest()
        {
            Assert.AreEqual(5, 5);
        }

        [TestMethod]
        public void Second()
        {
            Assert.AreEqual(7, 7);
        }
    }
}
