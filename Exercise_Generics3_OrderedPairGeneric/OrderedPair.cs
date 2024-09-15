using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Generics3_OrderedPairGeneric
{
    public class OrderedPair<T> : IPairable<T>
    {
        // Constructor
        public OrderedPair(T first, T second)
        {
            First = first;
            Second = second;
        }

        // Implemented from the interface
        public void ChangeOrder()
        {
            T temp = First;
            First = Second;
            Second = temp;
        }

        // Properties
        public T First { get; set; }
        public T Second { get; set; }

        // ToString
        public override string ToString()
        {
            return $"First: {First} \nSecond: {Second}";
        }
    }
}
