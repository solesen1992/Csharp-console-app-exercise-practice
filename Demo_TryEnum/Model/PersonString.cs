using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_TryEnum.Model
{
    /*
     * This class, PersonString, represents a simple model for a person, where both the person's job title and first name are stored as strings.
     */
    class PersonString
    {
        public string JobTitle { get; set; }
        public string FirstName { get; set; }

        // Constructor
        public PersonString(string jobTitle, string firstName)
        {
            JobTitle = jobTitle;
            FirstName = firstName;
        }

        // ToString
        public override string ToString()
        {
            return $"{FirstName} is a {JobTitle}";
        }
    }
}
