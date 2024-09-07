using Exercise_ObjectInitialization.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_ObjectInitialization.Model
{
    internal class Employee : Person
    {
        int salary;
        string workFunction;

        // Derived class constructor
        public Employee(string name, DateTime birthdate, int salary, string workFunction)
            : base(name, birthdate)  // Calling the base constructor
        {
            this.salary = salary;
            this.workFunction = workFunction;
        }

        // Overriding ToString to include Employee-specific details
        public override string ToString()
        {
            return $"{base.ToString()} \nSalary: {salary} \nWorkFunction: {workFunction}";
        }
    }
}
