using System;
using System.Collections.Generic;
using System.Text;

namespace OBP
{
    class Drag
    {
        /// <summary>
        /// Calculates the aerodynamic drag using the provided drag coefficient and frontal area.
        /// </summary>
        /// <returns>Drag force.</returns>
        public static double DragCustom(float airDensity, float velocity, float windSpeed, float frontalArea, float dragCoefficient) 
        {
            return 0.5 * dragCoefficient * frontalArea * airDensity * Math.Pow((velocity + windSpeed), 2);       
        }

        /// <summary>
        /// Drag estimate for riding with hands on top of handle bars.
        /// </summary>
        /// <returns>Drag force.</returns>
        public static double DragTops(float airDensity, float velocity, float windSpeed) 
        {
            return 0.5 * 0.408 * airDensity * Math.Pow((velocity + windSpeed), 2);
        }

        /// <summary>
        /// Drag estimate for riding with hands on the hoods. 
        /// </summary>
        /// <returns>Drag force.</returns>
        public static double DragHoods(float airDensity, float velocity, float windSpeed)
        {
            return 0.5 * 0.324 * airDensity * Math.Pow((velocity + windSpeed), 2);
        }

        /// <summary>
        /// Drag estimate for riding with hands on the drops.
        /// </summary>
        /// <returns>Drag force.</returns>
        public static double DragDrops(float airDensity, float velocity, float windSpeed) 
        {
            return 0.5 * 0.307 * airDensity * Math.Pow((velocity + windSpeed), 2);
        }

        /// <summary>
        /// Drag estimate for riding with hands on straight aerobars, typically on triathlon bikes.
        /// </summary>
        /// <returns>Drag force.</returns>
        public static double DragAerobars(float airDensity, float velocity, float windSpeed)
        {
            return 0.5 * 0.2914 * airDensity * Math.Pow((velocity + windSpeed), 2);
        }

    }
}
