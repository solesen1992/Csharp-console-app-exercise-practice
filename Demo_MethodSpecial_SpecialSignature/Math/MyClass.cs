using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MethodSpecial_SpecialSignature.Math
{
    /*
     * This class contains methods for performing various mathematical operations
     * 
     * This class demonstrates:
     * Method Overloading: Multiple methods with the same name but different parameters.
     * Default Parameters: Method parameters can have default values.
     * Nullable Types: Methods can return null as a possible value.
     * Out Parameters: Allows methods to return multiple values.
     */
    public class MyClass
    {
        // Auto-implemented properties to store integer values
        public int Value1 { get; set; }
        public int Value2 { get; set; }

        /* 
         * Method that prints the result of adding Value1 and Value2 to the console
         */
        public void DoMath()
        {
            Console.WriteLine(AddTwoIntegers(Value1, Value2));
        }

        /*
         * Method overloading - version of DoMath that takes one integer parameter
         */
        public int DoMath(int inValue1)
        {
            // Calls AddTwoIntegers with the provided single integer, and implicitly uses a default value for the second parameter
            return AddTwoIntegers(inValue1);
        }

        /*
         * Method overloading - version of DoMath that takes three integer parameters
         */
        public int DoMath(int inValue1, int inValue2, int inMaxTotal)
        {
            // Initialize 'total' with the maximum allowed value
            int total = inMaxTotal;
            // Compute the sum of the first two integers
            int sum = AddTwoIntegers(inValue1, inValue2);
            // If the sum is less than the maximum allowed, update 'total' with the sum
            if (sum < total)
            {
                total = sum;
            }
            // Return the final value of 'total'
            return total;
        }

        /*
         * Method that returns a nullable integer (int?) - meaning it can return either an integer or null
         * ? after the return type / variable, allows it to be null
         */
        public int? DoMath2(int inValue1, int inValue2, int belowThreshold)
        {
            // Initialize 'total' as null
            int? total = null;
            // Compute the sum of the first two integers
            int sum = AddTwoIntegers(inValue1, inValue2);
            // If the sum is greater than the threshold, set 'total' to the sum
            if (sum > belowThreshold)
            {
                total = sum;
            }
            // Return the nullable integer value (could be sum or null)
            return total;
        }

        /*
         * Method using 'out' parameter to return the result by reference
         * Out parameter instead of just an normal int parameter
         */ 
        public void DoMath(int inValue1, int inValue2, out int sum4)
        {
            // Calculate the sum of the two integers and assign it to the out parameter 'sum4'
            sum4 = AddTwoIntegers(inValue1, inValue2);
        }


        /*
         * Private method to add two integers with a default parameter value for value2
         * int value2 = 10 is a default parameter. So if we don't define it, it will just be 10.
         */
        private int AddTwoIntegers(int value1, int value2 = 10)
        {
            // Calculate the sum of value1 and value2
            int sum = value1 + value2;
            // Return the result of the addition
            return sum;
        }
    }
}
