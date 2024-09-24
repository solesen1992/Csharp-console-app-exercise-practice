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
     * TemperatureScale Class: This class defines the possible temperature scales (Celsius, Fahrenheit, None) using an enum.
     * 
     * GetScale Method: This method accepts a string and matches it with "fahrenheit" or "celsius" (case-insensitive) 
     * to return the corresponding enum value. If the input doesn't match either, it returns Scale.None.
     */

    public class TemperatureScale
    {
        /* 
         * Defines an enumeration named Scale with three possible values: None, Celsius, and Fahrenheit.
         * This enum helps in categorizing the type of temperature scale.
        */
        public enum Scale { None, Celsius, Fahrenheit };

        /* 
         * Declares a static method GetScale that accepts a string (scaleString) and returns a Scale enum value.
         * This method will determine the temperature scale based on the input string.
        */
        public static Scale GetScale(string scaleString)
        {
            /* 
             * Initializes a variable named foundScale of type Scale and assigns it a default value of None.
             * This is used as the default value if no matching scale is found.
            */
            Scale foundScale = Scale.None;

            /*  
             *  Checks if the input string matches "fahrenheit" (case-insensitive).
             *  If it does, it assigns the Scale.Fahrenheit to foundScale.
            */
            if (scaleString.ToLower().Equals("fahrenheit"))
            {
                foundScale = Scale.Fahrenheit;
            }

            /* 
             * Checks if the input string matches "celsius" (case-insensitive).
             * If it does, it assigns the Scale.Celsius to foundScale.
            */
            if (scaleString.ToLower().Equals("celsius"))
            {
                foundScale = Scale.Celsius;
            }

            /* 
             * Returns the foundScale, which will be either Fahrenheit, Celsius, or None, depending on the input.
             */
            return foundScale;
        }
    }
}
