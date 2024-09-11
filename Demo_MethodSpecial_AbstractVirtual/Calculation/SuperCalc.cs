using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MethodSpecial_AbstractVirtual.Calculation
{
    /*
     * The SuperCalc class is an abstract base class designed for mathematical calculations. 
     * 
     * It defines:
     * - Two properties (Value1 and Value2) for storing integer values.
     * - An abstract method (ConcatenateNumbers) that must be implemented by derived classes to return 
     * a concatenated string representation of two integers.
     * - A virtual method (SumNumbers) with a default implementation to sum two integers and return 
     * the result as a double. Derived classes can override this method if they need a different behavior.
     * 
     * This class sets up a foundation for other classes that will inherit from SuperCalc, providing 
     * a base for both required and optional functionalities.
     */
    internal abstract class SuperCalc
    {
        // Auto-implemented properties to store integer values
        public int Value1 { get; set; }
        public int Value2 { get; set; }

        /* 
         * Abstract method - must be implemented by any derived class
         * Takes two integers as input and returns a concatenated string representation of them 
         */
        public abstract string ConcatenateNumbers(int inValue1, int inValue2);

        /* 
         * Virtual method - can be overridden by derived classes
         * Calculates the sum of two integers and returns the result as a double 
         */
        public virtual double SumNumbers(int inValue1, int inValue2)
        {
            return (inValue1 + inValue2);
        }
    }
}
