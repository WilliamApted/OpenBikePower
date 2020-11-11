# OpenBikePower
![](https://github.com/WilliamApted/OpenBikePower/workflows/.NET%20Testing/badge.svg)

## Summary
This library is intended for providing cycling power estimates based off a variety of input parameters. 

Dedicated bike power meters are typically quite expensive and inaccessible to most. Hence the possibilities for this library could include creating mobile applications to provide realtime power estimates using data from the gps and accelerometers or allowing users to retrospectively calculate their power along a tracked route. 

## Platform support
This library is a .NET Standard library, and hence can be used with .net framework, .net core and other .net projects. This means there is full cross platform support.

## Examples

***Calculating power***

This is an example calculating power with a 70kg bike/rider setup, going at 20km/h, up a 5% slope, with a 1.8km/h headwind. 

```c#
using OBP;
using OBP.DragTypes;
using System;

namespace DemoPowerApp
{
    class Program
    {
        static void Main(string[] args)
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
            double wattage = powerCalculator.GetPower(velocity, mass, slope, windSpeed, 
                             airDensity, RollResistanceCoefficients.SlickAsphalt, new DragHoods());


            Console.WriteLine("Power in watts: {0}", wattage);

            Console.ReadLine();
        }
    }
}
```
The output here is ~210 watts. 

## Documentation
*Documentation/wiki links will be added soon.*


