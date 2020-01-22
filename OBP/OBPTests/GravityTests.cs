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
            Gravity gravityCalculator = new Gravity(10, 60);

            double result = gravityCalculator.GravitationalForce();

            Assert.AreEqual(result, 585, 1);
        }
    }
}