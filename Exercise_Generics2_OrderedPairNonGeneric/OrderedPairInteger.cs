using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Generics2_OrderedPairNonGeneric
{
    public class OrderedPairInteger : IPairable
    {

        public OrderedPairInteger(int first, int second)
        {
            First = first;
            Second = second;
        }

        public void ChangeOrder()
        {
            int temp = First;
            First = Second;
            Second = temp;
        }

        public int First { get; set; }
        public int Second { get; set; }

        public override string ToString()
        {
            return $"First: {First} \nSecond: {Second}";
        }

    }
}
