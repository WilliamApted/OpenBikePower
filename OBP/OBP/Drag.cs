using System;
using System.Collections.Generic;
using System.Text;

namespace OBP
{
    public class Drag
    {
        /// <summary>
        /// Calculates the aerodynamic drag.
        /// </summary>
        /// <returns>Drag force.</returns>
        public static double Calculate(float airDensity, float velocity, float windSpeed, iDragType drag) 
        {
            return 0.5 * drag.GetDragCoefficientArea() * airDensity * Math.Pow((velocity + windSpeed), 2);       
        }



    }
}
