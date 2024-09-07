using Demo_HelpCode.Data;
using Demo_HelpCode.Model;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/**
 * We have connected HelpCode to the ConsoleApp project.
 * Got added by clicking "add project reference".
 */
StudentAccess studAcc = new StudentAccess();

// Returnerer en liste af students
List<Student> studs = studAcc.DemoStudents;

// Print all student names
Console.WriteLine("List of students:");
foreach (Student stud in studs)
{
    Console.WriteLine(stud);
}
