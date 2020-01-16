using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cube;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cube.Tests
{
    [TestClass()]
    public class CubeTests
    {
        private readonly int a = 5;
        private readonly double b = 10.8;

        [TestMethod()]
        public void CubedTest()
        {
            Assert.AreEqual(125, Cube.Cubed(a));
        }

        [TestMethod()]
        public void CubedDoubleTest()
        {
            Assert.AreEqual(1259.7120000000002, Cube.Cubed(b));
        }
    }
}