using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_JavaToCsharp2.Db
{
    internal class Employee : PersonInterface
    {
        public string EmployeeName { get; set; }
        public List<string> FavouriteWords { get; set; }

        // Constructor
        public Employee(string inName)
        {
            EmployeeName = inName;
            FavouriteWords = new List<string>();
        }

        // Add new word to list of favourite words
        public void AddFavouriteWord(String newWord)
        {
            FavouriteWords.Add(newWord);
        }
    }
}
