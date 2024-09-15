using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Generics1.Utilities
{
    public class Helper2
    {
        // Generic method to compare two values of any type
        public static bool AreEqual<T>(T val1, T val2)
        {
            return val1.Equals(val2);
        }
    }
}
