using Exercise_DebugAndTest_Meteorology;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DebugAndTest_Meteorology_Tests
{
    /*
    * CREDIT: This part of the code is made by a teacher at UCN.
    * I just coded along and made changes to the code so the tests could run without fails.
    */
    public class TestMeteorology : IDisposable
    {
        private WindChillFactor? _wChillFactor;

        /*
         * This method tests the conversion of a temperature from Celsius to Fahrenheit using the 
         * ConvertCelsiusToFahrenheit method of the WindChillFactor class.
         * 
         * Purpose: This test verifies that the ConvertCelsiusToFahrenheit method correctly converts a temperature of 5°C to Fahrenheit.
         * Expected Outcome: The expected Fahrenheit value for 5°C is 41°F, and this test checks that the method produces the correct result.
         */
        [Fact] // Fact attribute marks a test method
        public void TestConvertCelciusToFahrenheitNormal()
        {
            // Arrange
            // Create a WindChillFactor object with TempDegrees == 5
            _wChillFactor = new WindChillFactor(TemperatureScale.Scale.None, WindSpeedUnit.Unit.None, 5, 0);
            double fahrenheitExpected = 41.00;

            // Act
            double fahrenheitResult = _wChillFactor.ConvertCelsiusToFahrenheit(_wChillFactor.TempDegrees);

            // Assert
            Assert.Equal(fahrenheitExpected, fahrenheitResult);
        }

        /*
         * This test is designed to verify that the ConvertFahrenheitToCelsius method in the WindChillFactor class 
         * correctly converts a temperature from Fahrenheit to Celsius.
         * 
         * Purpose: The test verifies that the ConvertFahrenheitToCelsius method correctly converts 41°F to 5°C.
         * Expected Outcome: The method should correctly convert the input of 41°F to 5°C, and the test checks 
         * that the returned value matches the expected result.
         */
        [Fact]
        public void TestConvertFahrenheitToCelciusNormalData()
        {
            // Arrange
            // Create a WindChillFactor object with TempDegrees == 5
            WindChillFactor _wChillFactor = new WindChillFactor(TemperatureScale.Scale.None, WindSpeedUnit.Unit.None, 41, 0);
            double celsiusExpected = 5.00;

            // Act
            double celciusResult = _wChillFactor.ConvertFahrenheitToCelsius(_wChillFactor.TempDegrees);

            // Assert
            Assert.Equal(celsiusExpected, celciusResult);
        }


        /*
         * This test is designed to verify the functionality of the ConverMilesPerHourToMeterPerSecond method 
         * in the WindChillFactor class using data-driven testing.
         * 
         * Purpose: This test verifies that the ConverMilesPerHourToMeterPerSecond method accurately converts 
         * a specified speed in miles per hour to meters per second using data-driven testing.
         * 
         * Expected Outcome: For an input of 20.13 mph, the method should return a result of approximately 9.001 m/s. 
         * The test checks that this conversion is accurate within a specified tolerance.
         * 
         * Reusability: The test can easily be extended by adding more [InlineData] attributes with different input 
         * and expected values, allowing multiple scenarios to be tested with minimal code duplication.
         */

        // Test run for more (here two) sets of data
        [Theory] // Marks data-driven tests
        [InlineData(20.13, 9.001)] // One of the ways to input data
        public void TestConvertMilesPerHourToMeterPerSecond(double inMilesPerHour, double expectedMeterPerSecond)
        {
            // Arrange
            _wChillFactor = new WindChillFactor(TemperatureScale.Scale.None, WindSpeedUnit.Unit.None, 0, inMilesPerHour);

            // Act
            double MeterPerSecondResult = _wChillFactor.ConverMilesPerHourToMeterPerSecond(_wChillFactor.WindSpeed);

            // Assert
            Assert.Equal(expectedMeterPerSecond, MeterPerSecondResult, 2); // Tolerance
        }

        /*
         * This test is designed to verify the functionality of the ConverMeterPerSecondToMilesPerHour method 
         * in the WindChillFactor class using data-driven testing.
         * 
         * Purpose: This test verifies that the ConverMeterPerSecondToMilesPerHour method accurately converts 
         * specified speeds from meters per second to miles per hour using data-driven testing.
         * 
         * Expected Outcome:
         * For an input of 9.00 m/s, the method should return approximately 20.13 mph.
         * For an input of 0 m/s, the method should return 0 mph.
         * 
         * Reusability: The test can easily be extended by adding more [InlineData] attributes with different 
         * input and expected values, allowing for multiple scenarios to be tested with minimal code duplication.
         */
        [Theory]
        [InlineData(9.00, 20.13)]
        [InlineData(0, 0)]
        public void TestConvertMeterPerSecondToMilesPerHourToMeterPerSecond(double inMeterPerSecond, double expectedMilesPerHour)
        {
            // Arrange
            WindChillFactor wChillFactor = new WindChillFactor(TemperatureScale.Scale.None, WindSpeedUnit.Unit.MeterPerSecond, 0, inMeterPerSecond);

            // Act
            double MeterPerSecondResult = wChillFactor.ConverMeterPerSecondToMilesPerHour(wChillFactor.WindSpeed);

            // Assert
            Assert.Equal(expectedMilesPerHour, MeterPerSecondResult, 2);
        }

        /*
         * This test is designed to verify the functionality of the CalulateChillFactorTemperature method 
         * in the WindChillFactor class, specifically for calculating the wind chill factor temperature based 
         * on inputs in Celsius and meters per second.
         * 
         * Purpose: This test verifies that the CalulateChillFactorTemperature method accurately calculates the wind 
         * chill factor temperature based on Celsius input and wind speed in meters per second using data-driven testing.
         * 
         * Expected Outcomes:
         * For an input of 5 degrees Celsius and a wind speed of 9 m/s, the method should return approximately -0.1 degrees Celsius.
         * For an input of 0 degrees Celsius and a wind speed of 2 m/s, the method should return approximately -2.5 degrees Celsius.
         * 
         * Reusability: The test can easily be extended by adding more [InlineData] attributes with different input 
         * and expected values, allowing for multiple scenarios to be tested with minimal code duplication.
         */
        [Theory]
        [InlineData(5, 9, -0.1)]
        [InlineData(0, 2, -2.5)]
        public void TestCalculateChillFactorTemperature(double inCelcius, double inMeterPerSecond, double expectedCelcius)
        {
            // Arrange
            _wChillFactor = new WindChillFactor(TemperatureScale.Scale.Celsius, WindSpeedUnit.Unit.MeterPerSecond, inCelcius, inMeterPerSecond);

            // Act
            _wChillFactor.CalulateChillFactorTemperature();
            double TemperatureResult = _wChillFactor.ChillFactorTemperature;

            // Assert
            Assert.Equal(expectedCelcius, TemperatureResult, 2);
        }
        

        // Implemented from interface
        public void Dispose()
        {
            _wChillFactor = null;
        }
    }
}
