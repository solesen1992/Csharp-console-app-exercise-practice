using Exercise_InterfacesAndLists.Investment;
using System.Collections;
using static Exercise_InterfacesAndLists.Investment.Boat;
using static Exercise_InterfacesAndLists.Investment.House;

/*
 * Version 1
 */

// Instantiate House and Boat objects

// Boat
Boat boat1 = new Boat(30, 5000, BoatCondition.Good, "A luxury yacht", 2024);
Boat boat2 = new Boat(5, 2000, BoatCondition.Awful, "A little boatie", 1984);
Boat boat3 = new Boat(30, 5000, BoatCondition.Bad, "A family boat", 2000);
Boat boat4 = new Boat(30, 5000, BoatCondition.Perfect, "A luxury yacht", 2022);

// House
House house1 = new House("123 Main St", 150, 2000, HouseCondition.Good, "A beautiful family home");
House house2 = new House("Vesterbro", 170, 1000, HouseCondition.Medium, "In a busy area");
House house3 = new House("Aalborg", 50, 500, HouseCondition.Awful, "Slump area but lovely house");
House house4 = new House("157 Maccaroon Street", 250, 5000, HouseCondition.Good, "A beautiful and big mansion with a place for horses");
House house5 = new House("Neverland", 12000000, 1000, HouseCondition.Bad, "Michael Jackson's Neverland Ranch"); // Supposed to give overflow


// Painting
Painting painting1 = new Painting("Rome, From Mount Aventine", "JMW Turner", 1835, "Perfect", 260000000);
Painting painting2 = new Painting("Starry Night", "Vincent van Gogh", 1889, "Good", 100000000);


// Add objects to an ArrayList
ArrayList InvestItem = new ArrayList() { boat1, boat2, boat3, boat4, house1, house2, house3, house4, painting1, painting2, house5 };

// Text in the start of the console
Console.WriteLine("The following items are on the list:");

// Loop through object and run either Boat or House methods
// Use is operator and Type Casting
foreach (object investItem in InvestItem) {
    if (investItem is House house)
    {
        Console.WriteLine(house.InvestSummary());
        Console.Write(Environment.NewLine);
    }
    else if (investItem is Boat boat)
    {
        Console.WriteLine(boat.InvestSummary());
        Console.Write(Environment.NewLine);
    }
    else {
        Console.WriteLine("Item is not a boat or a house");
        Console.Write(Environment.NewLine);
    }
}


/* 
 * Version 2
 * 
 * Implementing interface and use a generic list (System.Collections.Generic.List<T>) instead of an ArrayList.
 */

// Add objects to a List<IInvestment>
List<IInvestment> investItems = new List<IInvestment> { boat1, boat2, boat3, boat4, house1, house2, house3, house4, painting1, painting2, house5 };

// Text at the start of the console
Console.WriteLine("The following items are on the list:");

// Loop through the List and call methods
foreach (var investItem in investItems)
{
    Console.WriteLine(investItem.InvestSummary());
    Console.Write(Environment.NewLine);  // Insert newline after each summary
}

Console.ReadLine();