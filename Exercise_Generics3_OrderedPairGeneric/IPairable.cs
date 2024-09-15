using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Generics3_OrderedPairGeneric
{
    public interface IPairable<T>
    {
        void ChangeOrder();
    }
}
