using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_InheritanceGame_GameLogic
{
    public class Katana : Weapon
    {
        public Katana(string title) : base(title)
        {
        }

        public override void Attack(Player playerToAttack)
        {
            Console.WriteLine("Swinging the Katana weapon!");
            playerToAttack.Hitpoints -= 30; // Decrement hitpoints by 30
        }

        public override string ToString()
        {
            return $"Katana: {Title}";
        }
    }
}
