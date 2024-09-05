using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplemented.Model
{
    internal class AutoPerson
    {
        // Auto implemented properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }


        // Constructor
        public AutoPerson(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        //ToString method
        public override string? ToString()
        {
            string personString = $"{FirstName} {LastName} was born {DateOfBirth.ToShortDateString()}";
            return personString;
        }
    }
}
