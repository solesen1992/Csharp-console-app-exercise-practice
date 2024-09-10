using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_UnitTest_Grades
{
    /*
     * The GradeBook class manages a collection of grades and computes basic statistics 
     * (average, highest, and lowest grades) from them.
     * 
     * The ComputeStatistics method calculates the necessary stats, and the AddGrade method 
     * adds new grades to the list.
     * 
     * The FirstGrade method is unsafe because it doesn't check if there are any grades in 
     * the list before attempting to access the first element. 
     * This could lead to errors if the list is empty.
     */
    public class GradeBook
    {
        // Private field to store the list of grades (float values).
        private readonly List<float> grades;

        /* 
         * Constructor: Initializes the `grades` list.
         */
        public GradeBook()
        {
            // Instantiates a new empty list of float values to hold grades.
            this.grades = new List<float>();
        }

        /* 
         * Method to compute statistics such as the average, highest, and lowest grades.
         */
        public GradeStatistics ComputeStatistics()
        {
            // Create a new instance of the GradeStatistics class to store the results.
            GradeStatistics stats = new GradeStatistics();

            // Variable to accumulate the sum of all grades.
            float sum = 0;

            // Loop through each grade in the list of grades.
            foreach (float grade in grades)
            {
                // Update HighestGrade using the greater value between the current grade and the existing HighestGrade.
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);

                // Update LowestGrade using the smaller value between the current grade and the existing LowestGrade.
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);

                // Add the current grade to the sum.
                sum = sum + grade;
            }

            // Calculate the average grade by dividing the sum by the number of grades.
            stats.AverageGrade = sum / grades.Count;

            // Return the populated GradeStatistics object.
            return stats;
        }

        /* 
         * Method to add a new grade to the list.
         */
        public void AddGrade(float grade)
        {
            // Add the given grade to the grades list.
            grades.Add(grade);
        }

        /* 
         * Method that returns the first grade in the list. 
         * Note: This method is marked as "bad" because it doesn't check if the list is empty, 
         * which could lead to an exception (index out of range error).
         */
        public float FirstGrade()
        {
            // Return the first element in the grades list (index 0).
            return grades[0];
        }
    }
}
