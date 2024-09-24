using Exercise_DebugAndTest_Meteorology;
using Exercise_DebugAndTest_Meteorology_Tests;

namespace Exercise_DebugAndTest_Meteorology_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        // ConvertCelsiusToFahrenheit
        [Fact]
        public void ConvertCelsiusToFahrenheit_Given5Celsius_Returns41Fahrenheit()
        {
            // Arrange
            double celsius = 5;
            double expected = 41;

            // Act
            double actual = WindChillFactor.ConvertCelsiusToFahrenheit(celsius);

            // Assert
            Assert.Equal(expected, actual);
        }

        
        // ConvertFahrenheitToCelsius
        // ConverMilesPerHourToMeterPerSecond
        // ConverMeterPerSecondToMilesPerHour
        // CalculateChillFactorTemperature
    }
}