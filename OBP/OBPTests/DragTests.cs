using Microsoft.VisualStudio.TestTools.UnitTesting;
using OBP;
using OBPTests;
using OBPTests.MockObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBP.Tests
{
    [TestClass()]
    public class DragTests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            double result = Drag.Calculate(1.22f, 5.56f, 1f, new MockDragType(1));
            Assert.AreEqual(26.25, result, 0.1);
        }
    }
}