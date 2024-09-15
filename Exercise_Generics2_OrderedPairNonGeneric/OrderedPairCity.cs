using Exercise_Generics2_OrderedPairNonGeneric.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Generics2_OrderedPairNonGeneric
{
    public class OrderedPairCity : IPairable
    {

        public OrderedPairCity(City first, City second)
        {
            First = first;
            Second = second;
        }

        public void ChangeOrder()
        {
            City temp = First;
            First = Second;
            Second = temp;
        }

        public City First { get; set; }
        public City Second { get; set; }

        public override string ToString()
        {
            return $"First: {First} \nSecond: {Second}";
        }
    }
}
