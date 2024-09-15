using Exercise_AbstractVirtual.Model;
using System;
using System.Collections.Generic;

namespace Exercise_AbstractVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of animals
            List<Animal> animals = new List<Animal>
            {
                new Dog("Fresh bulldog"),
                new Cat("Siamese")
            };

            // Loop through each animal and display details
            foreach (Animal animal in animals) {
                Console.WriteLine($"{animal.GetType().Name} - {animal.breed}");
                Console.WriteLine($"Trick: {animal.Trick()}");
                Console.WriteLine($"Feed: {animal.Feed()}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}