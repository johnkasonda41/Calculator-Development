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
    private readonly int a = 6;
    private readonly double b = 2.5;

        [TestMethod()]
        public void CubedTest()
        {
            Assert.AreEqual(216, Cube.Cubed(a));
        }

        [TestMethod()]
        public void CubedDoubleTest()
        {
            Assert.AreEqual(15.625, Cube.Cubed(b));
        }
    }
}