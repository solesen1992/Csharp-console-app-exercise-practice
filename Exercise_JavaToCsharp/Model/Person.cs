using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_JavaToCsharp.Model
{
    internal class Person
    {
        private String name;
        private int yearOfBirth;

        public Person(String name, int yearOfBirth)
        {
            this.name = name;
            this.yearOfBirth = yearOfBirth;
        }

        public override string? ToString()
        {
            return $"{name} born {yearOfBirth}";
        }
    }
}
