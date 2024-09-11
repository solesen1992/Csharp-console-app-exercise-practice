using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MethodSpecial_AbstractVirtual.Calculation
{
    /*
     * The SubCalc class is a concrete implementation of the SuperCalc abstract class. 
     * 
     * It provides specific implementations for the ConcatenateNumbers and SumNumbers methods:
     * - ConcatenateNumbers: Concatenates two integers as strings and returns the result.
     * - SumNumbers: Calculates the sum of two integers and scales it by a factor of 1.25 before returning the result.
     * 
     * This class demonstrates how to extend an abstract base class and customize its behavior to suit specific needs.
     */
    internal class SubCalc : SuperCalc
    {
        /* 
         * Override the abstract method from SuperCalc to provide specific implementation
         * Concatenates the two integers as strings and returns the concatenated result 
        */
        public override string ConcatenateNumbers(int inValue1, int inValue2)
        {
            // Convert the first integer to a string and concatenate it with the string representation of the second integer
            return (inValue1.ToString() + inValue2);
        }

        /* 
         * Override the virtual method from SuperCalc to provide a different implementation
         * Computes the sum of the two integers and multiplies the result by 1.25 
        */
        public override double SumNumbers(int inValue1, int inValue2)
        {
            // Calculate the sum of the two integers and then multiply by 1.25
            return ((inValue1 + inValue2) * 1.25);
        }
    }
}
