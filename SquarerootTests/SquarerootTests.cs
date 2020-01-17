using Microsoft.VisualStudio.TestTools.UnitTesting;
using Squareroot;
using System;
using System.Collections.Generic;
using System.Text;

namespace Squareroot.Tests
{
    [TestClass()]
    public class SquarerootTests
    {
        private readonly int a = 25;
        private readonly double b = 10.8;

        [TestMethod()]
        public void SquarerootingTest()
        {
            Assert.AreEqual(5, Squareroot.Squarerooting(a));
        }

        [TestMethod()]
        public void SquarerootTest1()
        {
            Assert.AreEqual(3.29, Squareroot.Squarerooting(b));
        }
    }
}