using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace SmallDomainModel
{
    internal class Department
    {
        /**
         * Variables
         */
        private int departmentNumber;
        private string name;
        private List<Employee> employees;

        /**
         * Constructor
         * */
        public Department(int departmentNumber, string name)
        {
            this.departmentNumber = departmentNumber;
            this.name = name;
            this.employees = new List<Employee>();
        }

        /**
         * Getters and setters
         */
        public int DepartmentNumber
        {
            get { return departmentNumber; }
            set { departmentNumber = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        internal List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }


        /**
         * To add employees to department
         */
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        /**
         * To string
         */
        public override string ToString()
        {
            string employeeInfo = "Employees: \n";
            foreach (var employee in employees)
            {
                employeeInfo += employee.ToString() + "\n";
            }
            return $"Department: {Name}, Department Number: {DepartmentNumber}\n{employeeInfo}";
        }
    }
}