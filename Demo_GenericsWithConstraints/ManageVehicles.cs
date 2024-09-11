using Demo_GenericsWithConstraints.Things;

/*
 * Create an instance of Vehicle with the generic type 'Car'
 * The 'Vehicle<Car>' object represents a car, with 'Car' being the type parameter for 'Tv'
 */
Vehicle<Car> aCar = new Vehicle<Car>
{
    // Set the number of wheels for the car
    NumberOfWheels = 4
};

// Output the number of wheels for the 'aCar' object to the console.
// This prints: "aCar number of wheels: 4"
Console.WriteLine("aCar number of wheels: " + aCar.NumberOfWheels);
// Output the description of the 'aCar' object to the console.
// The Text() method will provide a string that identifies 'aCar' as a 'Car'.
Console.WriteLine(aCar.Text());


/* 
 * Create an instance of Vehicle with the generic type 'Truck'
 * The 'Vehicle<Truck>' object represents a truck, with 'Truck' being the type parameter for 'Tv'
 * This means that 'aTruck' is a vehicle specifically designed for the 'Truck' type.
 */
Vehicle<Truck> aTruck = new Vehicle<Truck>
{
    // Set the number of wheels property for this vehicle to 18.
    NumberOfWheels = 18
};

// Output the number of wheels for the 'aTruck' object to the console.
// This prints: "aTruck number of wheels 18"
Console.WriteLine("aTruck number of wheels " + aTruck.NumberOfWheels);


/* 
 * Create an instance of VehicleData
 * 'VehicleData' is a class designed to manage a collection of vehicles
 */
VehicleData vehicleData = new VehicleData();

// Add the 'aCar' object to the vehicleData collection.
vehicleData.AddVehicle(aCar);
// Add the 'aTruck' object to the vehicleData collection.
vehicleData.AddVehicle(aTruck);

// Iterate over each vehicle in the vehicleData collection.
// 'vehicleData.Vehicles' is assumed to be a collection of VehicleInterface objects.
// This demonstrates polymorphism: 'vehicle' can be any type implementing 'VehicleInterface'
foreach (VehicleInterface vehicle in vehicleData.Vehicles)
{
    // Output the description of each vehicle to the console.
    // The Text() method will provide the type of each vehicle.
    Console.WriteLine(vehicle.Text());

    // Output the number of wheels for each vehicle to the console.
    // This prints the number of wheels for the current vehicle in the iteration.
    Console.WriteLine(vehicle.NumberOfWheels);
}