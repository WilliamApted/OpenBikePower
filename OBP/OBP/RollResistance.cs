using System;
using System.Collections.Generic;
using System.Text;

namespace OBP
{
    public class RollResistance
    {
 

        /// <summary>
        /// Estimates the force due to rolling resistance. 
        /// </summary>
        /// <param name="slope">Slope of hill defined as a percentage. Positive when going up, negative when going down.</param>
        /// <param name="mass">Total weight of bike, rider and all other equipment.</param>
        /// <param name="resistanceCoefficient">The rolling resistance coefficient.</param>
        /// <param name="g">Acceleration due to gravity.  Default figure defined by ISO/IEC 80000 (9.80665)</param>
        /// <returns>The force </returns>
        public static double Resistance(float slope, float mass, float resistanceCoefficient, float g = 9.80665f) 
        {
            return g * Math.Cos(Math.Atan(slope)) * mass * resistanceCoefficient;
        }
    }
}
