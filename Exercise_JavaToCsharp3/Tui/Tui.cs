using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Exercise_JavaToCsharp3.Control; // Import the Control namespace to access the EmployeeController class

namespace Exercise_JavaToCsharp3.Tui
{
    /*
     * The Tui class is responsible for displaying employee information to the user.
     * It interacts with the Control layer to get the data it needs to show.
     */
    public class Tui
    {
        // Reference to the EmployeeController which manages employee data
        private Control.EmployeeController control;

        /*
         * Constructor for the Tui class.
         * It takes an EmployeeController object as a parameter and stores it in the control field.
         */
        public Tui(EmployeeController control)
        {
            this.control = control;
        }

        /*
         * This method fetches the list of employees from the EmployeeController
         * and prints each employee's details and their favourite words to the console.
         */
        public void DisplayEmployees()
        {
            // Get the list of employees from the EmployeeController
            var employees = control.GetEmployees();

            // Iterate through each employee in the list
            foreach (var employee in employees)
            {
                // Print the employee's details (name and birth year) using the ToString method
                Console.WriteLine(employee.ToString());
                // Print the employee's favourite words, joining them with a space in between
                Console.WriteLine("Favourite words: " + string.Join(" ", employee.GetFavouriteWords()));
            }
        }
    }
}
