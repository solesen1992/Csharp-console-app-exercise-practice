using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_JavaToCsharp3_Model
{
    /*
     * The PersonInterface defines a contract for any class that represents a person.
     * It specifies the properties and methods that must be implemented by classes
     * that adhere to this interface.
     */
    public interface PersonInterface
    {
        // Property to get or set the person's name
        string Name { get; set; }

        // Property to get or set the person's year of birth
        int YearOfBirth { get; set; }

        // Method to add a word to the person's list of favourite words
        void AddFavouriteWord(string word);

        // Method to get the list of the person's favourite words
        List<string> GetFavouriteWords();
    }
}
