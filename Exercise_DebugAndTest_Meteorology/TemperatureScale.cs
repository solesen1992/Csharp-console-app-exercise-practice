using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DebugAndTest_Meteorology
{
    /*
     * CREDIT: This part of the code is made by a teacher at UCN
     */

    public class TemperatureScale
    {
        public enum Scale { None, Celsius, Fahrenheit };

        public static Scale GetScale(string scaleString)
        {
            Scale foundScale = Scale.None;

            if (scaleString.ToLower().Equals("fahrenheit"))
            {
                foundScale = Scale.Fahrenheit;
            }
            if (scaleString.ToLower().Equals("celsius"))
            {
                foundScale = Scale.Celsius;
            }

            return foundScale;
        }
    }
}
