using System;
using Demo_AutoImplemented.Model;

namespace Demo_AutoImplemented
{
    class Program
    {
        static void Main()
        {
            DateTime aBirthDate = new DateTime(1992, 11, 20);

            AutoPerson aPerson = new AutoPerson("Hans", "Hansen", aBirthDate);

            Console.WriteLine(aPerson);
        }
    }
}