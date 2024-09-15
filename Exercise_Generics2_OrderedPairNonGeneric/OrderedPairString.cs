using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Generics2_OrderedPairNonGeneric
{
    public class OrderedPairString : IPairable
    {

        public OrderedPairString(string first, string second)
        {
            First = first;
            Second = second;
        }

        public void ChangeOrder()
        {
            string temp = First;
            First = Second;
            Second = temp;
        }

        public string First { get; set; }
        public string Second { get; set; }

        public override string ToString()
        {
            return $"First: {First} \nSecond: {Second}";
        }
    }
}
