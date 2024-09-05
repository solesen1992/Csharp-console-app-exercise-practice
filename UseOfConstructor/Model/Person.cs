using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfConstructor.Model
{
    internal class Person
    {
        private string name;
        private DateTime birthdate;

        // A property
        /**public string Name { 
            get { return name; }
        }*/

        // Constructor
        // Gives name a default value
        /**public Person(string? inName = null)
        {
            name = inName;
        }*/

        // Constructor with name and birth
        public Person(string name, DateTime birthdate)
        {
            this.name = name;
            this.birthdate = birthdate;
        }

        // Makes an error: Optional parameters must appear after all required parameters
        /**public Person(string? inName = null, DateTime birthdate)
        {
            name = inName;
            this.birthdate = birthdate;
        }*/

        /**public Person(DateTime birthdate, string? inName = null)
        {
            name = inName;
            this.birthdate = birthdate;
        }*/


        // To use object initializers
        public string Name { get => name; set => name = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }

        // To string method
        public override string? ToString()
        {
            return $"Name: {Name} \nBirthdate: {Birthdate.ToShortDateString()}";
        }
    }
}
