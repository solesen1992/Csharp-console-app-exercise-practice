// See https://aka.ms/new-console-template for more information
using Exercise_DomainModelToCsharp;
using System.Xml.Linq;

Console.WriteLine("Hello, World!");

Console.WriteLine("Helloooo 2");

// Create Employee objects
Employee employee01 = new Employee("123-45-6789", "John", "Doe");
Employee employee02 = new Employee("987-65-4321", "Jane", "Smith");
Employee employee03 = new Employee("555-55-5555", "Alice", "Johnson");
Employee employee04 = new Employee("555-55-6666", "Alison", "Jensen");
Employee employee05 = new Employee("555-55-7777", "Jack", "Smith");
Employee employee06 = new Employee("555-55-8888", "Simone", "Williams");
Employee employee07 = new Employee("555-55-9999", "John", "Johnson");

// Create Department objects
Department department01 = new Department(101, "HR");
Department department02 = new Department(102, "IT");

// Add employees to departments
department01.AddEmployee(employee01);
department01.AddEmployee(employee02);
department01.AddEmployee(employee06);
department02.AddEmployee(employee03);
department02.AddEmployee(employee04);
department02.AddEmployee(employee05);
department02.AddEmployee(employee07);

// Add departments to a list
List<Department> departments = new List<Department>();
departments.Add(department01);
departments.Add(department02);

// Print all employees
Console.WriteLine("All Employees:");
Console.WriteLine(employee01.ToString());
Console.WriteLine(employee02.ToString());
Console.WriteLine(employee03.ToString());
Console.WriteLine(employee04.ToString());
Console.WriteLine(employee05.ToString());
Console.WriteLine(employee06.ToString());
Console.WriteLine(employee07.ToString());
Console.WriteLine(" ");

// Print all departments and their employees
Console.WriteLine("All departments:");
Console.WriteLine(department01.ToString());
Console.WriteLine(department02.ToString());

// Print all departments and their employees version 2
Console.WriteLine("\nAll Departments version 2:");
foreach (var department in departments)
{
    Console.WriteLine(department.ToString());
}