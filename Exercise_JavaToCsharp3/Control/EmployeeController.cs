using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_JavaToCsharp3_Model;

namespace Exercise_JavaToCsharp3.Control
{
    /*
     * The control layer handles the business logic and coordinates between the TUI and Data layers.
     */
    public class EmployeeController
    {
        // A list that will store employees, using the PersonInterface (which defines what an employee should have).
        private List<PersonInterface> employees;

        // Constructor: This is called when you create a new EmployeeController. 
        // It starts by creating an empty list of employees.
        public EmployeeController()
        {
            employees = new List<PersonInterface>();
        }

        /*
         * This method is used to load employee data. 
         * It receives a list of employees and saves it to the internal list.
         * This is how employee information gets into the controller.
         */
        public void InitializeData(List<PersonInterface> employeeData)
        {
            employees = employeeData;
        }

        /*
         * This method gives other parts of the program access to the list of employees.
         * When called, it returns the list of all employees stored in the controller.
         */
        public List<PersonInterface> GetEmployees()
        {
            return employees;
        }
    }
}
