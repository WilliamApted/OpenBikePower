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
        //A selection of preset rolling resistances. These are based off numbers from various studies including one by the University of Pretoria.

        public static readonly float SlickConcrete = 0.0020f;
        public static readonly float SlickTarmac = 0.0050f;
        public static readonly float SlickGravel = 0.0060f;
        public static readonly float SlickGrass = 0.0070f;
        public static readonly float SlickOffRoad = 0.0200f;
        public static readonly float SlickSand = 0.0300f;
        public static readonly float TreadConcrete = 0.0025f;
        public static readonly float TreadTarmac = 0.0064f;
        public static readonly float TreadGravel = 0.0075f;
        public static readonly float TreadGrass = 0.0090f;
        public static readonly float TreadOffRoad = 0.0254f;
        public static readonly float TreadSand = 0.0379f;
    }
}
