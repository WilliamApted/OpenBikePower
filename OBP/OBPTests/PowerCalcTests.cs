using Microsoft.VisualStudio.TestTools.UnitTesting;
using OBP;
using OBP.DragTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBP.Tests
{
    [TestClass()]
    public class PowerCalcTests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            //Speed in m/s
            float velocity = 5.556f;

            //Mass of bike, rider and kit in KG
            float mass = 70;

            //Slope as a percentage. Positive when going up, negative when going down.
            float slope = 0.05f;

            //Wind speed in m/s. (positive when a headwind and negative when tailwind)
            float windSpeed = 0.5f;

            //Air Density in kg/m³ - Functionality to calculate this being added soon!
            float airDensity = 0.00069051f;

            //Create power calculator.
            PowerCalc powerCalculator = new PowerCalc();

            //Calculate power with parameters.
            double wattage = powerCalculator.Calculate(velocity, mass, slope, windSpeed,
                             airDensity, RollResistanceCoefficients.SlickAsphalt, new DragHoods());

            Assert.AreEqual(210, wattage, 0.5);


        }
    }
}