using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DelegatesAndSort_SortDelegate_Base
{
    static class DelegateBubleSort
    {
        // Delegate - notice parameters and return type
        public delegate bool CompareTwo(int first, int second);

        // BubleSort with Delegate parameter (code that governs the comparison of two int values)
        public static void BubbleSort(int[] items, CompareTwo compareHandler)
        {
            int i, j, temp;

            if (items != null)
            {

                for (i = items.Length - 1; i >= 0; i--)
                {
                    for (j = 1; j <= i; j++)
                    {
                        if (compareHandler(items[j - 1], items[j]))
                        {
                            temp = items[j - 1];
                            items[j - 1] = items[j];
                            items[j] = temp;
                        }
                    }
                }
            }// ends if
        }

        // Sort order - in ascending order
        public static bool GreaterThan(int first, int second)
        {
            bool isGreater = (first > second);
            return isGreater;
        }

        // Sort order - in ascending alphabetic order
        public static bool GreaterThanAlphabeticOrder(int first, int second)
        {
            // Convert integers to strings
            string FirstString = first.ToString();
            string SecondString = second.ToString();

            // Use CompareTo to compare strings alphabetically
            return FirstString.CompareTo(SecondString) > 0;
        }

        // Sort order - even values before odd values
        public static bool EvenBeforeOdd(int first, int second)
        {
            // Determine if the first number is even
            bool firstIsEven = (first % 2 == 0);

            // Determine if the second number is even
            bool secondIsEven = (second % 2 == 0);

            // If the first number is even and the second number is odd, the first should come before the second
            if (firstIsEven && !secondIsEven)
            {
                return false; // Return false to indicate that first should come before second
            }

            // If the first number is odd and the second number is even, the second should come before the first
            if (!firstIsEven && secondIsEven)
            {
                return true; // Return true to indicate that first should come after second
            }

            // If both numbers are either even or odd, their order should not change
            return false; // Return false as there is no need to change the order within the same group (both even or both odd)
        }

        // Sort order - even values in ascending order, then odd values in ascending order
        public static bool EvenThenOddAscending(int first, int second)
        {
            // Check if the first number is even
            bool firstIsEven = (first % 2 == 0);

            // Check if the second number is even
            bool secondIsEven = (second % 2 == 0);

            // If one number is even and the other is odd
            if (firstIsEven != secondIsEven)
            {
                // Return true if the first number is even (should come before the odd number)
                // Return false if the first number is odd (should come after the even number)
                return !firstIsEven; // first is even, second is odd
            }

            // If both numbers are either even or odd, compare them to maintain the original order
            return first > second; // Both are even or both are odd, maintain original order
        }
    }
}
