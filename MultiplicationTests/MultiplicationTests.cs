using Microsoft.VisualStudio.TestTools.UnitTesting;
using Multiplication;
using System;
using System.Collections.Generic;
using System.Text;

namespace Multiplication.Tests
{
    [TestClass()]
    public class MultiplicationTests
    {
        private readonly int a = 60;
        private readonly int b = 15;
        private readonly double c = 60.5;
        private readonly double d = 10.2;
        private readonly double[] arrayA = { 1.01, 2.04, 3.06, 4.07, 5.09, 6.78, 7.21, 8.78, 9.90, 10.12 };
        private readonly int[] arrayB = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.AreEqual(900, Multiplication.Multiply(a, b));
        }

        [TestMethod()]
        public void MultiplyDoubleTest()
        {
            Assert.AreEqual(617.0999999999999, Multiplication.Multiply(c, d));
        }

        [TestMethod()]
        public void MultiplyDoubleArrayTest()
        {
            Assert.AreEqual(5616429.875755116, Multiplication.Multiply(arrayA));
        }

        [TestMethod()]
        public void MultiplyIntArrayTest()
        {
            Assert.AreEqual(3628800, Multiplication.Multiply(arrayB));
        }
    }
}

