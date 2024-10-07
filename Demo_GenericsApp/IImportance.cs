using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_GenericsApp
{
    /*
     * Makes something generic on an interface level.
     */
    public interface IImportance<T>
    {
        // Pass in two values of the same type. Will give back the value that is the most important one.
        T MostImportant(T a, T b);
    }
}
