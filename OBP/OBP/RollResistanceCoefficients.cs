using System;
using System.Collections.Generic;
using System.Text;

namespace OBP
{
    /// <summary>
    /// A range of preset rolling resistant coefficient values.
    /// </summary>
    public class RollResistanceCoefficients
    {
        //Numbers based off University of Pretoria and the University of Reims Champagne Ardenne
                
        public static readonly float SlickConcrete = 0.0020f;
        public static readonly float SlickAsphalt = 0.0050f;
        public static readonly float SlickGravel = 0.0060f;
        public static readonly float SlickGrass = 0.0070f;
        public static readonly float SlickOffRoad = 0.0200f;
        public static readonly float SlickSand = 0.0300f;

        public static readonly float TreadConcrete = 0.0025f;
        public static readonly float TreadAsphalt = 0.0064f;
        public static readonly float TreadGravel = 0.0075f;
        public static readonly float TreadGrass = 0.0090f;
        public static readonly float TreadOffRoad = 0.0254f;
        public static readonly float TreadSand = 0.0379f;
    }
}
