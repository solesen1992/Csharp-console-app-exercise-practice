﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_InheritanceGame_GameLogic
{
    // Abstract class representing a consumable item, inherits from Item
    public abstract class Consumable : Item
    {
        // Constructor that calls the base class constructor
        protected Consumable(string title) : base(title)
        {
        }

        // Abstract method to be implemented by derived classes
        public abstract void Consume(Player player);
    }
}
