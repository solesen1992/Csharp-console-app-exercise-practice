using Exercise_ControlFlow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_ControlFlow.Business
{
    public class Salary
    {
        // Method for getting a standard salary for a specific job
        public int GetStandardSalary(JobTitle.Jobtitle jobTitle)
        {
            switch (jobTitle)
            {
                case JobTitle.Jobtitle.Developer:
                    return 40000;
                    break;
                case JobTitle.Jobtitle.Analyst:
                    return 40000;
                    break;
                case JobTitle.Jobtitle.Manager:
                    return 50000;
                    break;
                case JobTitle.Jobtitle.Designer:
                    return 35000;
                    break;
                case JobTitle.Jobtitle.Tester:
                    return 30000;
                    break;
                case JobTitle.Jobtitle.Architect:
                    return 60000;
                    break;
                default:
                    return 0; // Unknown job title
            }
        }

        // Method to calculate seniority years
        public int GetSeniorityYears(DateTime hireDate)
        {
            // Calculate the initial difference in years
            int years = DateTime.Now.Year - hireDate.Year;

            // Check if the hire date anniversary has not occurred yet this year
            if (hireDate.Date > DateTime.Now.AddYears(-years).Date)
            {
                years--; // Decrement the year count if the anniversary is in the future
            }

            return years;
        }

        // Method to calculate current salary
        public string GetCurrentSalary(Employee employee)
        {
            // First check for invalid data
            if (employee.HireDate > DateTime.Now || employee.HireDate.Year < 1900)
            {
                // If hire date is in the future or year is less than 1900, return "N/A"
                // Indicating salary could not be calculated due to invalid hire date
                return "N/A";
            }

            // Retrieve the standard salary based on the employee's job title
            int standardSalary = GetStandardSalary(employee.JobTitle);

            // Calculate the number of years the employee has been with the company
            int seniorityYears = GetSeniorityYears(employee.HireDate);

            // Initialize bonus percentage based on years of seniority
            double bonusPercentage = 0;

            // Determine bonus percentage based on seniority years
            if (seniorityYears >= 3 && seniorityYears <= 8)
            {
                // Employees with 3-8 years receive a 10% bonus
                bonusPercentage = 0.10;
            }
            else if (seniorityYears >= 9 && seniorityYears <= 16)
            {
                // Employees with 9-16 years receive a 20% bonus
                bonusPercentage = 0.20;
            }
            else if (seniorityYears >= 17 && seniorityYears <= 25)
            {
                // Employees with 17-25 years receive a 5% deduction
                bonusPercentage = -0.05;
            }
            else if (seniorityYears >= 26)
            {
                // Employees with 26 or more years receive a 20% deduction
                bonusPercentage = -0.20;
            }

            // Calculate the current salary based on the standard salary and bonus percentage
            double currentSalary = standardSalary + (standardSalary * bonusPercentage);

            // Return the current salary formatted to 2 decimal places
            return currentSalary.ToString("F2");
        }

    }
}
