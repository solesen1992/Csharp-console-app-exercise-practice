using System;
using System.Collections.Generic;
using System.Linq;

IEnumerable<string> names = new List<string> { "Tom", "Hans", "Harry", "Marianne" };

// Create a method that returns all names of length 4 or more
IEnumerable<string> GetLong4Names(IEnumerable<string> testColl) { 
    return testColl.Where(name => name.Length >= 4);
}

Console.WriteLine("Names that's equal to or have more than 4 letters");

// Call the method and print the result
var LongNames = GetLong4Names(names);
foreach (var name in LongNames)
{
    Console.WriteLine(name);
}

// Create a method that returns all names containing an ‘a’. The names must be sorted by length and be in upper case.
IEnumerable<string> GetNamesWithA(IEnumerable<string> testColl) {
    return testColl
        // Filter names containing 'a'
        .Where(name => name.Contains('a', StringComparison.OrdinalIgnoreCase))
        // Sort by length
        .OrderBy(name => name.Length)
        // Convert to upper case
        .Select(name => name.ToUpper());
}

Console.WriteLine(Environment.NewLine + "Names with a:");

// Call the method and print the result
var namesWithA = GetNamesWithA(names);
foreach (var name in namesWithA) {
        Console.WriteLine(name); 
}
