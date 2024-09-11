using Demo_MethodSpecial_SpecialSignature.Math;
using System;

/*
 * The code demonstrates various ways of using overloaded methods, nullable types, and out parameters. 
 * It shows how to handle different types of method parameters and how to work with method overloads 
 * and default parameters. The results of the method calls are printed to the console, providing 
 * insight into how different scenarios affect the output.
 */

MyClass myObject = new MyClass();

myObject.Value1 = 3;
myObject.Value2 = 9;


/* 
 * Call the DoMath() method, which will print the sum of Value1 and Value2 (3 + 9) to the console
 */
myObject.DoMath();


/* Call the overloaded DoMath(int inValue1) method with 4 as the parameter
 * This calls AddTwoIntegers(4), which adds 4 and the default value of 10 (from the default parameter)
 */
int sum2 = myObject.DoMath(4);
Console.WriteLine("sum2 = " + sum2); // Outputs: "sum2 = 14"


/* 
 * Call the overloaded DoMath(int inValue1, int inValue2, int inMaxTotal) method
 * This calculates the sum of 9 and 9 (18), and since 18 is less than 15, it returns 15 (the max total) 
 */
int sum3 = myObject.DoMath(9, 9, 15);
Console.WriteLine("sum3 = " + sum3); // Outputs: "sum3 = 15"


/* Call the DoMath2(int inValue1, int inValue2, int belowThreshold) method
 * This calculates the sum of 9 and 9 (18) and compares it to 20. Since 18 is less than 20, it returns null
*/
int? sum5 = myObject.DoMath2(9, 9, 20);
if (sum5 != null)
{
    // Since sum5 is null, this block is not executed
    int newInt = (int)sum5 * 5; // needs to cast it to an int because it's null. Cast the nullable integer to int
    Console.WriteLine("sum5 = " + newInt);
}
else {
    // Since sum5 is null, this block is executed
    Console.WriteLine("sum5 is below threshold");
}


/* Call the DoMath2 method again with a threshold of 20
 * Since 18 is still less than 20, it returns null 
*/
int? sum6 = myObject.DoMath2(9, 9, 20); // works with the last number being 15 but not with 20.
// Use the ternary operator to check if sum6 is not null
// If sum6 is not null, multiply it by 5, otherwise set the result to -1
int endsum = (sum6 != null) ? ((int)sum6) * 5 : -1; // If it's true the thing after ? happens. If it's false the thing after : happens
Console.WriteLine("sum6 = " + endsum); // Outputs: "sum6 = -1" because sum6 is null


/*
 * Call the DoMath(int inValue1, int inValue2, out int sum4) method
 * This calculates the sum of 9 and 9 (18) and assigns it to the out parameter sum4
 * 
 * Call method with outgoing parameter
 */
int sum4;
myObject.DoMath(9, 9, out sum4);
Console.WriteLine("sum4 = " + sum4); // Outputs: "sum4 = 18"
