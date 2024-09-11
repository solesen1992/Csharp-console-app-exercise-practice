using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_GenericsWithConstraints.Things
{
    /*
     * This class represents a Truck and implements an interface called VehicleInterface. 
     * By implementing this interface, the Truck class must define certain properties and methods expected for a vehicle.
     */
    class Truck : VehicleInterface
    {
        public int NumberOfWheels { get; set; }
        public bool CanFly { get; set; }
        public int LoadCapacity { get; set; }

        public string Text()
        {
            string vehicleType = "This vehicle is a Truck";
            return vehicleType;
        }
    }
}
