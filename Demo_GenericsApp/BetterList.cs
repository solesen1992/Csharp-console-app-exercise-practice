using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* CREDIT: Code along session
* Code is made by https://www.youtube.com/watch?v=Ld5D6B2Ntjg
*/

namespace Demo_GenericsApp
{
    /* 
     * Generic class
     */
    public class BetterList<T>
    {
        private List<T> data = new();

        public void AddToList(T value) { 
            data.Add(value);
            Console.WriteLine($"{value} has been added to the list");
        }
    }
}
