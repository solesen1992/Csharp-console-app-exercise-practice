using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_GenericsWithConstraints.Things
{
    class VehicleData
    {
        public List<VehicleInterface> Vehicles { get; set; }

        // Constructor
        public VehicleData()
        {
            Vehicles = new List<VehicleInterface>();
        }

        // Add vehicle to list
        public void AddVehicle(VehicleInterface vehicle)
        {
            Vehicles.Add(vehicle);
        }
    }
}
