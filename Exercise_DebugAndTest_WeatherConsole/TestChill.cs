using Exercise_DebugAndTest_Meteorology;
using System;

/*
 * CREDIT: This part of the code is made by a teacher at UCN.
 * I just coded along.
 */


// Input values (temperature scale, wind speed unit, degrees as integer, wind speed as integer)
//TemperatureScale.Scale inTempScale = TemperatureScale.Scale.Celcius;
//int inDegree = 5;
//WindSpeedUnit.Unit inWindUnit = WindSpeedUnit.Unit.MeterPerSecond;
//int inWindSpeed = 9;
TemperatureScale.Scale inTempScale = TemperatureScale.Scale.Fahrenheit;
int inDegree = 41;
WindSpeedUnit.Unit inWindUnit = WindSpeedUnit.Unit.MeterPerSecond;
int inWindSpeed = 9;

// Create WindChillFactor object using the input values
// Then calculate the resulting temperature
WindChillFactor wcF = new WindChillFactor(inTempScale, inWindUnit, inDegree, inWindSpeed);
wcF.CalulateChillFactorTemperature();

// Print input values and resulting temperature
Console.WriteLine("Input:");
Console.WriteLine($"Temperature {wcF.TempDegrees} {wcF.TempScale}");
Console.WriteLine($"Wind speed {wcF.WindSpeed} {wcF.WindUnit}");
Console.WriteLine("Result:");
Console.WriteLine($"Wind chill temperature: {wcF.ChillFactorTemperature} {wcF.TempScale}");

Console.ReadKey();