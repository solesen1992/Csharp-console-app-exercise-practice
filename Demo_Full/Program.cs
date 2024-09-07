using System;
using System.Diagnostics;
using Demo_Full.Model;

namespace Demo_Full
{
    class FullProgram
    {
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