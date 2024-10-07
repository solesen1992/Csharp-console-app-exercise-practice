using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Demo_GenericsApp;

namespace Demo_GenericsApp
{
    // We pass this T and the T has to be an INumber.
    // It's gonna check to make sure we can do that
    // If we remove the 'where T : INumber<T> it would return a "we cant do that" - because it doesn't know how to add to all types.
    // Generics allows us to make a big math library where you don't have to do convertions.
    public class MathOperations<T> where T : INumber<T>
    {
        public T add(T x, T y)
        {
            return x + y;
        }

    }
}
