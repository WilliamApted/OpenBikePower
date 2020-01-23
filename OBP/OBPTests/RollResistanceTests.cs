using Microsoft.VisualStudio.TestTools.UnitTesting;
using OBP;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBP.Tests
{
    [TestClass()]
    public class RollResistanceTests
    {
        [TestMethod()]
        public void ResistanceTest()
        {
            double result = RollResistance.Resistance(0.10f, 60, 0.005f);

            Assert.AreEqual(2.93, result, 0.05);
        }
    }
}