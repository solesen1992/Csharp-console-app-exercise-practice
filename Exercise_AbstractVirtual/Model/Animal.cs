using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_AbstractVirtual.Model
{
    // Abstract class Animal
    public abstract class Animal
    {
        // Properties
        public string breed { get; set; }

        // Constructor
        protected Animal(string breed)
        {
            this.breed = breed;
        }

        // Abstract method for the trick
        public abstract string Trick();

        // Virtual method for feeding (can be overridden)
        public virtual string Feed()
        {
            return "Yum";
        }
    }
}
