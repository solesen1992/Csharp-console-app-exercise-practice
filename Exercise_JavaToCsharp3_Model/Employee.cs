namespace Exercise_JavaToCsharp3_Model
{
    /*
     * The Employee class represents an employee and implements the PersonInterface
     */
    public class Employee : PersonInterface
    {
        // Public properties for accessing the employee's name and year of birth
        public string Name { get; set; }
        public int YearOfBirth { get; set; }

        // Private list to store the employee's favourite words
        private List<string> FavouriteWords { get; set; }

        /* 
         * Constructor to initialize an Employee object with name and year of birth
         */
        public Employee(string name, int yearOfBirth)
        {
            Name = name; // Set the employee's name
            YearOfBirth = yearOfBirth; // Set the employee's year of birth
            FavouriteWords = new List<string>(); // Initialize the list of favourite words
        }

        /* 
         * Method to add a new favourite word to the employee's list
         */
        public void AddFavouriteWord(string word)
        {
            // Add the word to the list of favourite words
            FavouriteWords.Add(word); 
        }

        /* 
         * Method to get the list of favourite words
         */
        public List<string> GetFavouriteWords()
        {
            // Return the list of favourite words
            return FavouriteWords; 
        }

        /* 
         * Override the ToString method to provide a custom string representation of the Employee
         */
        public override string ToString()
        {
            // Format the employee's name and year of birth into a string
            return $"Name: {Name} - born: {YearOfBirth}";
        }
    }
}
