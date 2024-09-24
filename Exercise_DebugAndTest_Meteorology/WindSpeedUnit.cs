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
    public class WindSpeedUnit
    {

        public enum Unit { None, MeterPerSecond, MilesPerHour };

        public static Unit GetUnit(string unitString)
        {
            Unit foundUnit = Unit.None;

            if (unitString.ToLower().Equals("mph"))
            {
                foundUnit = Unit.MilesPerHour;
            }
            if (unitString.ToLower().Equals("m/s"))
            {
                foundUnit = Unit.MeterPerSecond;
            }

            return foundUnit;
        }
    }
}
