using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DomainModelToCsharp
{
    internal class Employee
    {
        /**
         * Variables
         */
        private string ssn;
        private string firstName;
        private string lastName;

        /**
         * Constructor
         */
        public Employee(string ssn, string firstName, string lastName)
        {
            this.ssn = ssn;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        /**
         * Get and setters
         */
        public string Ssn
        {
            get { return ssn; }
            set { ssn = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        /**
         To string
         */
        public override string ToString()
        {
            return $"Employee: {FirstName} {LastName}, SSN: {Ssn}";
        }
    }
}