using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Generics1.Utilities
{
    public class Helper1
    {
        public static bool AreEqual(int val1, int val2)
        {
            return val1.Equals(val2);
        }

        public static bool AreEqual(decimal val1, decimal val2)
        {
            return val1.Equals(val2);
        }

        public static bool AreEqual(string val1, string val2)
        {
            return val1.Equals(val2);
        }

    }
}
