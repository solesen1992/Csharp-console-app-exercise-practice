using Exercise_DatabaseFirst.Data;
using Exercise_DatabaseFirst.Model;
using System.Data.Common;


DBConnection dbc = new DBConnection();
List<Cars> cars = dbc.GetAllCars();
foreach (Cars car in cars)
{
    Console.WriteLine(car.ToString());
}

Console.WriteLine("Enter License Plate:");
string licensePlate = Console.ReadLine();

Console.WriteLine("Enter Make:");
string make = Console.ReadLine();

Console.WriteLine("Enter Model:");
string model = Console.ReadLine();

Console.WriteLine("Enter Color:");
string color = Console.ReadLine();

Cars newCar = new(licensePlate, make, model, color);
dbc.InsertCar(newCar);

Thread.Sleep(5000);
cars = dbc.GetAllCars();
foreach (Cars car in cars)
{
    Console.WriteLine(car.ToString());
}
