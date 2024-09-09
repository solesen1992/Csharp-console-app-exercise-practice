using System.Globalization;

/*
 * TryParse is used to avoid exception when trying to convert from one type to another.
 * This demo also works with enums which are used when only a finite number of values should be allowed. Makes the values explicit.
 * 
 * This demo shows how to parse a string into a int, decimal, enum benefits and how to parse a string to an enum type.
 */

/*
 * This C# code continuously takes input from the user, parses it to check if it's an integer, and then outputs the parsed 
 * integer or a blank line if the input is not a valid integer. The loop ends when the user enters "0".
 */

// Initialize the input variable to something other than "0" to start the loop
/**string input = "Start";

// Loop will continue as long as the input is not "0"
while (!input.Equals("0"))
{
    // Read user input from the console
    input = Console.ReadLine(); 

    // Declare a variable to hold the parsed integer (could change to decimal for decimals)
    int foundInteger; 

    // Try to parse the input as an integer. If successful, 'foundInteger' will hold the value
    bool wasInteger = Int32.TryParse(input, out foundInteger);
    //The sentence can also be: bool wasInteger = Int32.TryParse(input, out int foundInteger); - we can declare the variable on the inside too

    Console.WriteLine("Was integer? " + wasInteger);

    if (wasInteger)
    {
        // If parsing was successful, print the parsed number
        Console.WriteLine("Number = " + foundInteger);
    }
    else
    {
        // If parsing was unsuccessful (non-integer input), print an empty line
        Console.WriteLine();
    }
}*/


/*
 * Working with decimals
 * 
 * This C# code takes input from the user and attempts to parse it as a decimal number using specific number 
 * formatting styles (such as allowing decimal points) and a specific culture ("da-DK", Danish culture). 
 * The loop continues to accept inputs until the user enters "0".
 */

string input = "Start"; // Initial value to ensure the loop starts

// Loop continues as long as the input is not "0"
while (!input.Equals("0"))
{
    // Prompt the user to enter a number
    Console.WriteLine("Please enter a number (or 0 to exit):"); 

    // Re-declaration of 'input', which will overwrite the original input value
    input = Console.ReadLine(); // Read input from the console

    // Specify the number style, allowing decimal points in the input
    NumberStyles useStyle = NumberStyles.AllowDecimalPoint;

    // Set the culture to Danish ("da-DK"), which affects decimal formatting (comma as decimal separator)
    CultureInfo culture = CultureInfo.CreateSpecificCulture("da-DK");

    decimal foundDecimal; // Variable to store the parsed decimal value
    // Attempt to parse the input as a decimal using the specified style and culture
    bool wasDecimal = Decimal.TryParse(input, useStyle, culture, out foundDecimal);

    // Display whether the input was successfully parsed as a decimal
    Console.WriteLine("Was decimal? " + wasDecimal);

    // If the input was a valid decimal, print the parsed decimal value
    if (wasDecimal)
    {
        Console.WriteLine("Number = " + foundDecimal);
    }
}



