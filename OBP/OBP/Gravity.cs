using System;
using System.Collections.Generic;
using System.Text;

namespace OBP
{
    public class Gravity
    {
        /// <summary>
        /// Calculates force due to gravity.
        /// </summary>
        /// <param name="slope">Steepness of hill as a percentage. Positive when going up, negative when down.</param>
        /// <param name="mass">Total weight of bike, rider and all other equipment.</param>
        /// <param name="g">Force of gravity. Default figure defined by ISO/IEC 80000 (9.80665)</param>
        /// <returns></returns>
        public static double GravitationalForce(float slope, float mass, float g = 9.80665f) 
        {
            return (g * Math.Sin(Math.Atan(slope)) * mass);
        }
    }
}
