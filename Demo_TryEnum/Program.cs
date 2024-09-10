using Demo_TryEnum.Data;
using Demo_TryEnum.Model;

namespace Demo_TryEnum

    /*
     * Ctrl + K + C = Out-comment text
     * Ctrl + K + U = Un-comment text
     */
{
    class Program
    {
        static void Main()
        {
            // Creating PersonData object
            PersonData personData = new PersonData();

            /* 
             * Used for PersonString.cs in the model layer
             * 
             * This code filters the list of people and prints out only those whose job title (stored as a string) 
             * matches "secretary", regardless of case (i.e., it handles "Secretary", "secretary", etc.).
             * It first converts the job title to lowercase, compares it to the lowercase string "secretary", and if matched, 
             * prints the details of the person using the ToString() method of the PersonString class.
             */

            // Retrieve the list of PersonString objects from PersonData
            List<PersonString> personStringListForPersonString = personData.StringPersons;

            // Print a heading indicating the start of the secretaries list
            Console.WriteLine("Secretaries - PersonString.cs");

            // Loop through each PersonString object in the personStringList
            foreach (PersonString personString in personStringListForPersonString)
            {
                // Convert the JobTitle to lowercase and check if it equals "secretary"
                // This ensures that the check is case-insensitive (e.g., "Secretary", "SECRETARY", "secretary" are all valid)
                if (personString.JobTitle.ToLower().Equals("secretary"))
                {
                    // If the job title matches "secretary", print the PersonString object
                    // This will call the ToString() method and display the person's details
                    Console.WriteLine(personString);
                }
            }


            /* 
             * Used for PersonEnum.cs in the model layer
             * A better way of doing it than the past one. Prevents variations in strings.
             * 
             * This code filters out and prints only the people who have the job title "Secretary" from the list of people 
             * stored as PersonEnum objects. It uses enums for job titles, which ensures that only the exact enum 
             * value JobTitle.Secretary will be matched.
             */

            // Retrieve the list of PersonEnum objects from PersonData
            List< PersonEnum > personStringListForPersonEnum = personData.EnumPersons;

            // Print a heading indicating the start of the secretaries list
            Console.WriteLine("\nSecretaries - PersonEnum.cs");

            // Loop through each PersonEnum object in the personStringList
            foreach (PersonEnum personEnum in personStringListForPersonEnum)
            {
                // Check if the JobTitle of the current personEnum is "Secretary"
                if (personEnum.JobTitle == JobTitle.Secretary)
                {
                    // If the job title is "Secretary", print the personEnum object
                    // This will call the ToString method and display the person's details
                    Console.WriteLine(personEnum);
                }
            }


            /*
             * Used for PersonConvert.cs
             * 
             * The code converts a list of people with their job titles stored as strings into a list of people with their job titles 
             * stored as an enumerated type (enum). This process helps to avoid variations in job titles (such as capitalization differences) 
             * and ensures consistency in the data.
             */

            // Retrieve the list of PersonString objects from PersonData
            List<PersonString> personStringListForPersonConvert = personData.StringPersons;

            // Create an empty list to hold the converted PersonEnum objects
            List<PersonEnum> convertPerson = new List<PersonEnum>();

            // Declare a variable to temporarily hold each converted PersonEnum object
            PersonEnum temporaryPersonEnum;

            // Loop through each PersonString object in the personStringList
            foreach (PersonString personString in personStringListForPersonConvert)
            {
                // Convert the current PersonString object to a PersonEnum object
                temporaryPersonEnum = PersonConvert.ConvertToPersonEnum(personString);

                // Add the converted PersonEnum object to the convertPerson list
                convertPerson.Add(temporaryPersonEnum);
            }

            // Print a heading indicating the start of the secretaries list
            Console.WriteLine("\nSecretaries - PersonConvert.cs");

            // Loop through each PersonEnum object in the convertPerson list
            foreach (PersonEnum personEnum in convertPerson)
            {
                // Print the details of the current PersonEnum object
                // This calls the overridden ToString() method, which outputs the person's first name and job title
                Console.WriteLine(personEnum);
            }
        }
    }
}