using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_TryEnum.Model
{
    /*
     * This is an enum type that defines a fixed set of possible values for a person's job title. 
     * Using an enum ensures that only these specific values are allowed for job titles, reducing the chance of typos or invalid job titles.
     */
    enum JobTitle { Unknown, Secretary, Clerk};

    /*
     * This class, PersonEnum, represents a person with a JobTitle that is stored as an enum (enumeration), 
     * instead of a string like in the PersonString class. This approach enforces a fixed set of job titles, 
     * reducing errors caused by inconsistent or incorrect job title strings.
     */
    internal class PersonEnum
    {
        public JobTitle JobTitle { get; set; }
        public string FirstName { get; set; }
        
        // Constructor
        public PersonEnum(JobTitle jobTitle, string firstName)
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
