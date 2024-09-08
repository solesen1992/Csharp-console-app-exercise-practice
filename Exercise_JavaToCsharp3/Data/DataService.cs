using Exercise_JavaToCsharp3_Model; // This imports the model classes that include Employee and PersonInterface
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_JavaToCsharp3.Data
{   
    /*
     * The DataService class is responsible for initializing and providing employee data.
     * It simulates a data layer that creates employee objects and assigns their details.
     */
    public class DataService
    {
        /*
         * This method, InitializeData, creates a list of employees and adds some initial data to it.
         * It returns a list of employees to be used by other parts of the program.
         */
        public List<PersonInterface> InitializeData()
        {
            // Creating a list of employees (PersonInterface type) and adding two Employee objects with names and birth years
            var employees = new List<PersonInterface>
            {
                new Employee("Hans Hansen", 1999),
                new Employee("Niels Nielsen", 1997)
            };

            // Adding favorite words to the first employee (Hans Hansen)
            employees[0].AddFavouriteWord("Git");
            employees[0].AddFavouriteWord("gut");
            employees[0].AddFavouriteWord("got");

            // Adding favorite words to the second employee (Niels Nielsen)
            employees[1].AddFavouriteWord("Lit");
            employees[1].AddFavouriteWord("lut");
            employees[1].AddFavouriteWord("lot");

            // Returning the list of employees with their details and favorite words
            return employees;
        }
    }
}
