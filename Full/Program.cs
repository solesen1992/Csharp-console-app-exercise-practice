using System;
using System.Diagnostics;
using Full.Model;

namespace Full {
    class FullProgram { 
        static void Main()
        {
            FullPerson aPerson = new FullPerson();

            aPerson.FirstName = " ";
            aPerson.LastName = "Hansen";
            DateTime aBirthDate = new DateTime(1992, 11, 20);
            aPerson.DateOfBirth = aBirthDate;

            Console.WriteLine(aPerson);
        }
    }
}