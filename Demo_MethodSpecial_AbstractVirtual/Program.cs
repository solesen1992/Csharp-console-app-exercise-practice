using Demo_MethodSpecial_AbstractVirtual.Calculation;

/*
 * The code creates an instance of the SubCalc class and uses it to perform two operations:
 * 
 * - SumNumbers: Computes the sum of two integers and scales the result by 1.25.
 * - ConcatenateNumbers: Concatenates two integers as strings.
 * 
 * The results of these operations are then printed to the console.
 */

// Declare and initialize an integer variable
int val1 = 5;
int val2 = 20;

// Create an instance of the SubCalc class
SubCalc calc1 = new SubCalc();

// Call the overridden SumNumbers method from SubCalc
// This method computes the sum of val1 and val2, then multiplies the result by 1.25
double sum = calc1.SumNumbers(val1, val2);

// Call the overridden ConcatenateNumbers method from SubCalc
// This method concatenates val1 (converted to a string) with val2 (converted to a string)
string concat = calc1.ConcatenateNumbers(val1, val2);

// Print the result of SumNumbers to the console
// Displays the computed sum, scaled by 1.25
Console.WriteLine("Sum = " + sum);

// Print the result of ConcatenateNumbers to the console
// Displays the concatenated string representation of val1 and val2
Console.WriteLine("Concat = " + concat);