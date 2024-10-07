using Demo_GenericsApp;
/*
* CREDIT: Code along session on generics
* Code is made by Tim Corey: https://www.youtube.com/watch?v=Ld5D6B2Ntjg
* 
* Notes:
* Benefits of generics: Can make code easier to understand and read.
*/

//TypeChecker(1);
//TypeChecker("Tim");
//TypeChecker(new PersonRecord("Tim", "Corey"));

/*BetterList<int> betterNumbers = new();
betterNumbers.AddToList(5);

BetterList<PersonRecord> people = new();
people.AddToList(new("Tim", "Corey"));*/

MathOperations<int> intMath = new();
Console.WriteLine(intMath.add(1, 4));

MathOperations<double> doubleMath = new();
Console.WriteLine(doubleMath.add(1.5, 4.3));

// This method is using generics. You can see that on <T>. The T is just like the 'i' (index) in a 'for loop' for example.
// Can pass in any value you want, and it knows the type automatically.
// It's valuable if you're logging something. 
void TypeChecker<T>(T value) { 
    Console.WriteLine("Type: " + typeof(T)); // It knows, based on what we passed in, what the type of the value is.
    Console.WriteLine("Value: " + value);
}

// The alternative to the above method is two methods - one for each datatype.
/*void TypeCheckerForString(string value) { 

}

void TypeCheckerForInt(int value) { 

}*/


record PersonRecord(string FirstName, string LastName);
