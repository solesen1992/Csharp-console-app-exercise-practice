using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_InheritanceGame_GameLogic
{
    // Class representing the player's inventory
    public class Inventory
    {
        // List to hold items in the inventory
        public List<Item> Items { get; private set; }

        // Constructor initializes the list
        public Inventory()
        {
            Items = new List<Item>();
        }

        // Add items to list
        public void Add(Item item)
        {
            Items.Add(item);
        }

        // Public method that returns a list of items of a specific type T
        // The type T is constrained to be or inherit from the 'Item' class
        public List<T> GetItems<T>() where T : Item
        {
            // Filters the 'Items' collection for elements of type T using LINQ's 'OfType' method,
            // which selects only the elements of the specified type
            // Converts the filtered result to a List<T> and returns it
            return Items.OfType<T>().ToList();
        }
    }
}
