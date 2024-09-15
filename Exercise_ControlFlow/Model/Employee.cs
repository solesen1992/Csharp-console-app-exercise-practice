using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_ControlFlow.Model
{
    public class Employee
    {
        // Properties
        public string Name { get; set; }
        public JobTitle.Jobtitle JobTitle { get; set; } // Update to use JobTitle.Jobtitle enum
        public DateTime HireDate { get; set; }
        public string Email { get; set; }

        // Constructor
        public Employee(string name, JobTitle.Jobtitle jobTitle, DateTime hireDate, string email)
        {
            Name = name;
            JobTitle = jobTitle;
            HireDate = hireDate;
            Email = email;
        }
    }
}
