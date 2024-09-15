using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_InheritanceGame_GameLogic
{
    // Abstract base class representing an item
    public abstract class Item : IPickup
    {
        // Property to hold the title of the item
        public string Title { get; private set; }

        // Constructor that initializes the Title property
        protected Item(string title)
        {
            Title = title;
        }

        // Implementation of IPickup method
        public void Pickup()
        {
            Console.WriteLine(Title + " has been picked up.");
        }
    }
}
