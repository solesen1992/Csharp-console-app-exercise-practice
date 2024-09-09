using Demo_TryEnum.Data;
using Demo_TryEnum.Model;

namespace Demo_TryEnum
{
    class Program
    {
        static void Main()
        {
            PersonData personData = new PersonData();

            List<PersonString> personStringList = personData.StringPersons;
            // Display secretaries
            Console.WriteLine("Secretaries");
            foreach (PersonString personString in personStringList)
            {
                if (personString.JobTitle.Equals("secretary")) {

                    Console.WriteLine(personString);
            }
        }
    }
}