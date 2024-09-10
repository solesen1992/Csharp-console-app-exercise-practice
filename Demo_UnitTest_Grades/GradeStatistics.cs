using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_UnitTest_Grades
{

    /*
     * The GradeStatistics class is intended to store and compute basic statistics about a collection of grades, 
     * such as the average, highest, and lowest grades. It uses simple floating-point values to store these statistics. 
     * The constructor ensures that HighestGrade starts at 0 and LowestGrade starts at the maximum possible value, 
     * so they can be updated appropriately when new grades are provided in later operations.
     * 
     * Initializing HighestGrade to 0 ensures that any grade higher than 0 will be recorded as the highest grade 
     * when you start comparing the actual grades.
     * If HighestGrade were initialized to some arbitrary large value, say 100, then all grades below 100 would 
     * incorrectly be considered lower than the "highest" value, even if they are actually the highest grades in the set.
     * 
     * LowestGrade is initialized to float.MaxValue, which is the largest possible value that a float can store. 
     * This ensures that when the actual grades are compared, any grade will be smaller than float.MaxValue.
     * float.MaxValue represents the largest possible value for a floating-point number. So, when comparing actual grades, 
     * any real grade will be lower than float.MaxValue, and the code can properly update the LowestGrade to the lowest value seen.
     * If LowestGrade were initialized to 0, then no grade below 0 (which is invalid in most contexts) would be recorded 
     * as the lowest grade, even if valid grades are lower than the initially set value.
     */
    public class GradeStatistics
    {
        // Properties
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;

        public GradeStatistics() { 
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }
    }
}
