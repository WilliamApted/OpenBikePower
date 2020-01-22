using System;
using System.Collections.Generic;
using System.Text;

namespace OBP
{
    public class Gravity
    {
        //Acceleration due to gravity.
        public float g { get; set; }

        //Steepness of hill defined as a percentage. Positive when going up, negative when going down.
        public float slope { get; set; }

        //Total weight of bike, rider and all other equipment.
        public float mass { get; set; }

        public Gravity()
        {
        }

        /// <summary>
        /// Sets up class for calculating force due to gravity.
        /// </summary>
        /// <param name="slope">Steepness of hill as a percentage. Positive when going up, negative when down.</param>
        /// <param name="mass">Total weight of bike, rider and all other equipment.</param>
        /// <param name="g">Force of gravity. Default figure defined by ISO/IEC 80000 (9.80665)</param>
        public Gravity(float slope, float mass, float g = 9.80665f)
        {
            this.g = g;
            this.slope = slope;
            this.mass = mass;
        }

        public double GravitationalForce() 
        {
            return (g * Math.Sin(Math.Atan(slope)) * mass);
        }
    }
}
