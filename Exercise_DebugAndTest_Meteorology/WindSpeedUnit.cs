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
     * The WindSpeedUnit class is used to interpret wind speed units from strings.
     * The method GetUnit takes a string (e.g., "mph" or "m/s") and returns the appropriate unit from the Unit enum.
     * If no valid unit is found, it defaults to Unit.None.
     */
    public class WindSpeedUnit
    {
        /* 
         * Defines an enumeration named Unit with three possible values: None, MeterPerSecond, and MilesPerHour.
         * This enum helps in categorizing the type of wind speed unit.
        */
        public enum Unit { None, MeterPerSecond, MilesPerHour };

        /* 
         * Declares a static method GetUnit that accepts a string (unitString) and returns a Unit enum value.
         * This method will determine the wind speed unit based on the string input.
        */
        public static Unit GetUnit(string unitString)
        {
            /* 
             * Initializes a variable named foundUnit of type Unit and assigns it a default value of None.
             * This is used as the default value if no matching unit is found.
            */
            Unit foundUnit = Unit.None;

            /* 
             * Checks if the input string matches "mph" (case-insensitive).
             * If it does, it assigns the Unit.MilesPerHour to foundUnit.
            */
            if (unitString.ToLower().Equals("mph"))
            {
                foundUnit = Unit.MilesPerHour;
            }

            /* 
             * Checks if the input string matches "m/s" (case-insensitive).
             * If it does, it assigns the Unit.MeterPerSecond to foundUnit.
             */
            if (unitString.ToLower().Equals("m/s"))
            {
                foundUnit = Unit.MeterPerSecond;
            }

            // Returns the foundUnit, which will be either MilesPerHour, MeterPerSecond, or None, depending on the input.
            return foundUnit;
        }
    }
}
