using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_InheritanceGame_GameLogic
{
    // Concrete class representing a BroadSword, inherits from Weapon
    public class BroadSword : Weapon
    {
        public BroadSword(string title) : base(title)
        {
        }

        // Implementation of the Attack method
        public override void Attack(Player playerToAttack)
        {
            Console.WriteLine("Swinging the BroadSword!");
            playerToAttack.Hitpoints -= 25; // Decrement hitpoints by 25
        }

        public override string ToString()
        {
            return $"Broadsword: {Title}";
        }
    }
}
