using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_InheritanceGame_GameLogic
{
    // Abstract class representing a weapon, inherits from Item
    public abstract class Weapon : Item
    {
        // Constructor that calls the base class constructor
        protected Weapon(string title) : base(title)
        {
        }

        // Abstract method to be implemented by derived classes
        public abstract void Attack(Player playerToAttack);
    }
}
