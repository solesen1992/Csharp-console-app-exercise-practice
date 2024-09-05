string aName = "Hans";
Console.WriteLine("Person name (1) : " + aName);
StringMethod(aName);
Console.WriteLine("Person name (3) : " + aName);
Console.ReadLine();
static void StringMethod(string aName)
{
    aName += " Hansen";
    Console.WriteLine("Person name (2) : " + aName);
}
