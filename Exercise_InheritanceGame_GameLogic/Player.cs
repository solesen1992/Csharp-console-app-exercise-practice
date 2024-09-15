using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_InheritanceGame_GameLogic
{
    // Class representing a player
    public class Player : IPlayer, IDamagable, IHealable
    {
        // Property to indicate if the player is alive
        public bool IsAlive { get; set; }

        // Property to hold the player's hitpoints
        public decimal Hitpoints { get; set; }

        // Reference to the player's inventory
        public Inventory Inventory { get; set; }

        // Constructor initializes hitpoints, creates a new Inventory, and sets IsAlive to true
        public Player(decimal hitpoints)
        {
            Hitpoints = hitpoints;
            Inventory = new Inventory();
            IsAlive = true;
        }

        // Implementation of IPlayer methods
        public void Die()
        {
            IsAlive = false;
            Console.WriteLine("Player has died");
        }

        public void Respawn()
        {
            IsAlive = true;
            Hitpoints = 100;
            Console.WriteLine("Player has respawned.");
        }

        // Implementation of IDamagable method
        public void TakeDamage(int amount)
        {
            Hitpoints = Hitpoints - amount;
            if (Hitpoints <= 0) { 
                Die();
            }
        }

        // Implementation of IHealable method
        public void Heal(int amount)
        {
            Hitpoints = Hitpoints + amount;
            Console.WriteLine($"Player healed by {amount} hitpoints. Current hitpoints: {Hitpoints}");
        }

        // Public method that adds an item to the inventory and updates the medals
        public void AddToInventory(Item item)
        {
            // Adds the passed 'item' to the 'Inventory' collection
            Inventory.Add(item);
        }
    }
}
