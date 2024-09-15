using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_InheritanceGame_GameLogic
{
    // Concrete class representing Bread, inherits from Consumable
    public class Bread : Consumable
    {
        // Field for the amount of hitpoints this Bread restores
        private readonly decimal _restoreAmount;

        // Constructor initializes the restore amount and passes the Title to the base class
        public Bread(string title, decimal restoreAmount) : base(title)
        {
            _restoreAmount = restoreAmount;
        }

        // Implementation of the Consume method
        public override void Consume(Player player)
        {
            // Output message to indicate the action
            Console.WriteLine("Yum! Delicious bread");

            // Restore hitpoints to the player
            player.Hitpoints += _restoreAmount;
        }

        public override string ToString()
        {
            return $"Bread: {Title}";
        }
    }
}
