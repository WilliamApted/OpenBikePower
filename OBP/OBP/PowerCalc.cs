using System;
using System.Collections.Generic;
using System.Text;

namespace OBP
{
    public class PowerCalc
    {
        /// <summary>
        /// Does the final calculation to find the power (In watts)
        /// </summary>
        /// <param name="gravityForce">Force due to gravity.</param>
        /// <param name="rollingForce">Force due to rolling resistance.</param>
        /// <param name="dragForce">Force due to areodynamic drag.</param>
        /// <param name="velocity">Current velocity.</param>
        /// <param name="powerLoss">Power loss (as a percentage, 5% -> 0.05)</param>
        /// <returns>Power in watts.</returns>
        private double GetPower(double gravityForce, double rollingForce, double dragForce, double velocity, double powerLoss) 
        {
            return ((gravityForce + rollingForce + dragForce) * velocity) / (1 - powerLoss);
        }

        /// <summary>
        /// Calacuates the cycling power with the given inputs.
        /// </summary>
        /// <param name="velocity">Current velocity.</param>
        /// <param name="mass">Total mass of bike and rider setup.</param>
        /// <param name="slope">Current slope as a percentage. Positive when going uphill and negative when going downhill.</param>
        /// <param name="windSpeed">Current windspeed, positive when a headwind and negative when tailwind.</param>
        /// <param name="airDensity">Air density.</param>
        /// <param name="rollResistanceCoefficient">The rolling resistance coefficient.</param>
        /// <param name="dragType">The drag type. Can use either pre-defined or custom.</param>
        /// <param name="powerLoss">Power loss (as a percentage, 5% -> 0.05)</param>
        /// <returns>Power in watts.</returns>
        public double Calculate(float velocity, float mass, float slope, float windSpeed, float airDensity, float rollResistanceCoefficient, iDragType dragType , float powerLoss = 0) 
        {
            return GetPower(Gravity.GravitationalForce(slope, mass), RollResistance.Resistance(slope, mass, rollResistanceCoefficient), Drag.Calculate(airDensity, velocity, windSpeed, dragType), velocity, powerLoss);
        }                          
    }
}
