using Microsoft.VisualStudio.TestTools.UnitTesting;
using Subtraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Subtraction.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        private readonly int a = 30;
        private readonly int b = 20;
        private readonly double c = 20.3;
        private readonly double d = 5.2;

        [TestMethod()]
        public void DifferenceTest()
        {
            Assert.AreEqual(10, Subtraction.Difference(a, b));
        }

        [TestMethod()]
        public void DifferenceDoubleTest()
        {
            Assert.AreEqual(15.100000000000001, Subtraction.Difference(c, d));
        }
    }
}