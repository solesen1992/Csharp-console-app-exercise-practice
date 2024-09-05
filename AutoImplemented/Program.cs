using System;
using AutoImplemented.Model;

namespace AutoImplemented {
    class Program {
        static void Main()
        {
            DateTime aBirthDate = new DateTime(1992, 11, 20);

            AutoPerson aPerson = new AutoPerson("Hans", "Hansen", aBirthDate);

            Console.WriteLine(aPerson);
        }
    }
}