using System;
using Exercise_Generics3_OrderedPairGeneric;
using Exercise_Generics3_OrderedPairGeneric.Model;

namespace Exercise_Generics3_OrderedPairGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            // OrderedPair type string
            var fruit = new OrderedPair<string>("apple", "banana");
            Console.WriteLine("Order of strings");
            Console.WriteLine(fruit);
            fruit.ChangeOrder();
            Console.WriteLine("Order changed!");
            Console.WriteLine(fruit);

            // OrderedPair type int
            var numbers = new OrderedPair<int>(9, 11);
            Console.WriteLine(Environment.NewLine + "Order of integers");
            Console.WriteLine(numbers);
            numbers.ChangeOrder();
            Console.WriteLine("Order changed!");
            Console.WriteLine(numbers);

            // OrderedPair type City
            var aCity = new City("Nuuk", 40000);
            var bCity = new City("Thorshavn", 20000);
            var cities = new OrderedPair<City>(aCity, bCity);
            Console.WriteLine(Environment.NewLine + "Order of cities");
            Console.WriteLine(cities);
            cities.ChangeOrder();
            Console.WriteLine("Order changed!");
            Console.WriteLine(cities);

            Console.ReadLine();
        }
    }
}