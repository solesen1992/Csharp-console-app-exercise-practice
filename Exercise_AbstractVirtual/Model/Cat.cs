using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_AbstractVirtual.Model
{
    internal class Cat : Animal
    {
        // Constructor for Cat
        public Cat(string breed) : base(breed) { }

        // Override abstract Trick method
        public override string Trick()
        {
            return "Jumps very high!";
        }

        // No need to override Feed, it will use the default "Yum"
    }
}
