﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void FirstTest()
        {
            Assert.AreEqual(6, 6); 
        }

        [TestMethod]
        public void Second()
        {
            Assert.AreEqual(8, 8);
        }

        [TestMethod]
        public void Third()
        {
            Assert.AreEqual(10, 10);
        }

        [TestMethod]
        public void Fourth()
        {
            Assert.AreEqual(10, 10);
        }
    }
}
