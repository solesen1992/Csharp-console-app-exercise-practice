using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DebugAndTest_Meteorology
{
    /*
     * CREDIT: This part of the code is made by a teacher at UCN
     * 
     * Constructor: Initializes the windchill factor object with temperature scale, wind speed unit, temperature, and wind speed.
     * 
     * Chill Factor Calculation: Converts temperature and wind speed to Fahrenheit and miles per hour respectively (if needed), 
     * applies the windchill formula, and stores the result.
     * 
     * Helper Methods: These methods convert between Celsius/Fahrenheit and meters per second/miles per hour.
     */
    public class WindChillFactor
    {
        /* 
         * Constructor to initialize WindChillFactor with temperature scale, wind speed unit, temperature in degrees, and wind speed.
         */
        public WindChillFactor(TemperatureScale.Scale inScale, WindSpeedUnit.Unit inUnit, double inDegrees, double inWindSpeed)
        {
            // Assigns the provided temperature scale to the TempScale property.
            TempScale = inScale;
            // Assigns the provided wind speed unit to the WindUnit property.
            WindUnit = inUnit;
            // Assigns the provided temperature value to the TempDegrees property.
            TempDegrees = inDegrees;
            // Assigns the provided wind speed value to the WindSpeed property.
            WindSpeed = inWindSpeed;
        }

        // Public property for the temperature scale (Celsius or Fahrenheit), with get and set methods.
        public TemperatureScale.Scale TempScale { set; get; }

        // Public property for the wind speed unit (MeterPerSecond or MilesPerHour), with get and set methods.
        public WindSpeedUnit.Unit WindUnit { set; get; }

        // Public property for the temperature value, with get and set methods.
        public double TempDegrees { set; get; }

        // Public property for the wind speed value, with get and set methods.
        public double WindSpeed { set; get; }

        // Private field to store the calculated windchill temperature.
        private double calculatedChillFactorTemp = 0;

        // Public property to get the calculated windchill temperature.
        public double ChillFactorTemperature
        {
            get
            {
                // Returns the calculated windchill temperature.
                return calculatedChillFactorTemp;
            }
        }

        /*
         * Uses the windchill formula from https://www.weather.gov/media/epz/wxcalc/windChill.pdf.
         * Temperature (T) must be in Fahrenheit and wind speed (Wind_sfc) in Mph for this formula.
         */
        public void CalulateChillFactorTemperature()
        {
            // Initializes T with the current temperature value (TempDegrees).
            double T = TempDegrees;

            // If the temperature is in Celsius, convert it to Fahrenheit using the helper method.
            if (TempScale == TemperatureScale.Scale.Celsius)
            {
                T = ConvertCelsiusToFahrenheit(TempDegrees);
            }

            // Initializes Wind_sfc with the current wind speed value (WindSpeed).
            double Wind_sfc = WindSpeed;

            // If the wind speed is in meters per second, convert it to miles per hour using the helper method.
            if (WindUnit == WindSpeedUnit.Unit.MeterPerSecond)
            {
                Wind_sfc = ConverMeterPerSecondToMilesPerHour(WindSpeed);
            }

            /* 
             * Calculate the windchill temperature using the windchill formula.
             */
            double powerConstant = 0.16; // Constant used in the windchill formula.
            double part1 = 35.74; // Constant part of the formula.
            double part2 = 0.6215 * T; // Second part, which involves temperature (T).
            double part3 = Math.Pow(Wind_sfc, powerConstant) * 35.75; // Third part, which involves wind speed (Wind_sfc).
            double part4 = Math.Pow(Wind_sfc, powerConstant) * T * 0.4275; // Fourth part, which involves wind speed and temperature.
            double chillDegreeResult = part1 + part2 + part4 - part3; // The final windchill result combining all parts.

            // If the original temperature was in Celsius, convert the result back to Celsius.
            if (TempScale == TemperatureScale.Scale.Celsius)
            {
                chillDegreeResult = ConvertFahrenheitToCelsius(chillDegreeResult);
            }

            // Store the rounded windchill result in calculatedChillFactorTemp.
            calculatedChillFactorTemp = Math.Round(chillDegreeResult, 1);
        }

        /* 
         * Converts a Celsius temperature to Fahrenheit.
         */
        public double ConvertCelsiusToFahrenheit(double degreesInC)
        {
            return (degreesInC * 1.8 + 32); // Formula to convert Celsius to Fahrenheit.
        }

        /* 
         * Converts a Fahrenheit temperature to Celsius.
         */
        public double ConvertFahrenheitToCelsius(double degreesInF)
        {
            return (degreesInF - 32) / 1.8; // Formula to convert Fahrenheit to Celsius.
        }

        /* 
         * Converts wind speed from miles per hour to meters per second.
         */
        public double ConverMilesPerHourToMeterPerSecond(double windInMilesPerHour)
        {
            return windInMilesPerHour * 0.44704; // Conversion factor to change miles per hour to meters per second.
        }

        /* 
         * Converts wind speed from meters per second to miles per hour.
         */
        public double ConverMeterPerSecondToMilesPerHour(double windInMeterPerSecond)
        {
            return windInMeterPerSecond / 0.44704; // Conversion factor to change meters per second to miles per hour.
        }
    }
}
