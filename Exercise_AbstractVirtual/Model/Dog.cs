using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_AbstractVirtual.Model
{
    public class Dog : Animal
    {
        // Constructor for Dog
        public Dog(string breed) : base(breed) { }

        // Override abstract Trick method
        public override string Trick()
        {
            return "Barks very loud!";
        }

        // Override virtual Feed method
        public override string Feed()
        {
            return "Yum - carrot";
        }
    }
}
