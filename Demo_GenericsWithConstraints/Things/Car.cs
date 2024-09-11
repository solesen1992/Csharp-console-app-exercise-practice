using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_GenericsWithConstraints.Things
{

    /*
     * This class represents a Car, which implements a VehicleInterface. 
     * The Car class provides properties for the number of wheels, whether it can fly, and its speed.
     */
    class Car : VehicleInterface
    {
        public int NumberOfWheels { get; set; }
        public bool CanFly { get; set; }
        public int speed { get; set; }

        public string Text()
        {
            string vehicleType = "This vehicle is a Car";
            return vehicleType;
        }
    }
}
