using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* CREDIT: Code along session
* Code is made by https://www.youtube.com/watch?v=Ld5D6B2Ntjg
* 
* NOTE:
* Example of constraints.
*/

namespace Demo_GenericsApp
{
    // Makes constraints. where T : new() = It says that this T must have an empty constructor.
    // Commas means this AND this
    // where T : notnull = should be not null. This is not an error.
    // where T : class, new() = where T has a class and a blank constructor.
    // where T : BetterList<T> = This is betterList of T or one of it's children.
    // where T : IImportance<T> = This T should implement an interface
    // public class SampleClass<T, U> where T : U = where T and U are the same. Or that U derives from T.
    // Maybe this T is a base class and U is a child class. Etc.
    public class SampleClass<T> where T : new()
    {

    }
}
