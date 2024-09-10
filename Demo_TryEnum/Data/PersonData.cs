using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_TryEnum.Model;

namespace Demo_TryEnum.Data
{
    /*
     * The PersonData class serves as a data provider that stores two lists of people.
     * The StringPersons list stores people with job titles as strings (e.g., "Secretary").
     * The EnumPersons list stores people with job titles as enums (JobTitle.Secretary).
     * This design allows the program to work with either approach: one with raw string job titles 
     * (prone to variations or typos) and one with enums (more consistent and error-resistant).
     */
    internal class PersonData
    {
        public List<PersonString> StringPersons = new List<PersonString>()
        {
            new PersonString("Secretary", "Liz"),
            new PersonString("Secretary", "Peter")
        };

        public List<PersonEnum> EnumPersons = new List<PersonEnum>()
        {
            new PersonEnum(JobTitle.Secretary, "Liz"),
            new PersonEnum(JobTitle.Secretary, "Peter")
        };
    }
}