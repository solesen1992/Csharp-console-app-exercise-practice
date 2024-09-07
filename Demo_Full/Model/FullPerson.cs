using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Full.Model
{
    internal class FullPerson
    {
        // Private fields
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;

        // Properties
        public string FirstName
        {
            get { return firstName; }
            //set { firstName = value; }

            /**
             * This type of setter are good for preventing bad input.
             * Validates the input before you assign it to a private field.
             */
            set
            {
                if (value != null && !string.IsNullOrWhiteSpace(value))
                {
                    firstName = value;
                }
                else
                {
                    firstName = "No name";
                }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            //set { dateOfBirth = value; }
            set
            {
                //If the date is bigger than the current year
                if (value.Year > (DateTime.Now.Year - 120))
                {
                    dateOfBirth = value;
                }
                else
                {
                    // Could have set it to null by just putting a ? after the DateTime in public DateTime? DateOfBirth
                    dateOfBirth = DateTime.MinValue;
                }
            }
        }


        // No constructor - uses default (empty) constructor


        //ToString method
        public override string? ToString()
        {
            string personString = $"{FirstName} {LastName} was born {DateOfBirth.ToShortDateString()}";
            return personString;
        }
    }
}
