using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_GenericsWithConstraints.Things
{
    /*
     * Generics vehicle class
     * 
     * The class Vehicle<Tv> is generic, meaning it can work with any type, but the type Tv is constrained.
     * 
     * Constraints:
     * Tv : class ensures that the type Tv must be a reference type (a class, not a struct).
     * Tv : VehicleInterface ensures that the type Tv must implement the VehicleInterface, 
     * meaning any type passed to Vehicle<Tv> must behave like a vehicle (having properties or methods defined by VehicleInterface).
     * 
     * The Vehicle<Tv> class implements VehicleInterface. This requires the class to define certain properties 
     * and methods that all vehicles (like cars, trucks, etc.) must have.
     */

    // Constraint in the type of vehicles we can make. It should be a class and implement vehicleInterface
    class Vehicle<Tv> : VehicleInterface where Tv : class, VehicleInterface
    {
        public int NumberOfWheels { get; set; }
        public bool CanFly { get; set; }

        public string Text()
        {
            // Get the name of the generic type 'Tv' as a string using reflection (typeof(Tv).ToString()).
            // This will return the full name (namespace + class) of the type passed as 'Tv'.
            string vehicleType = typeof(Tv).ToString();

            // Modify the vehicleType string by concatenating "This vehicle is a " with the type name.
            // This creates a more readable sentence indicating what kind of vehicle it is.
            vehicleType = "This vehicle is a " + vehicleType;

            // Return the final string, which describes the type of vehicle.
            return vehicleType;
        }
    }
}
