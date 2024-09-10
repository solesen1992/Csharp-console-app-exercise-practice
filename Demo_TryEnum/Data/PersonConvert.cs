using Demo_TryEnum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_TryEnum.Data
{
    /*
     * This code provides a utility to convert a person’s job title from a string-based representation (PersonString) 
     * to an enum-based representation (PersonEnum). It ensures that if the string job title can't be matched to a 
     * known enum value, the job title is set to Unknown, thereby preventing invalid data.
     */
    internal class PersonConvert
    {
        // Define a static method to convert a PersonString object to a PersonEnum object
        // Static means this method can be called without creating an instance of the PersonConvert class
        public static PersonEnum ConvertToPersonEnum(PersonString inPersonString)
        {

            // Declare a variable to hold the converted PersonEnum object
            PersonEnum convertedPerson;

            // Declare a variable to hold the job title as an enum (JobTitle)
            JobTitle foundTitle;

            // Attempt to parse the job title string from the input PersonString into a JobTitle enum value
            // Enum.TryParse tries to convert the string (inPersonString.JobTitle) to the corresponding enum value
            // If successful, it stores the value in foundTitle and returns true; otherwise, it returns false
            bool wasOk = Enum.TryParse(inPersonString.JobTitle, out foundTitle);

            // Check if the conversion was not successful
            if (!wasOk)
            {
                // If the string could not be parsed into a valid enum, set the job title to "Unknown"
                foundTitle = JobTitle.Unknown;
            }

            // Extract the first name from the input PersonString object and store it in foundFirstName
            string foundFirstName = inPersonString.FirstName;

            // Create a new PersonEnum object using the parsed or default job title (foundTitle) and the person's first name (foundFirstName)
            convertedPerson = new PersonEnum(foundTitle, foundFirstName);

            // Return the newly created PersonEnum object
            return convertedPerson;
        }
    }
}