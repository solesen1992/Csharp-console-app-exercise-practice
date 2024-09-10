using System;
using Xunit;
using Demo_UnitTest_Grades;

namespace Demo_UnitTest_Grades.Tests
{
    /*
     * The GradesTests class is a unit test class that implements the IDisposable interface.
     * 
     * In unit testing, it's important to ensure that objects and resources used during one test do not 
     * affect subsequent tests. Implementing IDisposable ensures that the Dispose() method is called after 
     * each test method finishes, allowing the class to release resources and perform any necessary cleanup. 
     * This is especially important when dealing with unmanaged resources, but here it's just to reset 
     * the _book object between tests.
     * 
     * In summary, the GradesTests class contains various tests for the GradeBook class, and implementing 
     * IDisposable ensures proper cleanup of the test environment after each test is run.
     */
    public class GradesTests : IDisposable
    {
        // Private field to store an instance of GradeBook
        GradeBook _book;

        /* 
         * Constructor: Initializes the GradeBook object before each test.
         */
        public GradesTests() { 
            _book = new GradeBook();
        }

        /* 
         * Test to check if the highest grade is computed correctly.
         * 
         * This test (ComputeHighestGrade) checks if the ComputeStatistics() method 
         * correctly computes the highest grade from a set of grades.
         */
        [Fact]
        public void ComputeHighestGrade()
        {
            // Arrange: Define a highest grade and add grades to the GradeBook.
            int highestGrade = 90; // The test will fail if this is incorrect, e.g., 45.
            _book.AddGrade(10);
            _book.AddGrade(highestGrade);
            _book.AddGrade(89.5f);

            // Act: Compute the statistics of the GradeBook.
            GradeStatistics foundResult = _book.ComputeStatistics();

            // Assert: Verify if the highest grade matches the expected value.
            Assert.Equal(highestGrade, foundResult.HighestGrade);
        }

        /*
         * Test to verify the average grade calculation with floating-point precision.
         * 
         * This test (ComputeHighestGrade2) ensures that the ComputeStatistics() method calculates 
         * the average grade correctly with precision up to 4 decimal places.
         */
        [Fact]
        public void ComputeHighestGrade2()
        {
            // Arrange: Define the expected average grade and add grades to the GradeBook.
            float expectedAverage = 90.1667f;
            _book.AddGrade(91);
            _book.AddGrade(89.5f);
            _book.AddGrade(90);

            // Act: Compute the statistics of the GradeBook.
            GradeStatistics foundResult = _book.ComputeStatistics();

            // Assert: Verify if the average grade matches the expected value within 4 decimal places.
            Assert.Equal(expectedAverage, foundResult.AverageGrade, 4);
        }

        /* 
         * If we need to test on more sets of data
         * Test using multiple sets of data to calculate the average grade.
         * 
         * This test (ComputesAverageGradeMore) uses the [Theory] attribute to test 
         * multiple sets of grades and their corresponding expected average values.
         */
        [Theory]
        [InlineData(5, 5, 5, 5)] // All grades are the same, so the average should be 5.
        [InlineData(0, 0, 0, 0)] // If the last 0 becomes a 1 then it will fail, because 1 isn't the average of three zeros.
        [InlineData(91, 89.5f, 90, 90.1667f)] // Expected average of these three grades.
        [InlineData(0, 89.5f, 90, 59.8333f)] // Expected average when one grade is 0.
        public void ComputesAverageGradeMore(float grade1, float grade2, float grade3, float expectedValue)
        {
            // Arrange: Add the three grades to the GradeBook.
            float expectedAverage = expectedValue;
            _book.AddGrade(grade1);
            _book.AddGrade(grade2);
            _book.AddGrade(grade3);

            // Act: Compute the statistics of the GradeBook.
            GradeStatistics foundResult = _book.ComputeStatistics();

            // Assert: Verify if the average grade matches the expected value within 4 decimal places.
            Assert.Equal(expectedAverage, foundResult.AverageGrade, 4);
        }

        /*
         * Test to verify the behavior when there are no grades in the GradeBook.
         * 
         * This test (ComputesAverageGradeEmpty) ensures that the ComputeStatistics() method 
         * handles the case when no grades are present and returns NaN for the average.
         */
        [Fact]
        public void ComputesAverageGradeEmpty()
        {
            // Arrange: No grades are added.
            // float expectedAverage = float.NaN;

            // Act: Compute the statistics of the GradeBook.
            GradeStatistics foundResult = _book.ComputeStatistics();

            // Assert: Check if the computed average is NaN (not a number) since no grades exist.
            Assert.True(float.IsNaN(foundResult.AverageGrade));
        }

        /*
         * Test to check if the FirstGrade method throws the correct exception when no grades exist.
         * 
         * This test (ComputesFirstGradeMissing) ensures that the FirstGrade() method throws an 
         * ArgumentOutOfRangeException when no grades exist in the GradeBook.
         */
        [Fact]
        public void ComputesFirstGradeMissing()
        {
            // Arrange: No grades are added.
            // No data

            // Act & Assert: Verify that calling `FirstGrade` throws an `ArgumentOutOfRangeException` when there are no grades.
            Assert.Throws<ArgumentOutOfRangeException>( // If it was a NullReferenceException it will fail
                () => { // No input and expects no output
                    _book.FirstGrade(); // Accessing the first grade when no grades are present should throw an exception.
                }
            );
        }

        /* 
         * Dispose method is called after each test to release resources.
         * 
         * Implements the Dispose() method to clean up resources after each test by setting the GradeBook object to null. 
         * This is part of the IDisposable pattern used for cleanup after the tests have run.
         */
        public void Dispose()
        {
            // Set the GradeBook instance to null to release the memory.
            _book = null;
        }
    }
}