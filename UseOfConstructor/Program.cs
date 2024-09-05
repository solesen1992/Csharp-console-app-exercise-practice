// See https://aka.ms/new-console-template for more information
using ObjectInitialization.Model;
using UseOfConstructor.Model;

Console.WriteLine("Hello, World!");

//Person person = new Person();
//Person person2 = new Person("Kalle Frøhop");

//DateTime aBirthday = new DateTime(1982, 01, 31);
//Person person3 = new Person("Malle Musenfryd", aBirthday);
//Person person3 = new Person(aBirthday, "Malle Musenfryd");

//Console.WriteLine("Name: " + person.Name);
//Console.WriteLine("Name: " + person2.Name);
//Console.WriteLine("Name: " + person3.Name + " born at " + aBirthday); // With time and date on the birthday
//Console.WriteLine("Name: " + person3.Name + " born at " + aBirthday.ToShortDateString()); // Removes the time and only shows the date


// Using object initializers
/**Person person = new Person
{
    Name = "Henning",
    Birthdate = new DateTime(1982, 1, 31)
};

Person person2 = new Person
{
    Name = "Frank",
    Birthdate = new DateTime(1983, 2, 16)
};

Console.WriteLine($"Name: {person.Name}, Birthdate: {person.Birthdate.ToShortDateString()}");
Console.WriteLine($"Name: {person2.Name}, Birthdate: {person2.Birthdate.ToShortDateString()}");

Console.WriteLine(person.ToString());
Console.WriteLine(person2.ToString());*/

// Inheritance
Employee employee = new Employee("Karl", new DateTime(1980, 01, 31), 30000, "Cashier");
Employee employee2 = new Employee("P E Dahl", new DateTime(1982, 02, 28), 30000, "Cashier2");

Console.WriteLine(employee.ToString());
Console.WriteLine(" ");
Console.WriteLine(employee2.ToString());


// Create a company using both the company number and name
Company company1 = new Company(12345, "Tech Innovators");

// Print the company information
Console.WriteLine(" ");
Console.WriteLine(company1.ToString());