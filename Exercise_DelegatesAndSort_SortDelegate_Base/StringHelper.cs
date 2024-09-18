using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DelegatesAndSort_SortDelegate_Base
{
    internal class StringHelper
    {

        /* CODE BEFORE:
        
        static readonly char delimiter = '-';

        public static string GetDisplayString(IEnumerable<int> nums) {
            StringBuilder sb = new StringBuilder();

            foreach (int sco in nums) {
                sb.Append(delimiter.ToString() + sco);
            }

            return sb.ToString();
        }*/

        /*
         * CODE AFTER
         */
        static readonly char delimiter = '-';

        public static string GetDisplayString(IEnumerable<int> nums)
        {
            StringBuilder sb = new StringBuilder();

            bool isFirst = true; // Flag to track the first item

            foreach (int sco in nums)
            {
                if (!isFirst)
                {
                    sb.Append(delimiter); // Append delimiter before subsequent numbers
                }
                sb.Append(sco); // Append the number
                isFirst = false; // Set flag to false after the first item
            }

            return sb.ToString();
        }
    }
}
