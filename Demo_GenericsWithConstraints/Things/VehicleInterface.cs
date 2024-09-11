using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_GenericsWithConstraints.Things
{
    /*
     * An interface in C# is a reference type that defines a set of methods and properties 
     * that a class must implement. It does not contain any implementation details—just the 
     * signatures of methods, properties, events, or indexers. Classes that implement the 
     * interface must provide their own implementations of these members.
     */
    public interface VehicleInterface
    {
        int NumberOfWheels { get; set; }
        bool CanFly { get; set; }
        string Text();
    }
}
