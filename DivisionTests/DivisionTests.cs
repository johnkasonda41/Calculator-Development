using Microsoft.VisualStudio.TestTools.UnitTesting;
using Division;
using System;
using System.Collections.Generic;
using System.Text;

namespace Division.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        private readonly int a = 40;
        private readonly int b = 10;
        private readonly double c = 20.3;
        private readonly double d = 10.2;
        private readonly int e = 0;   

        [TestMethod()]
        public void DivideTest()
        {
            Assert.AreEqual(4, Division.Divide(a, b));
        }

        [TestMethod()]
        public void DivideDoubleTest()
        {
            Assert.AreEqual(1.9901960784313728, (Division.Divide(c, d)));
        }
        [TestMethod()]
        public void DivideIntDivideZeroTest()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Division.Divide(a, e));
        }
    }
}