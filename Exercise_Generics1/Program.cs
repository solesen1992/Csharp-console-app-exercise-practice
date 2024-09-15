using Exercise_Generics1.Utilities;

/*
 * Without generics
 */

Console.WriteLine("Comparison");
// Integers
int int1 = 5, int2 = 7;
bool intEqual = Helper1.AreEqual(int1, int2);
Console.WriteLine($"Integers {int1} and {int2} are equal: {intEqual}");

// Decimals
decimal dec1 = 5m, dec2 = 5.00m;
bool decEqual = Helper1.AreEqual(dec1, dec2);
Console.WriteLine($"Decimals {dec1} and {dec2} are equal: {decEqual}");

// Strings
string str1 = "Bad", str2 = "Good";
bool strEqual = Helper1.AreEqual(str1, str2);
Console.WriteLine($"Strings {str1} and  {str2} are equal: {strEqual}");

/*
 * With generics
 */
Console.WriteLine("Comparison - Generics");
// Integers
int int3 = 5, int4 = 7;
bool intEqual2 = Helper2.AreEqual(int3, int4);
Console.WriteLine($"Integers {int3} and {int4} are equal: {intEqual2}");

// Decimals
decimal dec3 = 5m, dec4 = 5.00m;
bool decEqual2 = Helper2.AreEqual(dec3, dec4);
Console.WriteLine($"Decimals {dec3} and {dec4} are equal: {decEqual2}");

// Strings
string str3 = "Bad", str4 = "Good";
bool strEqual2 = Helper2.AreEqual(str3, str4);
Console.WriteLine($"Strings {str3} and  {str4} are equal: {strEqual2}");
