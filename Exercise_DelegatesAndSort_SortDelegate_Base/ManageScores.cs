using Exercise_DelegatesAndSort_SortDelegate_Base;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Xml;

int[] scores = new int[] { 4, 2, 7, 4, 9, 13, 2, 1, 4, 0, 5 };

// Display scores as entered in collection
Console.WriteLine("Unsorted scores");
Console.WriteLine(StringHelper.GetDisplayString(scores));

// Display scores sorted by some order
// Use BubleSort method - member og DelegateBubleSort class

// Sort scores in ascending order using BubbleSort with the GreaterThan comparison
DelegateBubleSort.BubbleSort(scores, DelegateBubleSort.GreaterThan);

Console.WriteLine(Environment.NewLine + "Sorted scores");
Console.WriteLine(StringHelper.GetDisplayString(scores));

// Display scores sorted alphabeticly
DelegateBubleSort.BubbleSort(scores, DelegateBubleSort.GreaterThanAlphabeticOrder);

Console.WriteLine(Environment.NewLine + "Sorted scores after alfabeth");
Console.WriteLine(StringHelper.GetDisplayString(scores));

// Sort scores with even values before odd values
DelegateBubleSort.BubbleSort(scores, DelegateBubleSort.EvenBeforeOdd);

Console.WriteLine(Environment.NewLine + "Even before odd sorted scores");
Console.WriteLine(StringHelper.GetDisplayString(scores));

// Sort scores with even values in ascending order, then odd values in ascending order
DelegateBubleSort.BubbleSort(scores, DelegateBubleSort.EvenThenOddAscending);

Console.WriteLine(Environment.NewLine + "Even then odd sorted scores");
Console.WriteLine(StringHelper.GetDisplayString(scores));

// Sort scores using lambda
DelegateBubleSort.BubbleSort(scores, (first, second) => first < second);

Console.WriteLine(Environment.NewLine + "Sorting scores using Lambda");
Console.WriteLine(StringHelper.GetDisplayString(scores));

// Sorted OddEvenLesser using standard Sort() and Lambda expression

// Sort odd numbers in descending order before even numbers in descending order
Array.Sort(scores, (first, second) => {
    // Check if first and second are odd or even
    bool firstIsOdd = first % 2 != 0;
    bool secondIsOdd = second % 2 != 0;

    if (firstIsOdd && secondIsOdd) 
    {
        return second.CompareTo(first);
    }
    if (!firstIsOdd && !secondIsOdd)
    {
        return second.CompareTo(first);
    }

    return firstIsOdd ? -1 : 1;
});

Console.WriteLine(Environment.NewLine + "Sorted OddEvenLesser using standard Sort() and Lambda expression");
Console.WriteLine(StringHelper.GetDisplayString(scores));

Console.Read();
