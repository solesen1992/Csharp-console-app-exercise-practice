using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* CREDIT: Code along session
* Code is made by https://www.youtube.com/watch?v=Ld5D6B2Ntjg
* 
* NOTE:
* Can use an interface that's generic - and implement it with different types.
*/

namespace Demo_GenericsApp
{
    public class EvaluateImportance : IImportance<int>, IImportance<string>
    {
        public int MostImportant(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else 
            {
                return b;
            }
        }

        public string MostImportant(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
