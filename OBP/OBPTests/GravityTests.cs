using Microsoft.VisualStudio.TestTools.UnitTesting;
using OBP;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBP.Tests
{
    [TestClass()]
    public class GravityTests
    {
        [TestMethod()]
        public void GravitationalForceTest()
        {
            double result = Gravity.GravitationalForce(10, 60);
            Assert.AreEqual(585, result, 1);
        }
    }
}