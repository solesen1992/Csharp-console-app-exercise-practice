using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_InheritanceGame_GameLogic
{
    // Concrete class representing a Juice, inherits from Consumable
    public class Juice : Consumable
    {
        // Field for the amount of hitpoints this Juice restores
        private readonly decimal _restoreAmount;

        // Constructor initializes the restore amount and passes the Title to the base class
        public Juice(string title, decimal restoreAmount) : base(title)
        {
            _restoreAmount = restoreAmount;
        }

        // Implementation of the Consume method
        public override void Consume(Player player)
        {
            // Output message to indicate the action
            Console.WriteLine("Yum! Tasty");

            // Restore hitpoints to the player
            player.Hitpoints += _restoreAmount;
        }

        public override string ToString()
        {
            return $"Juice: {Title}";
        }
    }
}
