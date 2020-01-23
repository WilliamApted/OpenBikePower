using System;
using System.Collections.Generic;
using System.Text;

namespace OBP
{
    class PowerCalc
    {
        private double GetPower(float gravityForce, float rollingForce, float dragForce, float velocity, float powerLoss) 
        {
            return ((gravityForce + rollingForce + dragForce) * velocity) / (1 - powerLoss);
        }

        public double Calculate(float velocity, float mass, float slope, float windSpeed, float airDensity, float rollResistanceCoefficient) 
        {
            return 0;
            //return GetPower(Gravity.GravitationalForce(slope, mass), RollResistance.Resistance(slope, mass, rollResistanceCoefficient), Drag.d);
        }





    }
}
