using System;
using Exercise_ControlFlow.Model;
using Exercise_ControlFlow.Business;

class Program
{
    static void Main(string[] args)
    {
        // Create some employee objects
        Employee employee1 = new Employee("Donald Duck", JobTitle.Jobtitle.Developer, new DateTime(1992, 9, 21), "donald@duck.pond");
        Employee employee2 = new Employee("Mickey Mouse", JobTitle.Jobtitle.Manager, new DateTime(2000, 5, 10), "mickey@mouse.house");

        // Create Salary object
        Salary salaryService = new Salary();

        // Display employee data and salary
        DisplayEmployeeSalary(employee1, salaryService);
        DisplayEmployeeSalary(employee2, salaryService);
    }

    static void DisplayEmployeeSalary(Employee employee, Salary salaryService)
    {
        Console.WriteLine($"{employee.Name}, {employee.JobTitle}, Hired: {employee.HireDate.ToShortDateString()}");
        Console.WriteLine($"Standard salary: {salaryService.GetStandardSalary(employee.JobTitle)}");
        Console.WriteLine($"Specific salary: {salaryService.GetCurrentSalary(employee)}");
        Console.WriteLine($"Email: {employee.Email}");
        Console.WriteLine();
    }
}